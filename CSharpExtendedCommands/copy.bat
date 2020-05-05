@echo off
set final=..\..\_ExtendedCommands
set n=%cd%\bin\Release\
copy /y CSharpExtendedCommands.cs "%final%"
copy /y "%n%\CSharpExtendedCommands.dll" "%final%"
cd "..\..\..\"
REM "Auto Zip and Upload.exe"