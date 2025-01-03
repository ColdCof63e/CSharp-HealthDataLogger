using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataLogger_CSharp.utils
{
    public class Credentials
    {
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string IsTech { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public DateTime Dob { get; set; }
        public string BloodType { get; set; }
        public string Gender { get; set; }

        // Default constructor for easy object creation
        public Credentials(string emailID, string password, string name, string isTech,
                           string phoneNumber, int height, int weight, string address,
                           string gender, string bloodType, DateTime dob)
        {
            EmailID = emailID;
            Password = password;
            Name = name;
            IsTech = isTech;
            PhoneNumber = phoneNumber;
            Height = height;
            Weight = weight;
            Address = address;
            Gender = gender;
            BloodType = bloodType;
            Dob = dob;
        }

        // Overloaded constructor for a simpler object creation (email, password, name, isTech)
        public Credentials(string emailID, string password, string name, string isTech)
        {
            EmailID = emailID;
            Password = password;
            Name = name;
            IsTech = isTech;
        }
    }
}
