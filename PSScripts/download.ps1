# download.ps1
# Purpose: Designed for future intigration into GUI. May or may not be needed in the future
# Author: odjacobs

#if (-not (Test-Path .\downloads)) {
#    mkdir .\downloads
#}

foreach ($param in $args) {
    switch ($param) {

        # Browsers
        "firefox" { winget install Mozilla.Firefox }
        "firefox-esr" { winget install Mozilla.Firefox.ESR }
        "firefox-devel" { winget install Mozilla.Firefox.DeveloperEdition }
        "firefox-beta" { winget install Mozilla.Firefox.Beta }
        "librewolf" { winget install LibreWolf.LibreWolf }
        "waterfox" { winget install Waterfox.Waterfox }
        "waterfox-classic" { winget install Waterfox.Waterfox.Classic }
        "chrome" { winget install Google.Chrome }
        "chrome-devel" { winget install Google.Chrome.Dev }
        "chrome-beta" { winget install Google.Chrome.Beta }
        "brave" { winget install BraveSoftware.BraveBrowser }
        "brave-beta" { winget install BraveSoftware.BraveBrowser.Beta }
        "brave-devel" { winget install BraveSoftware.BraveBrowser.Dev }
        "opera" { winget install Opera.Opera }
        "opera-beta" { winget install Opera.Opera.Beta }
        "opera-gx" { winget install Opera.OperaGX }

        # Code
        "vscode" { winget install Microsoft.VisualStudioCode }
        "vscode-devel" { winget install Microsoft.VisualStudioCode.Insiders }
        "vscodium" { winget install VSCodium.VSCodium }
        "npp" { winget install Notepad++.Notepad++ }
        "github-desktop" { 
            winget install Git.Git
            winget install Github.GithubDesktop 
        }

        # Nice to have
        "everything" { winget install voidtools.Everything }
        "everything-lite" { winget install voidtools.Everything.Lite }
        "everything-alpha" { winget install voidtools.Everything.Alpha }
        "everything-toolbar" { winget install stnkl.EverythingToolbar }
        "7zip" { winget install 7zip.7zip }
        "powertoys" { winget install Microsoft.PowerToys }
        "gimp" { winget install GIMP.GIMP }
        "krita" { winget install KDE.Krita }
        "vlc" { winget install VideoLAN.VLC }

        # Screenshot
        "flameshot" { winget install Flameshot.Flameshot }
        "greenshot" { winget install Greenshot.Greenshot }
        
        # Office applications
        "acrobat" { winget install Adobe.Acrobat.Reader.64-bit }
        "onedrive" { winget install Microsoft.OneDrive }
        "m365" { winget install Microsoft.Office }

        # Stress test
        "boinc" { winget install UCBerkeley.BOINC }
        "blender" { winget install BlenderFoundation.Blender }


        default {
            "$param is not currently supported."
        }
    }
}