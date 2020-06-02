@echo off
set Path=%CD%
cd /d Path
del f/s/q/a *.meta
echo 删除.meta 文件完成
echo 按任意键退出
@pause