namespace HealthDataLogger_CSharp
{
    partial class signUp
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
            techCheckBox = new CheckBox();
            promptLabel = new Label();
            signUpBtn1 = new Button();
            eMailBox = new TextBox();
            nameBox = new TextBox();
            enterPassword = new TextBox();
            confirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            tableLayoutPanel1.Controls.Add(techCheckBox, 1, 5);
            tableLayoutPanel1.Controls.Add(promptLabel, 1, 6);
            tableLayoutPanel1.Controls.Add(signUpBtn1, 1, 7);
            tableLayoutPanel1.Controls.Add(eMailBox, 2, 1);
            tableLayoutPanel1.Controls.Add(nameBox, 2, 2);
            tableLayoutPanel1.Controls.Add(enterPassword, 2, 3);
            tableLayoutPanel1.Controls.Add(confirmPassword, 2, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
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
            // techCheckBox
            // 
            techCheckBox.Anchor = AnchorStyles.None;
            techCheckBox.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(techCheckBox, 3);
            techCheckBox.Location = new Point(164, 183);
            techCheckBox.Name = "techCheckBox";
            techCheckBox.Size = new Size(131, 19);
            techCheckBox.TabIndex = 4;
            techCheckBox.Text = "Are You Technician?";
            techCheckBox.UseVisualStyleBackColor = true;
            // 
            // promptLabel
            // 
            promptLabel.Anchor = AnchorStyles.None;
            promptLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(promptLabel, 3);
            promptLabel.Location = new Point(211, 220);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(38, 15);
            promptLabel.TabIndex = 5;
            promptLabel.Text = "label5";
            // 
            // signUpBtn1
            // 
            signUpBtn1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(signUpBtn1, 3);
            signUpBtn1.Location = new Point(192, 251);
            signUpBtn1.Name = "signUpBtn1";
            signUpBtn1.Size = new Size(75, 23);
            signUpBtn1.TabIndex = 6;
            signUpBtn1.Text = "Next";
            signUpBtn1.UseVisualStyleBackColor = true;
            signUpBtn1.Click += signUpBtn1_Click;
            // 
            // eMailBox
            // 
            eMailBox.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(eMailBox, 2);
            eMailBox.Location = new Point(187, 41);
            eMailBox.Name = "eMailBox";
            eMailBox.Size = new Size(178, 23);
            eMailBox.TabIndex = 7;
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(nameBox, 2);
            nameBox.Location = new Point(187, 76);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(178, 23);
            nameBox.TabIndex = 8;
            // 
            // enterPassword
            // 
            enterPassword.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(enterPassword, 2);
            enterPassword.Location = new Point(187, 111);
            enterPassword.Name = "enterPassword";
            enterPassword.Size = new Size(178, 23);
            enterPassword.TabIndex = 9;
            // 
            // confirmPassword
            // 
            confirmPassword.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(confirmPassword, 2);
            confirmPassword.Location = new Point(187, 146);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.Size = new Size(178, 23);
            confirmPassword.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Location = new Point(142, 45);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 2);
            label2.Location = new Point(117, 80);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Full Name:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label3, 2);
            label3.Location = new Point(91, 115);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter Password:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label4, 2);
            label4.Location = new Point(73, 150);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 3;
            label4.Text = "Re-enter Password:";
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 321);
            Controls.Add(tableLayoutPanel1);
            Name = "signUp";
            Text = "Sign_Up";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox techCheckBox;
        private Label promptLabel;
        private Button signUpBtn1;
        private TextBox eMailBox;
        private TextBox nameBox;
        private TextBox enterPassword;
        private TextBox confirmPassword;
    }
}