@echo off
setlocal enabledelayedexpansion

set repo_path=C:\Work\Codes\HMI\VS\WPF_HMI\HMI
set file_names=App.xaml App.xaml.cs AssemblyInfo.cs HMI.csproj MainWindow.xaml MainWindow.xaml.cs
set "episodeName=HMI"

set "sln_commit=false"

for %%F in (%file_names%) do (
    
    set file_path=.\!episodeName!\%%F
    set commit_message=Create %%F

    cd %repo_path%
    echo !file_path!
    git add !file_path!

    git commit -m "!commit_message!"
    git push

    echo Commit and Push Complete!
)



if "%sln_commit%"=="true" (
    set file_path=.\!episodeName!\HMI.sln
    set commit_message=Create HMI.sln
    git add !file_path!

    git commit -m "!commit_message!"
    git push

    echo Commit and Push Complete!
)