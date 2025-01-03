using System;

namespace HealthDataLogger_CSharp.utils
{
    // The email property was defined outside of the class, it's now moved inside.
    public class BasicInformationData
    {
        // Fields for storing basic information.
        private string email;
        private string password;
        private string name;
        private string isTech;
        private string phoneNumber;
        private string address;
        private string gender;
        private string bloodType;
        private int weight;
        private int height;
        private DateTime dob;

        // Properties for accessing and modifying the data.
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string IsTech
        {
            get { return isTech; }
            set { isTech = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string BloodType
        {
            get { return bloodType; }
            set { bloodType = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        // Constructor for setting account data (email, password, name, isTech).
        public void SetAccountDataShort(string email, string password, string name, string isTech)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.isTech = isTech;
        }

        // Method for setting all basic data (phone number, height, weight, address, etc.).
        public void SetAllBasicData(string email, string password, string name, string isTech, string phoneNumber,
            int height, int weight, string address, string gender, string bloodType, DateTime dob)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.isTech = isTech;
            this.phoneNumber = phoneNumber;
            this.height = height;
            this.weight = weight;
            this.address = address;
            this.gender = gender;
            this.bloodType = bloodType;
            this.dob = dob;
        }
    }
}
