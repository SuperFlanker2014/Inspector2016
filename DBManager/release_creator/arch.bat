del Update.sfx.exe
del Inspector_new.exe
del Templates < y
del V:\Inspector_Project\Inspector2016\Inspector\bin\x86\Release\Obfuscated\Inspector.exe

V:\Inspector_Project\ConfuserEx_bin\Confuser.CLI.exe V:\Inspector_Project\InspectorObfuscate2016.crproj

copy V:\Inspector_Project\Inspector2016\Inspector\bin\x86\Release\Obfuscated\Inspector.exe V:\Inspector_Project\Inspector2016\DBManager\bin\x86\Release\Inspector_new.exe
copy V:\Inspector_Project\Inspector2016\Inspector\Templates\* V:\Inspector_Project\Inspector2016\DBManager\bin\x86\Release\Templates\ 

v:\Programs\TCPU71\Programm\WinRar\WinRar.exe a -r -zcomments.txt -sfx Update.sfx.exe Templates\*.* DBManager.exe Inspector_new.exe update.sql DBManager.exe.config link.url link2.url Inspector.Core.dll