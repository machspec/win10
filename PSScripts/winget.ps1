# winget.ps1
# Author: odjacobs
# Purpose: Install winget if not already installed

if (-not (Test-Path ~\AppData\Local\Microsoft\WindowsApps\winget.exe)) {
    Start-Process "ms-appinstaller:?source=https://aka.ms/getwinget"
    $nid = (Get-Process AppInstaller).Id
    Wait-Process -Id $nid
}