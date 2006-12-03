; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
AppName=Quest Designer
AppVerName=Quest Designer 0.4.3.2
AppPublisher=DOL Tools
DefaultDirName={pf}\Quest Designer
DefaultGroupName=Quest Designer
AllowNoIcons=yes
OutputDir=G:\_WORK\DOLTools\
OutputBaseFilename=QuestDesignerSetup
Compression=lzma
SolidCompression=yes
ChangesAssociations=yes
InfoAfterFile=readme.txt

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "associatefiletype"; Description: "{cm:AssocFileExtension,Quest Designer, .qst}"; GroupDescription: "{cm:AdditionalIcons}";

[Files]
Source: "G:\_WORK\DOLTools\QuestDesigner\bin\Release\*"; DestDir: "{app}"; Excludes: "data,*.vshost.*,NETXP*.xml,*.pdb"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Quest Designer"; Filename: "{app}\QuestDesigner.exe"; WorkingDir: "{app}";
Name: "{group}\{cm:UninstallProgram,Quest Designer}"; Filename: "{uninstallexe}"
Name: "{userdesktop}\Quest Designer"; Filename: "{app}\QuestDesigner.exe"; WorkingDir: "{app}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\Quest Designer"; Filename: "{app}\QuestDesigner.exe"; WorkingDir: "{app}"; Tasks: quicklaunchicon

[Registry]
Root: HKCR; Subkey: ".qst"; ValueType: string; ValueName: ""; ValueData: "QuestDesignerFile"; Flags: uninsdeletevalue; Tasks: associatefiletype
Root: HKCR; Subkey: "QuestDesignerFile"; ValueType: string; ValueName: ""; ValueData: "Quest Designer File"; Flags: uninsdeletekey; Tasks: associatefiletype
Root: HKCR; Subkey: "QuestDesignerFile\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\QuestDesigner.exe,0"; Tasks: associatefiletype
Root: HKCR; Subkey: "QuestDesignerFile\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\QuestDesigner.exe"" ""%1"""; Tasks: associatefiletype

[Run]
Filename: "{app}\QuestDesigner.exe"; WorkingDir: "{app}"; Description: "{cm:LaunchProgram,Quest Designer}"; Flags: nowait postinstall skipifsilent
