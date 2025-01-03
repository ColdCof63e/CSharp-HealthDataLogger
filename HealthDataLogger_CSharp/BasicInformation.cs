using HealthDataLogger_CSharp.database;
using HealthDataLogger_CSharp.utils;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthDataLogger_CSharp
{
    public partial class BasicInformation : Form
    {
        private BasicInformationData biBasicInfoData = Program.GetBasicInformationData();

        public BasicInformation()
        {
            InitializeComponent();
        }

        private void BasicInformation_Load(object sender, EventArgs e)
        {
            // Assuming basicInfoDOBPicker is a DateTimePicker
            biDOBDatePickerBox.ValueChanged += new EventHandler(BasicInfoDOBPicker_ValueChanged);
            biNameBox.Text = biBasicInfoData.Name;
            biEmailBox.Text = biBasicInfoData.Email;
            biDOBDatePickerBox.MaxDate = DateTime.Today;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void BasicInfoDOBPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = biDOBDatePickerBox.Value;
            int age = CalculateAge(dob);
            biAgeLabel.Text = age + " years";
            biAgeLabel.Visible = true;
        }

        private int CalculateAge(DateTime dob)
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - dob.Year;
            if (dob.Date > currentDate.AddYears(-age)) age--;
            return age;
        }

        private void biCreateAccountBtn_Click(object sender, EventArgs e)
        {
            biPromptLabel.Visible = false;
            try
            {
                if (ValidateData.EmptyFieldChecks(biPhoneNumberBox))
                {
                    biPromptLabel.Text = "Enter Phone Number!";
                    biPromptLabel.Visible = true;
                    return;
                }

                if (!ValidateData.IsValidPhoneNumber(biPhoneNumberBox.Text))
                {
                    biPromptLabel.Text = "Enter Phone Number!";
                    biPromptLabel.Visible = true;
                    return;
                }

                if (ValidateData.EmptyFieldChecks(biHeightBox))
                {
                    biPromptLabel.Text = "Enter Your Height!";
                    biPromptLabel.Visible = true;
                    return;
                }

                if (ValidateData.EmptyFieldChecks(biWeightBox))
                {
                    biPromptLabel.Text = "Enter Your Weight!";
                    biPromptLabel.Visible = true;
                    return;
                }

                if (ValidateData.IsComboBoxEmpty(biGenderBox))
                {
                    biPromptLabel.Text = "Select Your Gender!";
                    biPromptLabel.Visible = true;
                    return;
                }

                if (ValidateData.IsComboBoxEmpty(biBloodTypeBox))
                {
                    biPromptLabel.Text = "Select Your Blood Type!";
                    biPromptLabel.Visible = true;
                    return;
                }

                if (ValidateData.IsValidAddress(biAddressBox.Text))
                {
                    biPromptLabel.Text = "Invalid Address Format\nEnter without ','!";
                    biPromptLabel.Visible = true;
                    return;
                }

                // Validate Date of Birth (DOB)
                if (biDOBDatePickerBox.Value == DateTime.MinValue)
                {
                    biPromptLabel.Text = "Please select a valid date of birth!";
                    biPromptLabel.Visible = true;
                    return;
                }

                DatabaseCommunication.InsertData(biBasicInfoData.Email, biBasicInfoData.Password,
                    biBasicInfoData.Name, biBasicInfoData.IsTech, biPhoneNumberBox.Text, biHeightBox.Text,
                    biWeightBox.Text, biAddressBox.Text, biGenderBox.Text, biBloodTypeBox.Text, biDOBDatePickerBox.Value);

                MessageBox.Show("Account Created Successfully");
                this.Close();
                Login login = new Login();
                login.StartPosition = FormStartPosition.CenterParent;
                login.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
