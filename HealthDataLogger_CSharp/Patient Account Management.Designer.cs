namespace HealthDataLogger_CSharp
{
    partial class patientAccountManagementForm
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
            TreeNode treeNode1 = new TreeNode("Patient Health Data Management");
            TreeNode treeNode2 = new TreeNode("Patient Account Management");
            TreeNode treeNode3 = new TreeNode("My Account");
            userAccManMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            userAccManTreeView = new TreeView();
            userAccManGroupBox = new GroupBox();
            pAMResetButton = new Button();
            pAMSearchButton = new Button();
            pAMRegionComboBox = new ComboBox();
            pAMDateTimePicker = new DateTimePicker();
            pAMUNIDTextBox = new TextBox();
            pAMRegionLabel = new Label();
            pAMDateLabel = new Label();
            patientAccManUNIDLabel = new Label();
            patAccManRoleLabel = new Label();
            patAccManResultingDeleteButton = new Button();
            pAccMandataGridView = new DataGridView();
            Record_ID = new DataGridViewTextBoxColumn();
            Patient_ID = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            pAccManBackButton = new Button();
            userAccManMenuStrip.SuspendLayout();
            userAccManGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pAccMandataGridView).BeginInit();
            SuspendLayout();
            // 
            // userAccManMenuStrip
            // 
            userAccManMenuStrip.ImageScalingSize = new Size(24, 24);
            userAccManMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem, aboutUsToolStripMenuItem });
            userAccManMenuStrip.Location = new Point(0, 0);
            userAccManMenuStrip.Name = "userAccManMenuStrip";
            userAccManMenuStrip.Size = new Size(1100, 33);
            userAccManMenuStrip.TabIndex = 0;
            userAccManMenuStrip.Text = "menuStrip1";
            userAccManMenuStrip.ItemClicked += userAccManMenuStrip_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(103, 29);
            aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // userAccManTreeView
            // 
            userAccManTreeView.ItemHeight = 50;
            userAccManTreeView.Location = new Point(0, 36);
            userAccManTreeView.Name = "userAccManTreeView";
            treeNode1.Name = "patientHDManNode";
            treeNode1.Text = "Patient Health Data Management";
            treeNode2.Name = "patientAccManNode";
            treeNode2.Text = "Patient Account Management";
            treeNode3.Name = "technicianMyAccNode";
            treeNode3.Text = "My Account";
            userAccManTreeView.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            userAccManTreeView.Size = new Size(308, 533);
            userAccManTreeView.TabIndex = 1;
            userAccManTreeView.AfterSelect += userAccManTreeView_AfterSelect;
            // 
            // userAccManGroupBox
            // 
            userAccManGroupBox.Controls.Add(pAMResetButton);
            userAccManGroupBox.Controls.Add(pAMSearchButton);
            userAccManGroupBox.Controls.Add(pAMRegionComboBox);
            userAccManGroupBox.Controls.Add(pAMDateTimePicker);
            userAccManGroupBox.Controls.Add(pAMUNIDTextBox);
            userAccManGroupBox.Controls.Add(pAMRegionLabel);
            userAccManGroupBox.Controls.Add(pAMDateLabel);
            userAccManGroupBox.Controls.Add(patientAccManUNIDLabel);
            userAccManGroupBox.Location = new Point(314, 36);
            userAccManGroupBox.Name = "userAccManGroupBox";
            userAccManGroupBox.Size = new Size(774, 209);
            userAccManGroupBox.TabIndex = 2;
            userAccManGroupBox.TabStop = false;
            userAccManGroupBox.Text = "Filter";
            userAccManGroupBox.Enter += userAccManGroupBox_Enter;
            // 
            // pAMResetButton
            // 
            pAMResetButton.Location = new Point(656, 146);
            pAMResetButton.Name = "pAMResetButton";
            pAMResetButton.Size = new Size(112, 34);
            pAMResetButton.TabIndex = 7;
            pAMResetButton.Text = "Reset";
            pAMResetButton.UseVisualStyleBackColor = true;
            pAMResetButton.Click += pAMResetButton_Click;
            // 
            // pAMSearchButton
            // 
            pAMSearchButton.Location = new Point(516, 146);
            pAMSearchButton.Name = "pAMSearchButton";
            pAMSearchButton.Size = new Size(112, 34);
            pAMSearchButton.TabIndex = 6;
            pAMSearchButton.Text = "Search";
            pAMSearchButton.UseVisualStyleBackColor = true;
            pAMSearchButton.Click += pAMSearchButton_Click;
            // 
            // pAMRegionComboBox
            // 
            pAMRegionComboBox.FormattingEnabled = true;
            pAMRegionComboBox.Items.AddRange(new object[] { "Ontario", "Quebec", "Nova Scotia", "New Brunswick", "Manitoba", "British Columbia", "Prince Edward Island", "Saskatchewan", "Alberta", "Newfoundland and Labrador" });
            pAMRegionComboBox.Location = new Point(191, 143);
            pAMRegionComboBox.Name = "pAMRegionComboBox";
            pAMRegionComboBox.Size = new Size(182, 33);
            pAMRegionComboBox.TabIndex = 5;
            pAMRegionComboBox.SelectedIndexChanged += pAMRegionComboBox_SelectedIndexChanged;
            // 
            // pAMDateTimePicker
            // 
            pAMDateTimePicker.Location = new Point(191, 92);
            pAMDateTimePicker.Name = "pAMDateTimePicker";
            pAMDateTimePicker.Size = new Size(300, 31);
            pAMDateTimePicker.TabIndex = 4;
            pAMDateTimePicker.ValueChanged += pAMDateTimePicker_ValueChanged;
            // 
            // pAMUNIDTextBox
            // 
            pAMUNIDTextBox.Location = new Point(191, 39);
            pAMUNIDTextBox.Name = "pAMUNIDTextBox";
            pAMUNIDTextBox.Size = new Size(150, 31);
            pAMUNIDTextBox.TabIndex = 3;
            pAMUNIDTextBox.TextChanged += pAMUNIDTextBox_TextChanged;
            // 
            // pAMRegionLabel
            // 
            pAMRegionLabel.AutoSize = true;
            pAMRegionLabel.Location = new Point(6, 146);
            pAMRegionLabel.Name = "pAMRegionLabel";
            pAMRegionLabel.Size = new Size(67, 25);
            pAMRegionLabel.TabIndex = 2;
            pAMRegionLabel.Text = "Region";
            pAMRegionLabel.Click += pAMRegionLabel_Click;
            // 
            // pAMDateLabel
            // 
            pAMDateLabel.AutoSize = true;
            pAMDateLabel.Location = new Point(6, 97);
            pAMDateLabel.Name = "pAMDateLabel";
            pAMDateLabel.Size = new Size(49, 25);
            pAMDateLabel.TabIndex = 1;
            pAMDateLabel.Text = "Date";
            pAMDateLabel.Click += pAMDateLabel_Click;
            // 
            // patientAccManUNIDLabel
            // 
            patientAccManUNIDLabel.AutoSize = true;
            patientAccManUNIDLabel.Location = new Point(6, 42);
            patientAccManUNIDLabel.Name = "patientAccManUNIDLabel";
            patientAccManUNIDLabel.Size = new Size(144, 25);
            patientAccManUNIDLabel.TabIndex = 0;
            patientAccManUNIDLabel.Text = "User Name or ID";
            patientAccManUNIDLabel.Click += patientAccManUNIDLabel_Click;
            // 
            // patAccManRoleLabel
            // 
            patAccManRoleLabel.AutoSize = true;
            patAccManRoleLabel.BackColor = SystemColors.Highlight;
            patAccManRoleLabel.Location = new Point(523, 265);
            patAccManRoleLabel.Name = "patAccManRoleLabel";
            patAccManRoleLabel.Size = new Size(0, 25);
            patAccManRoleLabel.TabIndex = 7;
            patAccManRoleLabel.Click += patAccManRoleLabel_Click;
            // 
            // patAccManResultingDeleteButton
            // 
            patAccManResultingDeleteButton.Location = new Point(993, 535);
            patAccManResultingDeleteButton.Name = "patAccManResultingDeleteButton";
            patAccManResultingDeleteButton.Size = new Size(89, 34);
            patAccManResultingDeleteButton.TabIndex = 11;
            patAccManResultingDeleteButton.Text = "Delete";
            patAccManResultingDeleteButton.UseVisualStyleBackColor = true;
            patAccManResultingDeleteButton.Click += patAccManResultingDeleteButton_Click;
            // 
            // pAccMandataGridView
            // 
            pAccMandataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pAccMandataGridView.Columns.AddRange(new DataGridViewColumn[] { Record_ID, Patient_ID, UserName, Phone, Address });
            pAccMandataGridView.Location = new Point(314, 265);
            pAccMandataGridView.Name = "pAccMandataGridView";
            pAccMandataGridView.RowHeadersWidth = 62;
            pAccMandataGridView.Size = new Size(774, 245);
            pAccMandataGridView.TabIndex = 12;
            pAccMandataGridView.CellContentClick += pAccMandataGridView_CellContentClick;
            // 
            // Record_ID
            // 
            Record_ID.HeaderText = "Record ID";
            Record_ID.MinimumWidth = 8;
            Record_ID.Name = "Record_ID";
            Record_ID.Width = 150;
            // 
            // Patient_ID
            // 
            Patient_ID.HeaderText = "Paitent ID";
            Patient_ID.MinimumWidth = 8;
            Patient_ID.Name = "Patient_ID";
            Patient_ID.Width = 150;
            // 
            // UserName
            // 
            UserName.HeaderText = "UserName";
            UserName.MinimumWidth = 8;
            UserName.Name = "UserName";
            UserName.Width = 150;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            Phone.Width = 150;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.Width = 150;
            // 
            // pAccManBackButton
            // 
            pAccManBackButton.Location = new Point(314, 535);
            pAccManBackButton.Name = "pAccManBackButton";
            pAccManBackButton.Size = new Size(112, 34);
            pAccManBackButton.TabIndex = 8;
            pAccManBackButton.Text = "Back";
            pAccManBackButton.UseVisualStyleBackColor = true;
            pAccManBackButton.Click += pAccManBackButton_Click;
            // 
            // patientAccountManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 581);
            Controls.Add(pAccManBackButton);
            Controls.Add(pAccMandataGridView);
            Controls.Add(patAccManResultingDeleteButton);
            Controls.Add(patAccManRoleLabel);
            Controls.Add(userAccManGroupBox);
            Controls.Add(userAccManTreeView);
            Controls.Add(userAccManMenuStrip);
            MainMenuStrip = userAccManMenuStrip;
            Name = "patientAccountManagementForm";
            Text = "Patient Account Management";
            Load += patientAccountManagementForm_Load;
            userAccManMenuStrip.ResumeLayout(false);
            userAccManMenuStrip.PerformLayout();
            userAccManGroupBox.ResumeLayout(false);
            userAccManGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pAccMandataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip userAccManMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private TreeView userAccManTreeView;
        private GroupBox userAccManGroupBox;
        private Label pAMRegionLabel;
        private Label pAMDateLabel;
        private Label patientAccManUNIDLabel;
        private DateTimePicker pAMDateTimePicker;
        private TextBox pAMUNIDTextBox;
        private ComboBox pAMRegionComboBox;
        private Button pAMResetButton;
        private Button pAMSearchButton;
        private Label patAccManRoleLabel;
        private Button patAccManResultingDeleteButton;
        private DataGridView pAccMandataGridView;
        private DataGridViewTextBoxColumn Record_ID;
        private DataGridViewTextBoxColumn Patient_ID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
        private Button pAccManBackButton;
    }
}