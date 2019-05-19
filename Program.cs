using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupPolicyEditor1
{
    class Program
    {
        static void Main(string[] args)
        {

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
}
    }
}
