XAPinst/ MicroTelnet 1.0.8 alpha (Experimental Project for Microsoft 10 Mobile)
================================================================

"XAPinst" ("MicroTelnet") app  is open-sourced UWP project.
My main goal is to do useful GUI for mobile variant of XAP installation , without any PC.

XAPinst solution consists of 2 parts:
A. Backend (by Fadil Fadz)
B. Frontend (by ME)

Quick notes:
* Use only if You very experienced IT-man!
* Part A is stable (based on CMD Injector created by Fadil Fadz)
* Part B is unstable, but.. works sometimes somehow! 


A. BACKEND
----------

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
In some W10 Phones MicroTelnet cannot connect to localhost directly (internal W10M firewall ganerates this problem). 
For example, I have this problem on my Lumia 950. 
I made 2 reg files:
fullaccess_on.reg - internal firewall will switched off when importing this reg file and rebooting the phone
fullaccess_off.reg - internal firewall will switched ON when importing this reg file and rebooting the phone

"Firewall off" (FullAccess) mode violate on some dev procedures... so use it only on your own risk!!

Please, help to improve my code (if You know SA, CSharp system coding, etc.). Feel free to poll request.

 Github repo here:
 https://github.com/mediaexplorer74/MicroTelnet 
(for feedback, issues discussion, and your pull requests))

CREDITS
Big thanks to:
Fadil Fadz


Good luck! 

-- MediaExplorer 2021
