using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace GroupPolicyEditor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu_intro();
            Menu_changes();
        }

        static void Menu_intro ()
        {
            string appName = "Group Policy Editor";
            string appVersion = "1.0.0";
            string appAuthor = "Velan Ramalinggam (velanr@gmail.com)";
            string appdesc1 = "This tool helps define frequently used Group Policy items in enterprise IT compliance and security.";
            //string appdesc2 = "It is useful as it can help eliminate malware execution by attachment preview of malware infected Office documents/macro via unpatched Office bugs.";
            string appcoverage = "Covers Local group policy (Local GP). \nIt DOES NOT cover Active Directory based (AD) group policy.";
            //Console.ForegroundColor = ConsoleColor.Red;            
            string appnote = "Note : Make sure to run this program in administrator mode (Run as administrator)";

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.WriteLine();
            Console.WriteLine("{0}", appdesc1);
            //Console.WriteLine("{0}", appdesc2);
            Console.WriteLine();
            Console.WriteLine("{0}", appcoverage);
            Console.WriteLine();
            //Console.WriteLine("Outlook path : {0}", outlookinstallpath1);
            //Console.WriteLine("Outlook version : Microsoft Outlook {0}", outlookver1);
            //Console.WriteLine("Outlook disable attachement preview : {0}", outlookdisableattachpreviewpath2);
            //Console.WriteLine();
            //Console.WriteLine("Outlook disable attachment preview registry path : ");
            //Console.WriteLine("SubKey HKCU\\SOFTWARE\\Policies\\Microsoft\\office\\<version number>\\outlook\\preferences, Key disableattachmentpreviewing");
            //Console.WriteLine();
            Console.WriteLine("{0}", appnote);
            Console.WriteLine();

        }

        static void Menu_changes()
        {
            Console.WriteLine("{0}", "Menu :");
            Console.WriteLine("{0}", "1. HKLM:\SOFTWARE\Policies\Microsoft\WindowsFirewall\DomainProfile - Enable/Disable Firewall");
            Console.WriteLine("{0}", "2. HKLM:\SOFTWARE\Policies\Microsoft\WindowsFirewall\StandardProfile - Enable/Disable Firewall");
            Console.WriteLine("{0}", "3. HKLM:\Software\Policies\Microsoft\Windows\System -Name GroupPolicyRefreshTime - Group Policy refresh interval");
            Console.WriteLine("{0}", "4. HKLM:\Software\Policies\Microsoft\Windows\System -Name GroupPolicyRefreshTimeOffset - Group Policy refresh time offset");
            Console.WriteLine("{0}", "5. HKLM:\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\NoAutoRun - No Autorun option enable/disable");
            Console.WriteLine("{0}", "6. HKLM:\Software\Policies\Microsoft\W32time\Parameters\NtpServer - NTP time server name option");
            Console.WriteLine("{0}", "7. HKLM:\Software\Policies\Microsoft\W32time\Parameters\Type - NTP server type");
            Console.WriteLine("{0}", "8. HKLM:\Software\Policies\Microsoft\W32time\TimeProviders\NtpClient - Enable / disable NTP client");
            Console.WriteLine("{0}", "9. Disable Cortana in Windows 10 Searches (Only applicable for WIndows 10 XXXXXXX)");
            Console.WriteLine("{0}", "9. Disable Windows Store (Only applicable for WIndows 10 XXXXXXX)");


        }

            // Check registry key & subkey value in LocalMachine - https://www.infoworld.com/article/3073167/how-to-access-the-windows-registry-using-c.html
            static string ReadSubKeyValue_LocalMachine(string subKey, string key)
        {
            string str = string.Empty;
            using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(subKey))
            {
                if (registryKey != null)
                {
                    str = registryKey.GetValue(key).ToString();
                    registryKey.Close();
                }
            }
            return str;
        }

        // Check registry key & subkey value in CurrentUser - https://www.infoworld.com/article/3073167/how-to-access-the-windows-registry-using-c.html
        static string ReadSubKeyValue_CurrentUser(string subKey, string key)
        {
            string str = string.Empty;
            using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(subKey))
            {
                try
                {
                    str = registryKey.GetValue(key).ToString();

                }
                catch (NullReferenceException e)
                {
                    str = null;
                    //registryKey.Close();
                    //Console.WriteLine("{0}", e);
                }
                catch (ArgumentNullException e)
                {
                    str = null;
                    //registryKey.Close();
                    //Console.WriteLine("{0}", e);
                }


            }

            return str;
        }

        //if (input1 == "ENABLE" && outlookver2 == "2010")
        //    {
        //       RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\office");
        //key = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\office\\14.0");
        //        key = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\office\\14.0\\outlook");
        //        key = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\office\\14.0\\outlook\\preferences");
        //        using (key)
        //        {
        //
        //            key.SetValue("disableattachmentpreviewing", "00000000", RegistryValueKind.DWord);
        //            key.Close();
        //        }
        //}
    }
}
