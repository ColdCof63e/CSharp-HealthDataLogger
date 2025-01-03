using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HealthDataLogger_CSharp.utils;

namespace HealthDataLogger_CSharp.utils
{
    internal class ValidateData
    {
        private static List<Credentials> credentials = FileOperations.ReadFromAFile();
        public static bool IsValidCredentials(string username, string enteredPassword)
        {
            foreach (var credential in credentials)
            {
                if (credential.EmailID.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                    credential.Password.Equals(enteredPassword, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool EmailRegex(string username)
        {

            string emailPattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(username);
        }

        public static bool PassMatch(string password1, string password2)
        {
            // Check if fields are null or not
            if (password1 == null || password2 == null)
            {
                return false;
            }

            // Check if lengths are different
            if (password1.Length != password2.Length)
            {
                return false;
            }

            return password1.Equals(password2);
        }

        public static bool EmailAvailability(string email)
        {
            foreach (var credential in credentials)
            {
                if (credential.EmailID.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool EmptyFieldChecks(TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text);
        }

        public static bool IsAdmin(string email)
        {
            foreach (var cred in credentials)
            {
                Console.Out.WriteLine(cred.EmailID);
                Console.WriteLine(cred.Password);
                Console.WriteLine(cred.Name);
                Console.WriteLine(cred.IsTech);
                if (cred.EmailID.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    // Assuming the role is stored as "true" for admin/tech, "false" for others
                    Console.Out.WriteLine(cred.IsTech);
                    return bool.Parse(cred.IsTech); // Return true if the user is an admin/tech                    
                }
            }
            return false; // User not found or not admin/tech
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regex for North American format (adjust if needed)
            string pattern = @"^\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$";

            // Match the pattern
            return Regex.IsMatch(phoneNumber, pattern);
        }

        public static bool IsComboBoxEmpty(ComboBox comboBox)
        {
            // Check if no item is selected or if the text is empty
            return comboBox.SelectedIndex == -1 || string.IsNullOrEmpty(comboBox.Text);
        }

        public static bool IsValidAddress(string address)
        {
            // Check if the address is not null, not empty, and does not contain a comma
            return !string.IsNullOrEmpty(address) && !address.Contains(",");
        }
    }
}