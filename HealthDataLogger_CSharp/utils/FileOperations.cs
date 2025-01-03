using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HealthDataLogger_CSharp.utils;

namespace HealthDataLogger_CSharp.utils
{
    internal class FileOperations
    {
        public static void WriteToAFile(string email, string password, string name, string isTech)
        {
            FileStream fs = new FileStream("Credentials.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(email + "|" + password + "|" + name + "|" + isTech);
            Console.WriteLine("File created successfully");
            sw.Close();
            fs.Close();
        }

        public static List<Credentials> ReadFromAFile()
        {
            List<Credentials> credentials = new List<Credentials>();
            if (File.Exists("Credentials.txt"))
            {
                using (StreamReader reader = new StreamReader("Credentials.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var lines = line.Split('|');
                        if (lines.Length == 4)
                        {
                            credentials.Add(new Credentials(lines[0], lines[1], lines[2], lines[3]));
                        }
                    }
                }
            }
            return credentials;
        }

        public static bool PasswordReset(string email, string newPassword)
        {
            List<Credentials> credentials = ReadFromAFile();
            bool isUpdated = false;

            foreach (Credentials cred in credentials)
            {
                if (cred.EmailID.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    cred.Password = newPassword;
                    isUpdated = true;
                    // Breaking out once the appropriate email ID's password is assigned
                    break;
                }
            }

            if (isUpdated)
            {
                // false in StreamWriter is to overwrite the data
                using (StreamWriter sw = new StreamWriter("Credentials.txt", false))
                {
                    foreach (Credentials cred in credentials)
                    {
                        sw.WriteLine(cred.EmailID + "|" + cred.Password + "|" + cred.Name + "|" + cred.IsTech);
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void FileLogs(string text)
        {
            FileStream fs = new FileStream("Log.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(text + " Clicked");
            Console.WriteLine("File created successfully");
            sw.Close();
            fs.Close();
        }
    }
}
