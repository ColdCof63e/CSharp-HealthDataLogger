using HealthDataLogger_CSharp.database;
using HealthDataLogger_CSharp.utils;

namespace HealthDataLogger_CSharp
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
            myAccNameBox.Text = UserSession.CurrentUser.Name;
            myAccMailBox.Text = UserSession.CurrentUser.Email;
            myAccPhoneNumber.Text = UserSession.CurrentUser.PhoneNumber;
            myAccHeightBox.Text = UserSession.CurrentUser.Height.ToString();
            myAccWeightBox.Text = UserSession.CurrentUser.Weight.ToString();
            myAccAddressBox.Text = UserSession.CurrentUser?.Address;
            myAccGenderBox.Text = UserSession.CurrentUser?.Gender;
            myAccBloodTypeBox.Text = UserSession.CurrentUser?.BloodType;
            myAccDOBPicker.Value = UserSession.CurrentUser.Dob;
        }

        private void myAccSaveButton_Click(object sender, EventArgs e)
        {
            if (DatabaseCommunication.UpdateUserDataInDatabase(myAccMailBox.Text, myAccNameBox.Text,
                myAccPhoneNumber.Text, Int32.Parse(myAccHeightBox.Text), Int32.Parse(myAccWeightBox.Text), myAccAddressBox.Text,
                myAccGenderBox.Text, myAccBloodTypeBox.Text, myAccDOBPicker.Value))
            {
                MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Data Failed to Update!\nTry Again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser.IsTech.Equals("true", StringComparison.OrdinalIgnoreCase))
            {
                technicianHomeForm techHome = new technicianHomeForm();
                techHome.Show();
                this.Hide();
            }
            else
            {
                UserHome userHome = new UserHome();
                userHome.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password forgot_Password = new Forgot_Password();
            forgot_Password.Show();
            this.Hide();
        }
    }
}