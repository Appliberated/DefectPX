; DefectPX Installer 64-bit
;
; Copyright © Appliberated
; https://www.appliberated.com/defectpx/

[Setup]
AppName=DefectPX
AppVersion=2.0.0
AppVerName=DefectPX
WizardStyle=modern
DefaultDirName={autopf}\DefectPX
DefaultGroupName=DefectPX
UninstallDisplayIcon={app}\DefectPX.exe
DisableWelcomePage=no
LicenseFile=Files\LICENSE
Compression=lzma2
SolidCompression=yes
OutputBaseFilename=defectpx-installer-win64
; Setup cannot run on anything but x64.
ArchitecturesAllowed=x64
; On x64 use the native 64-bit Program Files directory and the 64-bit view of the registry.
ArchitecturesInstallIn64BitMode=x64

[Files]
Source: "Files\DefectPX.exe"; DestDir: "{app}"
Source: "Files\README"; DestDir: "{app}"
Source: "Files\DefectPX.settings.json"; DestDir: "{localappdata}\Appliberated\DefectPX"; Flags: ignoreversion onlyifdoesntexist


[Icons]
Name: "{group}\DefectPX"; Filename: "{app}\DefectPX.exe"
Name: "{group}\DefectPX Help"; Filename: "https://www.appliberated.com/defectpx/help/"

[Run]
Filename: "{app}\DefectPX.exe"; Description: "Launch DefectPX"; Flags: postinstall nowait skipifsilent
