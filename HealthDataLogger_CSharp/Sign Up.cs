using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthDataLogger_CSharp.database;
using HealthDataLogger_CSharp.utils;

namespace HealthDataLogger_CSharp
{
    public partial class signUp : Form
    {
        private BasicInformationData bid;
        public signUp()
        {
            InitializeComponent();
            promptLabel.Visible = false;
            bid = Program.GetBasicInformationData();
        }

        private void signUpBtn1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Clicked");
            string email = eMailBox.Text;
            string password1 = enterPassword.Text;
            string password2 = confirmPassword.Text;
            string name = nameBox.Text;
            string tech = techCheckBox.Checked.ToString();

            if (!ValidateData.EmailRegex(email))
            {
                promptLabel.Text = "Invalid Email!";
                promptLabel.Visible = true;
                return;
            }

            if (DBValidation.EmailExists(email))
            {
                promptLabel.Text = "Email exists!";
                promptLabel.Visible = true;
                return;
            }

            if (!ValidateData.PassMatch(password1, password2))
            {
                promptLabel.Text = "Password Fails to Match!";
                promptLabel.Visible = true;
                return;
            }
            bid.SetAccountDataShort(email, password1, name, tech);

            this.Hide();
            BasicInformation bi = new BasicInformation();
            bi.Visible = true;
            bi.StartPosition = FormStartPosition.CenterScreen;
            bi.Show();
        }
    }
}
