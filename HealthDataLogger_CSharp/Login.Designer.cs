namespace HealthDataLogger_CSharp
{
    partial class Login
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
            emailBox = new TextBox();
            passwordBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            forgotPassword = new Label();
            promptLabel = new Label();
            loginBtn = new Button();
            linkLabel1 = new LinkLabel();
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
            tableLayoutPanel1.Controls.Add(emailBox, 2, 1);
            tableLayoutPanel1.Controls.Add(passwordBox, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 2);
            tableLayoutPanel1.Controls.Add(forgotPassword, 1, 3);
            tableLayoutPanel1.Controls.Add(promptLabel, 1, 4);
            tableLayoutPanel1.Controls.Add(loginBtn, 1, 5);
            tableLayoutPanel1.Controls.Add(linkLabel1, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(464, 321);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // emailBox
            // 
            emailBox.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(emailBox, 2);
            emailBox.Location = new Point(187, 48);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(178, 23);
            emailBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(passwordBox, 2);
            passwordBox.Location = new Point(187, 88);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(178, 23);
            passwordBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(118, 52);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(121, 92);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 7;
            label5.Text = "Password:";
            // 
            // forgotPassword
            // 
            forgotPassword.Anchor = AnchorStyles.None;
            forgotPassword.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(forgotPassword, 3);
            forgotPassword.Location = new Point(180, 132);
            forgotPassword.Name = "forgotPassword";
            forgotPassword.Size = new Size(100, 15);
            forgotPassword.TabIndex = 3;
            forgotPassword.Text = "Forgot Password?";
            forgotPassword.Click += forgotPassword_Click;
            // 
            // promptLabel
            // 
            promptLabel.Anchor = AnchorStyles.None;
            promptLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(promptLabel, 3);
            promptLabel.Location = new Point(191, 172);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(78, 15);
            promptLabel.TabIndex = 2;
            promptLabel.Text = "prompt Label";
            promptLabel.Visible = false;
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(loginBtn, 3);
            loginBtn.Location = new Point(192, 208);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(linkLabel1, 3);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(185, 252);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 321);
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            Text = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox emailBox;
        private TextBox passwordBox;
        private Label promptLabel;
        private Label forgotPassword;
        private Button loginBtn;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel1;
    }
}