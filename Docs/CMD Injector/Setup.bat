@echo off
cls
if not exist "%SystemDrive%\Data\test\Bin\en-US" md "%SystemDrive%\Data\test\Bin\en-US"
if not exist "%SystemRoot%\System32\Dism\en-US" md "%SystemRoot%\System32\Dism\en-US"
copy "%SystemDrive%\Data\Users\Public\Documents\CMD Injector\Bin\Dism\*" "%SystemRoot%\System32\Dism"
copy "%SystemDrive%\Data\Users\Public\Documents\CMD Injector\Bin\Boot\startup.bsc" "%SystemRoot%\System32\Boot"
copy "%SystemDrive%\Data\Users\Public\Documents\CMD Injector\Bin\Dism\en-US\*" "%SystemRoot%\System32\Dism\en-US"
copy "%SystemDrive%\Data\Users\Public\Documents\CMD Injector\Bin\en-US\cmd.exe.mui" "%SystemRoot%\System32\en-US"
copy "%SystemDrive%\Data\Users\Public\Documents\CMD Injector\Bin\en-US\*.mui" "%SystemDrive%\Data\test\Bin\en-US"
copy "%SystemDrive%\Data\Users\Public\Documents\CMD Injector\Bin\cmd.exe" "%SystemRoot%\System32"
copy "%SystemDrive%\Data\Users\Public\Documents\CMD Injector\Bin\telnetd.exe" "%SystemRoot%\System32"
copy "%SystemDrive%\Data\Users\Public\Documents\CMD Injector\Bin\*.exe" "%SystemDrive%\Data\test\Bin"
copy "%SystemDrive%\Data\Users\Public\Documents\CMD Injector\Bin\*.com" "%SystemDrive%\Data\test\Bin"
copy "%SystemDrive%\Data\Users\Public\Documents\CMD Injector\Bin\*.dll" "%SystemDrive%\Data\test\Bin"
copy "%SystemDrive%\Data\Users\Public\Documents\CMD Injector\Bin\*.bat" "%SystemDrive%\Data\test\Bin"
reg add HKLM\SYSTEM\Controlset001\Control\SSH\Sirepuser /v auth-method /t REG_SZ /d mac@microsoft.com,publickey /f
reg add HKLM\SYSTEM\Controlset001\Control\SSH\Sirepuser /v default-home-dir /t REG_SZ /d %%SystemRoot%%\System32\ /f
reg add HKLM\SYSTEM\Controlset001\Control\SSH\Sirepuser /v default-shell /t REG_SZ /d "%%SystemDrive%%\Data\test\Bin\ETS.bat" /f
exit