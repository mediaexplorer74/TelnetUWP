TelnetUWP 1.0.0 alpha (Experimental Project for Microsoft 10 Mobile)
===================================================================

<img height="600" src="art/art.gif" />

TelnetUWP app  is open-sourced UWP project.
My main goal is to do useful UWP variant of Telnet app for Windows 10 Mobile.

TelnetUWP solution consists of 2 parts:
A. Backend (by Fadil Fadz)
B. Frontend (by ME)

Quick notes:
* Use only if You very experienced IT-man!
* Part A is stable (based on CMD Injector created by Fadil Fadz)
* Part B is unstable, but.. works sometimes somehow! 


A. BACKEND
----------

See DOCs folder

XapInst.bat  - "background xap installer" (as +1 for/to CMD Injector)

1) Full interop your W10M phone 
2) Use CMD Injector (please, search this distrib at "Windows 10 Mobile (Lumia)" group files repo at Telegram)
3) In Lumia 950 do registry import (fa.reg)
4) Reboot
5) Start telnet session


B. FrontEnd
-----------
"Binaries - "standard" appxbundle (.appxbundle + .cer + depandancies) 

Simply install it by App Installer on your Win10Mobile device :)

Known Problems
--------------
In some W10 Phones TelnetUWP cannot connect to localhost directly (internal W10M firewall generates this problem). 
For example, I have this problem on my Lumia 950. 

I made 2 reg files:
fullaccess_on.reg - internal firewall will switched off when importing this reg file and rebooting the phone
fullaccess_off.reg - internal firewall will switched ON when importing this reg file and rebooting the phone

"Firewall off" (FullAccess) mode violate on some dev procedures... so use it only on your own risk!!

Please, help to improve my code (if You know SA, CSharp system coding, etc.). Feel free to poll request.

 Github repo here:
 https://github.com/mediaexplorer74/TelnetUWP 
(for feedback, issues discussion, and your pull requests))

CREDITS
Big thanks to:
Fadil Fadz


Good luck! 

-- MediaExplorer 2021
