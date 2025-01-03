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
    public partial class Login : Form
    {
        private static BasicInformationData bid = new BasicInformationData();
        Form fTemp = null;
        public List<Credentials> cred;
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            fTemp = this;
            
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileOperations.FileLogs(forgotPassword.Text);
            Forgot_Password frgtPass = new Forgot_Password();
            frgtPass.StartPosition = FormStartPosition.CenterScreen;
            frgtPass.MaximizeBox = false;
            frgtPass.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DBValidation.ValidCredentials(emailBox.Text, passwordBox.Text))
                {   
                    UserSession.LoadUserData(emailBox.Text);
                    if (UserSession.CurrentUser != null)
                    {
                        if (DBValidation.IsAdmin(emailBox.Text))
                        {
                            this.Hide();
                            technicianHomeForm techHome = new technicianHomeForm();
                            techHome.StartPosition = FormStartPosition.CenterScreen;
                            techHome.WindowState = FormWindowState.Maximized;
                            techHome.Show();
                        }
                        else
                        {
                            this.Hide();
                            UserHome usrHome = new UserHome();
                            usrHome.StartPosition = FormStartPosition.CenterScreen;
                            usrHome.WindowState = FormWindowState.Maximized;
                            usrHome.Show();
                        }
                    }
                    else
                    {
                        promptLabel.Text = "User not found!";
                        promptLabel.Visible = true;
                    }
                }
                else
                {
                    promptLabel.Text = "Invalid Email or Password!";
                    promptLabel.Visible = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FileOperations.FileLogs(linkLabel1.Text);
            this.Hide();
            signUp accCreate = new signUp();
            accCreate.StartPosition = FormStartPosition.CenterScreen;
            accCreate.MaximizeBox = false;
            accCreate.Show();
        }
    }
}