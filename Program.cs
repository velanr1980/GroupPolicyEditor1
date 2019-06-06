using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace GroupPolicyEditor1
{
    class Program
    {
        public static bool BetweenRanges(int a, int b, int number)
        {
            return (a <= number && number <= b);
        }
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

            // Force console input as correct int type
            int input = Convert.ToInt16(Console.ReadLine());

            // Check input is within choice range
            while (!BetweenRanges(1, 11, input))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0}", "WRONG MENU OPTION. PLEASE KEY IN AGAIN.");
                Console.WriteLine();
                input = Convert.ToInt16(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Changes(input);

            Console.WriteLine("{0}", "The policy tasks is completed.");
            input = Convert.ToInt16(Console.ReadLine());

        }

        static void Menu_intro()
        {
            string appName = "Group Policy Editor";
            string appVersion = "1.0.0";
            string appAuthor = "Velan Ramalinggam (velanr@gmail.com)";
            string appdesc1 = "This tool helps define/set frequently used Group Policy items in enterprise IT compliance and security.";
            string appcoverage = "Covers Local group policy (Local GP). \nIt DOES NOT cover Active Directory based (AD) group policy.";                       
            string appnote = "Note : Make sure to run this program in administrator mode (Run as administrator)";
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.WriteLine();
            Console.WriteLine("{0}", appdesc1);            
            Console.WriteLine();
            Console.WriteLine("{0}", appcoverage);
            Console.WriteLine();            
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
            Console.WriteLine("{0}", "6. Disable Cortana in Windows 10 Searches (Only applicable for Windows 10 Home, Professional & Enterprise)");
            Console.WriteLine("{0}", "7. Disable Windows Store (Only applicable for Windows 10 Professional & Enterprise)");
            Console.WriteLine("{0}", "8. Screen saver activation, with password, and timeout setting");
            Console.WriteLine();
            Console.WriteLine("{0}", "PLEASE KEY IN WHICH CHANGES TO IMPLEMENT :");
            Console.WriteLine();
            Console.WriteLine("{0}", "> ");

        }

        static void Changes(int input1)
        {
            if (input1 == 1) //1. Enable/Disable Firewall (Domain profile) - HKLM:\\SOFTWARE\\Policies\\Microsoft\\WindowsFirewall\\DomainProfile
            {
                int opt1_changes;
                Console.WriteLine();
                Console.WriteLine("{0}", "Enable or disable firewall? Press 1 to enable, 2 to disable");

                opt1_changes = Convert.ToInt16(Console.ReadLine());

                while (!BetweenRanges(1, 2, opt1_changes))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}", "WRONG OR INVALID INPUT. PLEASE KEY IN AGAIN.");
                    Console.WriteLine();
                    opt1_changes = Convert.ToInt16(Console.ReadLine());
                }

                // Link reference https://social.msdn.microsoft.com/Forums/en-US/0b9f37c4-6ef4-46ce-a411-b95558df745b/how-do-i-forcibly-enable-windows-firewall-with-advanced-security-for-domain-profile?forum=windowsdeveloperpreviewgeneral

                Console.ForegroundColor = ConsoleColor.Green;

                if (opt1_changes == 1)
                {
                    RegistryKey key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsFirewall");
                    key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsFirewall\\DomainProfile");

                    using (key)
                    {

                        key.SetValue("EnableFirewall", "00000000", RegistryValueKind.DWord);
                        key.Close();
                    }
                }
                if (opt1_changes == 2)
                {
                    RegistryKey key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsFirewall");
                    key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsFirewall\\DomainProfile");

                    using (key)
                    {

                        key.SetValue("EnableFirewall", "00000001", RegistryValueKind.DWord);
                        key.Close();
                    }
                }
            }

            if (input1 == 2) //2. Enable/Disable Firewall (Standard profile) - HKLM:\\SOFTWARE\\Policies\\Microsoft\\WindowsFirewall\\StandardProfile
            {
                int opt2_changes;
                Console.WriteLine();
                Console.WriteLine("{0}", "Enable or disable firewall? Press 1 to enable, 2 to disable");

                opt2_changes = Convert.ToInt16(Console.ReadLine());

                while (!BetweenRanges(1, 2, opt2_changes))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}", "WRONG OR INVALID INPUT. PLEASE KEY IN AGAIN.");
                    Console.WriteLine();
                    opt2_changes = Convert.ToInt16(Console.ReadLine());
                }

                // Link reference https://social.msdn.microsoft.com/Forums/en-US/0b9f37c4-6ef4-46ce-a411-b95558df745b/how-do-i-forcibly-enable-windows-firewall-with-advanced-security-for-domain-profile?forum=windowsdeveloperpreviewgeneral

                Console.ForegroundColor = ConsoleColor.Green;

                if (opt2_changes == 1)
                {
                    RegistryKey key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsFirewall");
                    key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsFirewall\\StandardProfile");

                    using (key)
                    {

                        key.SetValue("EnableFirewall", "00000000", RegistryValueKind.DWord);
                        key.Close();
                    }
                }
                if (opt2_changes == 2)
                {
                    RegistryKey key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsFirewall");
                    key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsFirewall\\StandardProfile");

                    using (key)
                    {

                        key.SetValue("EnableFirewall", "00000001", RegistryValueKind.DWord);
                        key.Close();
                    }
                }


            }

            if (input1 == 3) //3. Group Policy refresh interval - HKLM:\\Software\\Policies\\Microsoft\\Windows\\System -Name GroupPolicyRefreshTime
            {
                int opt3_changes;
                Console.WriteLine();
                Console.WriteLine("{0}", "Enable or disable Group Policy refresh interval? Please key in interval in minutes (0 to 64800)");

                opt3_changes = Convert.ToInt16(Console.ReadLine());

                while (!BetweenRanges(0, 64800, opt3_changes))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}", "WRONG OR INVALID INPUT. PLEASE KEY IN AGAIN.");
                    Console.WriteLine();
                    opt3_changes = Convert.ToInt16(Console.ReadLine());
                }

                // Link reference : https://searchenterprisedesktop.techtarget.com/tip/Boost-performance-change-Group-Policy-refresh-interval

                Console.ForegroundColor = ConsoleColor.Green;

                 RegistryKey key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\System");
                 
                    using (key)
                    {

                        key.SetValue("GroupPolicyRefreshTime", opt3_changes, RegistryValueKind.DWord);
                        key.Close();
                    }
                
            }

            if (input1 == 4) //4.Group Policy refresh time offset -HKLM:\\Software\\Policies\\Microsoft\\Windows\\System - Name GroupPolicyRefreshTimeOffset
            {
                int opt4_changes;
                Console.WriteLine();
                Console.WriteLine("{0}", "Enable or disable Group Policy refresh interval time offset? Please key in interval in minutes (0 to 1440)");

                opt4_changes = Convert.ToInt16(Console.ReadLine());

                while (!BetweenRanges(0, 1440, opt4_changes))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}", "WRONG OR INVALID INPUT. PLEASE KEY IN AGAIN.");
                    Console.WriteLine();
                    opt4_changes = Convert.ToInt16(Console.ReadLine());
                }

                // Link reference : https://searchenterprisedesktop.techtarget.com/tip/Boost-performance-change-Group-Policy-refresh-interval

                Console.ForegroundColor = ConsoleColor.Green;

                RegistryKey key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\System");

                using (key)
                {

                    key.SetValue("GroupPolicyRefreshTimeOffset", opt4_changes, RegistryValueKind.DWord);
                    key.Close();
                }

            }

            if (input1 == 5) //5. No Autorun option enable/disable - HKLM:\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\NoAutoRun
            {
                int opt5_changes;
                Console.WriteLine();
                Console.WriteLine("{0}", "Enable or disable Autorun? Press 1 to enable Autorun, 2 to disable Autorun (NoAutorun)");

                opt5_changes = Convert.ToInt16(Console.ReadLine());

                while (!BetweenRanges(1, 2, opt5_changes))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}", "WRONG OR INVALID INPUT. PLEASE KEY IN AGAIN.");
                    Console.WriteLine();
                    opt5_changes = Convert.ToInt16(Console.ReadLine());
                }

                // Link reference https://social.technet.microsoft.com/Forums/ie/en-US/c80082a1-c488-48f3-a133-2c7dd69517d4/hkeylocalmachinesoftwaremicrosoftwindowscurrentversionpoliciesexplorer-missing-in-registry?forum=w7itprogeneral

                Console.ForegroundColor = ConsoleColor.Green;

                if (opt5_changes == 1)
                {
                    RegistryKey key = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
                    //key = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");

                    using (key)
                    {

                        key.SetValue("NoAutorun", "00000000", RegistryValueKind.DWord);
                        key.Close();
                    }
                }
                if (opt5_changes == 2)
                {
                    RegistryKey key = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
                    //key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsFirewall\\DomainProfile");

                    using (key)
                    {

                        key.SetValue("NoAutorun", "00000001", RegistryValueKind.DWord);
                        key.Close();
                    }
                }
            }


            if(input1 == 6) //6.Disable Cortana in Windows 10 Searches(Only applicable for Windows 10 Home, Professional & Enterprise)
            {
                int opt6_changes;
                Console.WriteLine();
                Console.WriteLine("{0}", "Enable or disable Cortana in Windows Search? Press 1 to enable , 2 to disable");

                opt6_changes = Convert.ToInt16(Console.ReadLine());

                while (!BetweenRanges(1, 2, opt6_changes))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}", "WRONG OR INVALID INPUT. PLEASE KEY IN AGAIN.");
                    Console.WriteLine();
                    opt6_changes = Convert.ToInt16(Console.ReadLine());
                }


                Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine();


                if (opt6_changes == 1)
                {
                    RegistryKey key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\Windows Search");
                    //key = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");

                    using (key)
                    {

                        key.SetValue("AllowCortana", "00000001", RegistryValueKind.DWord);
                        key.SetValue("AllowCortanaAboveLock", "00000001", RegistryValueKind.DWord);
                        key.SetValue("ConnectedSearchUseWeb", "00000001", RegistryValueKind.DWord);
                        key.SetValue("ConnectedSearchUseWebOverMeteredConnections", "00000001", RegistryValueKind.DWord);
                        key.Close();
                    }
                }
                if (opt6_changes == 2)
                {
                    RegistryKey key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\Windows Search");
                    //key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsFirewall\\DomainProfile");

                    using (key)
                    {

                        key.SetValue("AllowCortana", "00000000", RegistryValueKind.DWord);
                        key.SetValue("AllowCortanaAboveLock", "00000000", RegistryValueKind.DWord);
                        key.SetValue("ConnectedSearchUseWeb", "00000001", RegistryValueKind.DWord);
                        key.SetValue("ConnectedSearchUseWebOverMeteredConnections", "00000001", RegistryValueKind.DWord);
                        key.Close();
                    }
                }

            }

            if (input1 == 7) //7. Disable Windows Store (Only applicable for Windows 10 Professional & Enterprise)
            {
                int opt7_changes;
                Console.WriteLine();
                Console.WriteLine("{0}", "Enable or disable Windows Store? Press 1 to enable , 2 to disable");

                opt7_changes = Convert.ToInt16(Console.ReadLine());

                while (!BetweenRanges(1, 2, opt7_changes))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}", "WRONG OR INVALID INPUT. PLEASE KEY IN AGAIN.");
                    Console.WriteLine();
                    opt7_changes = Convert.ToInt16(Console.ReadLine());
                }

                // Link reference https://getadmx.com/HKLM/Software/Policies/Microsoft/WindowsStore
                Console.ForegroundColor = ConsoleColor.Green;
                

                if (opt7_changes == 1)
                {
                    RegistryKey key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsStore");
                    //key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsStore");

                    using (key)
                    {

                        key.SetValue("RemoveWindowsStore", "00000000", RegistryValueKind.DWord);                        
                        key.Close();
                    }
                }
                if (opt7_changes == 2)
                {
                    RegistryKey key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\Windows Search");
                    //key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsFirewall\\DomainProfile");

                    using (key)
                    {

                        key.SetValue("RemoveWindowsStore", "00000001", RegistryValueKind.DWord);
                        key.Close();
                    }
                }

            }

            if (input1 == 8) //8. Screen saver activation, with password, and timeout setting
            {
                int opt8_changes_sson;
                Console.WriteLine();
                Console.WriteLine("{0}", "Enable or disable screen saver? Press 1 to enable , 2 to disable");

                opt8_changes_sson = Convert.ToInt16(Console.ReadLine());

                while (!BetweenRanges(1, 2, opt8_changes_sson))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}", "WRONG OR INVALID INPUT. PLEASE KEY IN AGAIN.");
                    Console.WriteLine();
                    opt8_changes_sson = Convert.ToInt16(Console.ReadLine());
                }

                int opt8_changes_pwd;
                Console.WriteLine();
                Console.WriteLine("{0}", "Enable or disable screen saver with password lock protection? Press 1 to enable , 2 to disable");

                opt8_changes_pwd = Convert.ToInt16(Console.ReadLine());

                while (!BetweenRanges(1, 2, opt8_changes_pwd))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}", "WRONG OR INVALID INPUT. PLEASE KEY IN AGAIN.");
                    Console.WriteLine();
                    opt8_changes_pwd = Convert.ToInt16(Console.ReadLine());
                }

                int opt8_changes_timeout;
                Console.WriteLine();
                Console.WriteLine("{0}", "Please key in screensaver start timeout setting in seconds:");

                opt8_changes_timeout = Convert.ToInt16(Console.ReadLine());

                while (!BetweenRanges(1, 86400, opt8_changes_timeout))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}", "WRONG OR INVALID INPUT. PLEASE KEY IN AGAIN.");
                    Console.WriteLine();
                    opt8_changes_timeout = Convert.ToInt16(Console.ReadLine());
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();


                if (opt8_changes_sson == 1)
                {
                    RegistryKey key1 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
                    //key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsStore");

                    using (key1)
                    {

                        key1.SetValue("ScreenSaveActive", "00000001", RegistryValueKind.DWord);                        
                        key1.Close();
                    }
                }
                if (opt8_changes_sson == 2)
                {
                    RegistryKey key1 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
                    //key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsFirewall\\DomainProfile");

                    using (key1)
                    {

                        key1.SetValue("ScreenSaveActive", "00000000", RegistryValueKind.DWord);
                        key1.Close();
                    }
                }

                if (opt8_changes_pwd == 1)
                {
                    RegistryKey key2 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
                    //key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsStore");

                    using (key2)
                    {

                        key2.SetValue("ScreenSaverIsSecure", "00000001", RegistryValueKind.DWord);
                        key2.Close();
                    }
                }
                if (opt8_changes_pwd == 2)
                {
                    RegistryKey key2 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
                    //key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsFirewall\\DomainProfile");

                    using (key2)
                    {

                        key2.SetValue("ScreenSaverIsSecure", "00000000", RegistryValueKind.DWord);
                        key2.Close();
                    }
                }

                // For screensaver timeout setting

                RegistryKey key3 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
                //key = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\WindowsStore");

                using (key3)
                {
                    key3.SetValue("ScreenSaveTimeOut", opt8_changes_timeout, RegistryValueKind.DWord);
                    key3.Close();
                }    
                

            }
                        
        }
    } }
