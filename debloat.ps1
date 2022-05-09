# debloat.ps1
# Purpose: Remove pre-installed garbage from Windows 10
# Author: odjacobs

$bloatware = @(
    # Microsoft crap
    "Microsoft.MinecraftUWP"
    "Microsoft.GamingServices"
    "Microsoft.MicrosoftSolitaireCollection"
    "Microsoft.NetworkSpeedTest"
    "Microsoft.News"
    "Microsoft.XboxApp"
    "Microsoft.Xbox.TCUI"
    "Microsoft.XboxGameOverlay"
    "Microsoft.XboxGameCallableUI"
    "Microsoft.XboxSpeechToTextOverlay"
    "Microsoft.MicrosoftOfficeHub"

    # Sponsored Bloat
    "*EclipseManager*"
    "*ActiproSoftwareLLC*"
    "*AdobeSystemsIncorporated.AdobePhotoshopExpress*"
    "*Duolingo-LearnLanguagesforFree*"
    "*PandoraMediaInc*"
    "*CandyCrush*"
    "*BubbleWitch3Saga*"
    "*Wunderlist*"
    "*Flipboard*"
    "*Twitter*"
    "*Facebook*"
    "*Royal Revolt*"
    "*Sway*"
    "*Speed Test*"
    "*Dolby*"
    "*Viber*"
    "*ACGMediaPlayer*"
    "*Netflix*"
    "*OneCalendar*"
    "*LinkedInforWindows*"
    "*HiddenCityMysteryofShadows*"
    "*Hulu*"
    "*HiddenCity*"
    "*AdobePhotoshopExpress*"
    "*HotspotShieldFreeVPN*"
    "*Disney*"
    "*PicsArt*"
    "*PolarrPhotoEditorAcademicEdition*"
    "*AutodeskSketchBook*"
    "*DisneyMagicKingdoms*"
    "*MarchofEmpires*"
    "*Plex*"
    "*iHeartRadio*"
    "*FarmVille*"
    "*Duolingo*"
    "*CyberLink*"
    "*DolbyAccess*"
    "*Drawboard*"
    "*Fitbit*"
    "*GAMELOFTSA*"
    "*KeeperSecurityInc*"
    "*NORDCURRENT*"
    "*PandoraMediaInc"
    "*Playtika*"
    "*Shazam*"
    "*SlingTV*"
    "*Spotify*"
    "*ThumbmunkeysLtd*"
    "*TuneIn*"
    "*WinZip*"
    "*XING*"
    "*flaregamesGmbH*"
    "*king.com.*"
    "TheNewYorkTimes.NYTCrossword"
)

foreach ($bloat in $bloatware) {
    Get-AppxPackage -Name $bloat | Remove-AppxPackage
}

# TODO: Implement unpinning the garbage from start menu


# Registry tweaks to turn off Microsoft's nonsense
# Disable Telemetry
Set-ItemProperty -Path "HKLM:\Software\Policies\Microsoft\Windows\DataCollection" -Name "AllowTelemetry" -Type DWord -Value 0

# Disable Advertising ID
If (!(Test-Path "HKCU:\Software\Microsoft\Windows\CurrentVersion\AdvertisingInfo")) {
    New-Item -Path "HKCU:\Software\Microsoft\Windows\CurrentVersion\AdvertisingInfo" | Out-Null
}
Set-ItemProperty -Path "HKCU:\Software\Microsoft\Windows\CurrentVersion\AdvertisingInfo" -Name "Enabled" -Type DWord -Value 0

# Sticky keys, task view
Set-ItemProperty -Path "HKCU:\Control Panel\Accessibility\StickyKeys" -Name "Flags" -Type String -Value "506"
Set-ItemProperty -Path "HKCU:\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced" -Name "ShowTaskViewButton" -Type DWord -Value 0

# Prevents "Suggested Applications" returning
New-FolderForced -Path "HKLM:\SOFTWARE\Policies\Microsoft\Windows\CloudContent"
Set-ItemProperty -Path "HKLM:\SOFTWARE\Policies\Microsoft\Windows\CloudContent" "DisableWindowsConsumerFeatures" 1
