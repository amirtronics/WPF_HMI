@echo off
setlocal enabledelayedexpansion

for /f "delims=" %%a in ('wmic OS Get localdatetime ^| find "."') do set datetime=%%a
set folderName=HMI
set projectName=HMI

mkdir %folderName%
cd %folderName%

dotnet new sln -n %projectName%
dotnet new wpf -n %projectName%

dotnet sln add %projectName%\%projectName%.csproj
start devenv.exe %projectName%.sln