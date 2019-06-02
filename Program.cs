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
            // Set console windows , add 10 units/rows/columns to width and height - https://docs.microsoft.com/en-us/dotnet/api/system.console.setwindowsize?view=netframework-4.8
            int origWidth, width;
            int origHeight, height;

            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;

            width = origWidth + 10;
            height = origHeight + 10;
            Console.SetWindowSize(width, height);

            //Main program functions execution
            Menu_intro();
            Menu_of_changes();
            string x = Console.ReadLine();

        }

        static void Menu_intro ()
        {
            string appName = "Group Policy Editor";
            string appVersion = "1.0.0";
            string appAuthor = "Velan Ramalinggam (velanr@gmail.com)";
            string appdesc1 = "This tool helps define/set frequently used Group Policy items in enterprise IT compliance and security.";
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

        static void Menu_of_changes()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", "Group Policy Editor Menu :");
            Console.WriteLine("{0}", "1. Enable/Disable Firewall (Domain profile) - HKLM:\\SOFTWARE\\Policies\\Microsoft\\WindowsFirewall\\DomainProfile");
            Console.WriteLine("{0}", "2. Enable/Disable Firewall (Standard profile) - HKLM:\\SOFTWARE\\Policies\\Microsoft\\WindowsFirewall\\StandardProfile");
            Console.WriteLine("{0}", "3. Group Policy refresh interval - HKLM:\\Software\\Policies\\Microsoft\\Windows\\System -Name GroupPolicyRefreshTime");
            Console.WriteLine("{0}", "4. Group Policy refresh time offset - HKLM:\\Software\\Policies\\Microsoft\\Windows\\System -Name GroupPolicyRefreshTimeOffset");
            Console.WriteLine("{0}", "5. No Autorun option enable/disable - HKLM:\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\NoAutoRun");
            Console.WriteLine("{0}", "6. NTP time server name option - HKLM:\\Software\\Policies\\Microsoft\\W32time\\Parameters\\NtpServer");
            Console.WriteLine("{0}", "7. NTP server type - HKLM:\\Software\\Policies\\Microsoft\\W32time\\Parameters\\Type");
            Console.WriteLine("{0}", "8. Enable / disable NTP client - HKLM:\\Software\\Policies\\Microsoft\\W32time\\TimeProviders\\NtpClient");
            Console.WriteLine("{0}", "9. Disable Cortana in Windows 10 Searches (Only applicable for Windows 10 XXXXXXX)");
            Console.WriteLine("{0}", "10. Disable Windows Store (Only applicable for Windows 10 XXXXXXX)");
            Console.WriteLine("{0}", "11. Screen saver activation, with password, and timeout setting");


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
