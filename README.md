# GroupPolicyEditor1
Group Policy editor for common group policy control items in Windows 10 / Windows 2019 environment.
<br><br>
The GPO objects covered are as follows :
<br><br><h6>
1. Enable/Disable Firewall (Domain profile) - HKLM:\\SOFTWARE\\Policies\\Microsoft\\WindowsFirewall\\DomainProfile<br>
2. Enable/Disable Firewall (Standard profile) - HKLM:\\SOFTWARE\\Policies\\Microsoft\\WindowsFirewall\\StandardProfile<br>
3. Group Policy refresh interval - HKLM:\\Software\\Policies\\Microsoft\\Windows\\System -Name GroupPolicyRefreshTime<br>
4. Group Policy refresh time offset - HKLM:\\Software\\Policies\\Microsoft\\Windows\\System -Name GroupPolicyRefreshTimeOffset<br>
5. No Autorun option enable/disable - HKLM:\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\NoAutoRun<br>
6. Disable Cortana in Windows 10 Searches (Only applicable for Windows 10 Home, Professional & Enterprise)<br>
7. Disable Windows Store (Only applicable for Windows 10 Professional & Enterprise)<br>
8. Screen saver activation, with password, and timeout setting<br>
<br><br></h6>
Please also find Powershell script equivalent of this program in the repository (file name : group_policy_win10_v2.ps1).
<br><br>
<i>Note : <br>
a) This was tested in Windows 10 Professional Edition environment , and should work on Windows 10 Enterprise Edition (and WIndows 2016) as well.<br>
b) This program will NOT work for Windows 8.1, Windows Vista, Windows 7, and Windows XP.<br>
c) It is designed for local GPO of Windows 10 (local profile), and NOT for domain level GPO objects.<br>
d) This CLI EXE program is designed to edit registry settings, so please run it in adiministrator mode.<br>
  </i>
  <br><br>
  I did not include a USAGE manual , as it is easy & straight forward to use.
