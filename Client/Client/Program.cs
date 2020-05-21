using Plates.Client.Net;
using System;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            SocketManager socketManager = new SocketManager("127.0.0.1", 11000);
            if(socketManager.Connect()== SocketError.Success)
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
                            
                            byte []send= System.Text.Encoding.UTF8.GetBytes("你好啊");
                            socketManager.Send(send);
                        }
                    }
                }
            }

            Console.WriteLine("客户端结束");
        }
    }
}
