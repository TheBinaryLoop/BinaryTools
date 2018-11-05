@echo off
REM Build Solution
SET CONFIGURATION=%1
SET MSBUILD_EXE="C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\MSBuild\15.0\Bin\MSBuild.exe"
set PATH_SOURCE_SLN="%cd%\BinaryTools.sln"
if [%1]==[] (
    SET CONFIGURATION=DebugNET40
)
REM else if [%1]==[Debug] (
    REM echo %CONFIGURATION%
    REM %MSBUILD_EXE% %PATH_SOURCE_SLN% /p:Configuration=%CONFIGURATION%
    REM SET CONFIGURATION=DebugNET45
    REM echo %CONFIGURATION%
REM ) else if [%1]==[Release] (
    REM SET CONFIGURATION=ReleaseNET40
    REM echo %CONFIGURATION%
    REM %MSBUILD_EXE% %PATH_SOURCE_SLN% /p:Configuration=%CONFIGURATION%
    REM SET CONFIGURATION=ReleaseNET45
    REM echo %CONFIGURATION%
REM )
REM echo %CONFIGURATION%
@%MSBUILD_EXE% %PATH_SOURCE_SLN% /p:Configuration=%CONFIGURATION%
SET "CONFIGURATION="