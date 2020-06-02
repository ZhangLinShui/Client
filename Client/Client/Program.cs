﻿using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Plates.Client.Net;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ESC to exit...");
            while (true)
            {//若有键按下，且是 ESC 键，则度退出循环
                ConsoleKey InputKey = Console.ReadKey(true).Key;
                if (InputKey == ConsoleKey.Escape) break;
                if (InputKey == ConsoleKey.Spacebar)
                {
                    List<Task> t = new List<Task>();
                    for (int i = 0; i < 1; i++)
                    {
                        SocketManager socketManager = new SocketManager("127.0.0.1", 11000);
                        socketManager.Connect();
                        t.Add(Task.Factory.StartNew(() =>
                        {
                            AddProducts(socketManager);
                        }));
                    }
                    Task.WaitAll(t.ToArray());
                    Console.WriteLine("客户端当前线程ID：" + Thread.CurrentThread.ManagedThreadId.ToString());
                }
            }
        }
        static string message = "H";
        static void AddProducts(SocketManager socketManager)
        {
            Person person = new Person()
            {
                Aliases = string.Empty,
                BodyLength = 10,

            };
            Random ran = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                int RandKey = ran.Next(100, 1026);
                for (int j = 0; j < RandKey; j++)
                {
                    person.Aliases += "1";
                }
                person.BodyLength = RandKey;
                
                byte[] send = System.Text.Encoding.UTF8.GetBytes(message);
                person.Body = ByteString.CopyFrom(send);
                socketManager.Send(person);
            }
        }
        static void AddProducts1()
        {
            SocketManager socketManager = new SocketManager("127.0.0.1", 11000);
            if (socketManager.Connect() == SocketError.Success)
            {
                Console.WriteLine("Press ESC to exit...");
                while (true)
                {
                    ConsoleKey InputKey;
                    //若有键按下，且是 ESC 键，则度退出循环
                    if (Console.KeyAvailable)
                    {
                        InputKey = Console.ReadKey(true).Key;
                        if (InputKey == ConsoleKey.Escape) break;
                        if (InputKey == ConsoleKey.Spacebar)
                        {

                            byte[] send = System.Text.Encoding.UTF8.GetBytes("你好啊");
                            //socketManager.Send(send);
                        }
                    }
                }
            }
            Console.WriteLine("当前线程ID：" + Thread.CurrentThread.ManagedThreadId.ToString());
            Console.WriteLine("客户端结束");
        }
    }
}
