# update.ps1
# Purpose: Update Windows 10. Designed for future intigration into GUI.

# Run this business as administrator
if (-Not ([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)) {
    if ([int](Get-CimInstance -Class Win32_OperatingSystem | Select-Object -ExpandProperty BuildNumber) -ge 6000) {
        Start-Process PowerShell -Verb RunAs -ArgumentList "-NoProfile -ExecutionPolicy Bypass -Command `"cd '$pwd'; & '$PSCommandPath';`"";
        Exit;
    }
}

# Installs PSWindowsUpdate if needed and imports it.
if (Get-Module -ListAvailable -Name PSWindowsUpdate) {
    Import-Module PSWindowsUpdate 
}
else {
    Write-Host "Module not installed"
    Set-PSRepository -Name 'PSGallery' -InstallationPolicy Trusted
    Install-Module PSWindowsUpdate
    Import-Module PSWindowsUpdate
}

# Runs Windows Update
Get-WindowsUpdate
Install-WindowsUpdate -AcceptAll