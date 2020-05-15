@echo off
set final=%vsprojects%\_ExtendedCommands
set n=%cd%\bin\Release\
copy /y CSharpExtendedCommands.cs "%final%"
copy /y "%n%\CSharpExtendedCommands.dll" "%final%"