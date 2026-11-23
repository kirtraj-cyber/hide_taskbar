# hide_taskbar
Taskbar Toggle is a lightweight, dependency-free PowerShell script to hide or show the Windows taskbar on Windows 10 and Windows 11. Built with native user32.dll APIs, it toggles taskbar visibility in one click with no extra tools or setup required.




# option 1
you dont need to do any thing only download the powershell.exe file double click and boom your task bar is hide angin click to unhide 

# option 2 (if option 1 failed)
download ToggleTaskbar.cs and open powershell in this file folder and run this command 
& "$env:WINDIR\Microsoft.NET\Framework64\v4.0.30319\csc.exe" /target:winexe /out:ToggleTaskbar.exe ToggleTaskbar.cs


# now it will work 99.999999%
