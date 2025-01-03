using HealthDataLogger_CSharp.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataLogger_CSharp.database
{
    internal class DBValidation
    {
        public static Boolean EmailExists(string email)
        {
            //List<Credentials> cred = DatabaseCommunication.ReadDataShort();
            List<Credentials> cred = DatabaseCommunication.ReadData();
            foreach (Credentials credentials in cred)
            {
                if (credentials.EmailID.Equals(email, StringComparison.OrdinalIgnoreCase))
                { return true; }
            }
            return false;
        }

        public static Boolean ValidCredentials(string email, string password)
        {
            List<Credentials> cred = DatabaseCommunication.ReadData();
            foreach (Credentials credentials in cred)
            {
                if (credentials.EmailID.Equals(email, StringComparison.OrdinalIgnoreCase) && 
                    (credentials.Password.Equals(password, StringComparison.OrdinalIgnoreCase)))
                { return true; }
            }
            return false;
        }

        public static Boolean IsAdmin(string email)
        {
            List<Credentials> cred = DatabaseCommunication.ReadData();
            foreach (Credentials credentials in cred)
            {
                if ((credentials.EmailID.Equals(email, StringComparison.OrdinalIgnoreCase)) &&
                    (credentials.IsTech.Equals("true", StringComparison.OrdinalIgnoreCase)))
                { return true; }
            }
            return false;
        }
    }
}
