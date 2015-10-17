@REM set PATH=C:\Program Files\7-Zip;C:\Program Files (x86)\Git\bin;%PATH%
@SETLOCAL
@set ZIPFILE=%1
@set BASEDIR=%2
@set CONFIG=%3
@mkdir zip
@pushd zip
@mkdir bin
@echo Microsoft. > %BASEDIR%\bin-exclude.txt
@echo System. >> %BASEDIR%\bin-exclude.txt
@echo Newtonsoft. >> %BASEDIR%\bin-exclude.txt
xcopy %BASEDIR%\DummyConsoleApp1\bin\%CONFIG%\*.* bin /S /Y /R /EXCLUDE:%BASEDIR%\bin-exclude.txt
@rmdir /S/Q %TEMP%\dummy-git
git clone --depth=1 --single-branch --separate-git-dir=%TEMP%\dummy-git https://github.com/giuliov/BuildTests.wiki.git docs
@del /F /Q docs\.git
xcopy %BASEDIR%\LICENSE* /Y /R
7z a %BASEDIR%\%ZIPFILE% -r
@popd
@ENDLOCAL

