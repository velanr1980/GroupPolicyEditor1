# Copyright reserved , Velan Ramalinggam (velanr@gmail.com), 2019
#
Set-ItemProperty -Path HKLM:\SOFTWARE\Policies\Microsoft\WindowsFirewall\DomainProfile -Name EnableFirewall -Value 1
Set-ItemProperty -Path HKLM:\SOFTWARE\Policies\Microsoft\WindowsFirewall\StandardProfile -Name EnableFirewall -Value 1
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\System -Name GroupPolicyRefreshTime -Value 1440
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\System -Name GroupPolicyRefreshTimeOffset -Value 30
Set-ItemProperty -Path HKLM:\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer -Name NoAutorun -Value 1
Set-ItemProperty -Path 'HKLM:\Software\Policies\Microsoft\Windows\CurrentVersion\Internet Settings\Cache' -Name Persistent -Value 0
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\W32time\Parameters -Name NtpServer -Value xxx.com
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\W32time\Parameters -Name Type -Value NTP
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\W32time\TimeProviders\NtpClient -Name Enabled -Value 1
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\Installer -Name AlwaysInstallElevated -Value 1
Set-ItemProperty -Path 'HKLM:\SOFTWARE\Policies\Microsoft\Windows\Windows Search' -Name AllowCortana -Value 0
Set-ItemProperty -Path 'HKLM:\SOFTWARE\Policies\Microsoft\Windows\Windows Search' -Name AllowCortanaAboveLock -Value 0
Set-ItemProperty -Path 'HKLM:\SOFTWARE\Policies\Microsoft\Windows\Windows Search' -Name ConnectedSearchUseWeb -Value 1
Set-ItemProperty -Path 'HKLM:\SOFTWARE\Policies\Microsoft\Windows\Windows Search' -Name ConnectedSearchUseWebOverMeteredConnections -Value 1
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\WindowsStore -Name RemoveWindowsStore -Value 1
Set-ItemProperty -Path HKLM:\System\CurrentControlSet\Control\Lsa -Name DisableDomainCreds -Value 1
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name NoAutoUpdate -Value 0
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name AUOptions -Value 4
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name AutomaticMaintenanceEnabled -Value 0
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name ScheduledInstallDay -Value 6
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name ScheduledInstallTime -Value 12
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name ScheduledInstallEveryWeek -Value 1
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name UseWUServer -Value 1
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name WUServer -Value http://xxx.com
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name WUStatusServer -Value http://xxx.com
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name DetectionFrequencyEnabled -Value 1
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name DetectionFrequency -Value 1
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name NoAUShutdownOption -Value 0
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name NoAUAsDefaultShutdownOption -Value 0
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name ElevateNonAdmins -Value 1
Set-ItemProperty -Path HKLM:\Software\Policies\Microsoft\Windows\WindowsUpdate\AU -Name AutoInstallMinorUpdates -Value 1
Set-ItemProperty -Path 'HKCU:\Control Panel\Desktop' -Name ScreenSaveActive -Value 1
Set-ItemProperty -Path 'HKCU:\Control Panel\Desktop' -Name ScreenSaverIsSecure -Value 1
Set-ItemProperty -Path 'HKCU:\Control Panel\Desktop' -Name ScreenSaveTimeOut -Value 600
Set-ItemProperty -Path 'HKCU:\Software\Microsoft\office\16.0\outlook\preferences' -Name disableattachmentpreviewing -Value 1
Set-ItemProperty -Path 'HKCU:\Software\Microsoft\office\14.0\Outlook' -Name DisableBasicAuthSavedCreds -Value 1
Set-ItemProperty -Path 'HKCU:\Software\Microsoft\office\15.0\Outlook\RPC' -Name DisableBasicAuthSavedCreds -Value 1