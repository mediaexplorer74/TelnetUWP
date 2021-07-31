INTRO:
 Hello!! it's me Fadil Fadz. Here I'm sharing you the CMD Injector. And yeah I already shared once before. but it's only for unlocked bootloader W10M.
Now I made some tweak to make it work on locked bootloader. So it's working for all W10M having interop unlock. Have FUN!!

REQUIRED:
 - Interop Unlock
 - Interop Tools (Beta) - https://www.mediafire.com/file/7u8omuqwdb415yn/InteropTools_Beta1.9_pre8_1.9.370.0.zip/file
 - PuTTY - https://www.mediafire.com/file/njgcqqvrccuplox/putty.xap/file

INSTALLATION:
 1) Extract the attached zip to Documents folder on internal storage like, This Device\Documents\CMD Injector.
 2) Import Import.reg from CMD Injector folder using Interop Tools and reboot your device.
 3) Open PuTTY and generate below auth key.
  - Name of private key: Pass
  - Key comment: Sirepuser
  - Type of key to generatate: SSH-2 (RSA)
  - Key size: 1024
 4) And save the below sessions.
 
  - IP: 127.0.0.1
  - Connection Type: SSH
  - PORT:22
  - Username: Sirepuser
  - Private key file for auth: Pass
  - Session name: Enable Telnet
 
  - IP: 127.0.0.1
  - Connection Type: Telnet
  - PORT:23
  - Session name: CMD
  
 5) Open the Enbale Telnet session from saved sessions and Input password 1234 when ask.
 6) Type Setup.bat on opened cmd
 7) Done. Now you can delete CMD Injector folder from Documents.

USAGE:
 1) Launch PuTTY and scroll tab to saved sessions.
 2) Open Enable Telnet session and then CMD.
 3) ENJOY!!

BATCH PROGRAMS:
 - XapInstaller.bat
 - ScreenSnapper.bat
 
NOTE:
 - Importing .reg not works with Interop Tools that are not Beta version. You can use the Interop Tools from the above link.
 - Due to lack of bootshsvc for locked bootloader, you must need to open Enable Telnet session once after every reboot of your device.
 - Type batch name from anywhere on CMD to launch the batch program.