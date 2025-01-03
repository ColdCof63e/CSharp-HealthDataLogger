using HealthDataLogger_CSharp.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataLogger_CSharp.utils
{
    public static class UserSession
    {
        // A static property to hold the current user's data
        public static BasicInformationData CurrentUser { get; set; }

        // Method to load the user's data based on email
        public static void LoadUserData(string email)
        {
            List<Credentials> creds = DatabaseCommunication.ReadData();
            foreach (Credentials cred in creds)
            {
                if (email.Equals(cred.EmailID, StringComparison.OrdinalIgnoreCase))
                {
                    // Populate CurrentUser with data
                    CurrentUser = new BasicInformationData
                    {
                        Email = cred.EmailID,
                        Password = cred.Password,
                        Name = cred.Name,
                        IsTech = cred.IsTech,
                        PhoneNumber = cred.PhoneNumber,
                        Address = cred.Address,
                        Height = cred.Height,
                        Weight = cred.Weight,
                        BloodType = cred.BloodType,
                        Gender = cred.Gender,
                        Dob = cred.Dob
                    };
                    return;
                }
            }
            // If no user is found, reset CurrentUser to null
            CurrentUser = null;
        }
    }
}
