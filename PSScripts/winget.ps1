# winget.ps1
# Author: odjacobs
# Purpose: Install winget if not already installed

if (-not (Test-Path ~\AppData\Local\Microsoft\WindowsApps\winget.exe)) {
    # Ensure the Microsoft Store is installed.
    # It is not included in LTSC releases and is required for this program.
    WSReset -i&&TimeOut 20&&WSReset -i
    Start-Process "ms-appinstaller:?source=https://aka.ms/getwinget"
    $nid = (Get-Process AppInstaller).Id
    Wait-Process -Id $nid
}