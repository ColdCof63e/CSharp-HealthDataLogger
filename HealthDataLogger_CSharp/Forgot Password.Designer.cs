namespace HealthDataLogger_CSharp
{
    partial class Forgot_Password
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            confirmPassword = new Label();
            enterPassword = new Label();
            codeVerification = new Label();
            requestEmail = new Label();
            promptLabel = new Label();
            uniButton = new Button();
            enterMail = new TextBox();
            enterVerificationCode = new TextBox();
            enterPasswordBox = new TextBox();
            confirmPasswordBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(confirmPassword, 0, 4);
            tableLayoutPanel1.Controls.Add(enterPassword, 0, 3);
            tableLayoutPanel1.Controls.Add(codeVerification, 0, 2);
            tableLayoutPanel1.Controls.Add(requestEmail, 0, 1);
            tableLayoutPanel1.Controls.Add(promptLabel, 1, 5);
            tableLayoutPanel1.Controls.Add(uniButton, 1, 6);
            tableLayoutPanel1.Controls.Add(enterMail, 2, 1);
            tableLayoutPanel1.Controls.Add(enterVerificationCode, 2, 2);
            tableLayoutPanel1.Controls.Add(enterPasswordBox, 2, 3);
            tableLayoutPanel1.Controls.Add(confirmPasswordBox, 2, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.Size = new Size(464, 321);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // confirmPassword
            // 
            confirmPassword.Anchor = AnchorStyles.Right;
            confirmPassword.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(confirmPassword, 2);
            confirmPassword.Location = new Point(74, 172);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.Size = new Size(107, 15);
            confirmPassword.TabIndex = 3;
            confirmPassword.Text = "Confirm Password:";
            // 
            // enterPassword
            // 
            enterPassword.Anchor = AnchorStyles.Right;
            enterPassword.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(enterPassword, 2);
            enterPassword.Location = new Point(91, 132);
            enterPassword.Name = "enterPassword";
            enterPassword.Size = new Size(90, 15);
            enterPassword.TabIndex = 2;
            enterPassword.Text = "Enter Password:";
            // 
            // codeVerification
            // 
            codeVerification.Anchor = AnchorStyles.Right;
            codeVerification.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(codeVerification, 2);
            codeVerification.Location = new Point(111, 92);
            codeVerification.Name = "codeVerification";
            codeVerification.Size = new Size(70, 15);
            codeVerification.TabIndex = 1;
            codeVerification.Text = "Verify Code:";
            // 
            // requestEmail
            // 
            requestEmail.Anchor = AnchorStyles.Right;
            requestEmail.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(requestEmail, 2);
            requestEmail.Location = new Point(85, 52);
            requestEmail.Name = "requestEmail";
            requestEmail.Size = new Size(96, 15);
            requestEmail.TabIndex = 0;
            requestEmail.Text = "Enter Your Email:";
            // 
            // promptLabel
            // 
            promptLabel.Anchor = AnchorStyles.None;
            promptLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(promptLabel, 3);
            promptLabel.Location = new Point(211, 212);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(38, 15);
            promptLabel.TabIndex = 4;
            promptLabel.Text = "label5";
            // 
            // uniButton
            // 
            uniButton.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(uniButton, 3);
            uniButton.Location = new Point(192, 248);
            uniButton.Name = "uniButton";
            uniButton.Size = new Size(75, 23);
            uniButton.TabIndex = 5;
            uniButton.Text = "Send Code";
            uniButton.UseVisualStyleBackColor = true;
            uniButton.Click += uniButton_Click_1;
            // 
            // enterMail
            // 
            enterMail.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(enterMail, 2);
            enterMail.Location = new Point(187, 48);
            enterMail.Name = "enterMail";
            enterMail.Size = new Size(178, 23);
            enterMail.TabIndex = 6;
            // 
            // enterVerificationCode
            // 
            enterVerificationCode.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(enterVerificationCode, 2);
            enterVerificationCode.Location = new Point(187, 88);
            enterVerificationCode.Name = "enterVerificationCode";
            enterVerificationCode.Size = new Size(178, 23);
            enterVerificationCode.TabIndex = 7;
            // 
            // enterPasswordBox
            // 
            enterPasswordBox.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(enterPasswordBox, 2);
            enterPasswordBox.Location = new Point(187, 128);
            enterPasswordBox.Name = "enterPasswordBox";
            enterPasswordBox.PasswordChar = '*';
            enterPasswordBox.Size = new Size(178, 23);
            enterPasswordBox.TabIndex = 8;
            enterPasswordBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordBox
            // 
            confirmPasswordBox.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(confirmPasswordBox, 2);
            confirmPasswordBox.Location = new Point(187, 168);
            confirmPasswordBox.Name = "confirmPasswordBox";
            confirmPasswordBox.PasswordChar = '*';
            confirmPasswordBox.Size = new Size(178, 23);
            confirmPasswordBox.TabIndex = 9;
            confirmPasswordBox.UseSystemPasswordChar = true;
            // 
            // Forgot_Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 321);
            Controls.Add(tableLayoutPanel1);
            Name = "Forgot_Password";
            Text = "Change Password";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label confirmPassword;
        private Label enterPassword;
        private Label codeVerification;
        private Label requestEmail;
        private Label promptLabel;
        private Button uniButton;
        private TextBox enterMail;
        private TextBox enterVerificationCode;
        private TextBox enterPasswordBox;
        private TextBox confirmPasswordBox;
    }
}