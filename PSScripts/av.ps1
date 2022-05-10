# av.ps1
# Purpose: Download and run Anti-Malware and Anti-Virus programs
# Author: odjacobs

if (-not (Test-Path .\av)) {
    mkdir .\av
}

Invoke-WebRequest "https://downloads.malwarebytes.com/file/0050573" -OutFile ".\av\mbam.exe"
Invoke-WebRequest "https://bits.avcdn.net/productfamily_CCLEANER/insttype_FREE/platform_WIN_PIR/installertype_ONLINE/build_RELEASE/cookie_mmm_ccl_003_999_d6e_m" -OutFile ".\av\ccleaner.exe"
Invoke-WebRequest "https://downloadcenter.mcafee.com/products/mcafee-avert/stinger/stinger64.exe" -OutFile ".\av\stinger64.exe"
