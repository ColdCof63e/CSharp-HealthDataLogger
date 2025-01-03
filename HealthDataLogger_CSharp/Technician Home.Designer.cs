
namespace HealthDataLogger_CSharp
{
    partial class technicianHomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode4 = new TreeNode("Patient Health Data Management");
            TreeNode treeNode5 = new TreeNode("Patient Account Management");
            TreeNode treeNode6 = new TreeNode("My Account");
            thMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            techHomeTreeView = new TreeView();
            techHomeGroupBox = new GroupBox();
            techHomeResetButton = new Button();
            techHomeSearchButton = new Button();
            techHomeGenderComboBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            userNameOrIDTextBox = new TextBox();
            techHomeGenderLabel = new Label();
            techHomeDateLabel = new Label();
            gbUserNameLabel = new Label();
            thResultViewButton = new Button();
            thDataGridView = new DataGridView();
            Record_ID = new DataGridViewTextBoxColumn();
            Patient_ID = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            HealthMetric = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            techHomeLogoutButton = new Button();
            thMenuStrip.SuspendLayout();
            techHomeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)thDataGridView).BeginInit();
            SuspendLayout();
            // 
            // thMenuStrip
            // 
            thMenuStrip.ImageScalingSize = new Size(24, 24);
            thMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem, aboutUsToolStripMenuItem });
            thMenuStrip.Location = new Point(0, 0);
            thMenuStrip.Name = "thMenuStrip";
            thMenuStrip.Size = new Size(1112, 33);
            thMenuStrip.TabIndex = 0;
            thMenuStrip.Text = "menuStrip1";
            thMenuStrip.ItemClicked += thMenuStrip_ItemClicked;
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
            // techHomeTreeView
            // 
            techHomeTreeView.ItemHeight = 50;
            techHomeTreeView.Location = new Point(0, 36);
            techHomeTreeView.Name = "techHomeTreeView";
            treeNode4.Name = "patientHDManNode";
            treeNode4.Text = "Patient Health Data Management";
            treeNode5.Name = "patientAccManNode";
            treeNode5.Text = "Patient Account Management";
            treeNode6.Name = "myAccountNode";
            treeNode6.Text = "My Account";
            techHomeTreeView.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode5, treeNode6 });
            techHomeTreeView.Size = new Size(298, 557);
            techHomeTreeView.TabIndex = 1;
            techHomeTreeView.AfterSelect += techHomeTreeView_AfterSelect;
            // 
            // techHomeGroupBox
            // 
            techHomeGroupBox.Controls.Add(techHomeResetButton);
            techHomeGroupBox.Controls.Add(techHomeSearchButton);
            techHomeGroupBox.Controls.Add(techHomeGenderComboBox);
            techHomeGroupBox.Controls.Add(dateTimePicker1);
            techHomeGroupBox.Controls.Add(userNameOrIDTextBox);
            techHomeGroupBox.Controls.Add(techHomeGenderLabel);
            techHomeGroupBox.Controls.Add(techHomeDateLabel);
            techHomeGroupBox.Controls.Add(gbUserNameLabel);
            techHomeGroupBox.Location = new Point(304, 36);
            techHomeGroupBox.Name = "techHomeGroupBox";
            techHomeGroupBox.Size = new Size(794, 203);
            techHomeGroupBox.TabIndex = 2;
            techHomeGroupBox.TabStop = false;
            techHomeGroupBox.Text = "Filter";
            // 
            // techHomeResetButton
            // 
            techHomeResetButton.Location = new Point(676, 141);
            techHomeResetButton.Name = "techHomeResetButton";
            techHomeResetButton.Size = new Size(112, 34);
            techHomeResetButton.TabIndex = 7;
            techHomeResetButton.Text = "Reset";
            techHomeResetButton.UseVisualStyleBackColor = true;
            techHomeResetButton.Click += techHomeResetButton_Click;
            // 
            // techHomeSearchButton
            // 
            techHomeSearchButton.Location = new Point(527, 141);
            techHomeSearchButton.Name = "techHomeSearchButton";
            techHomeSearchButton.Size = new Size(112, 34);
            techHomeSearchButton.TabIndex = 6;
            techHomeSearchButton.Text = "Search";
            techHomeSearchButton.UseVisualStyleBackColor = true;
            techHomeSearchButton.Click += techHomeSearchButton_Click;
            // 
            // techHomeGenderComboBox
            // 
            techHomeGenderComboBox.FormattingEnabled = true;
            techHomeGenderComboBox.Items.AddRange(new object[] { "Male", "Female", "Others" });
            techHomeGenderComboBox.Location = new Point(192, 141);
            techHomeGenderComboBox.Name = "techHomeGenderComboBox";
            techHomeGenderComboBox.Size = new Size(182, 33);
            techHomeGenderComboBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(192, 88);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // userNameOrIDTextBox
            // 
            userNameOrIDTextBox.Location = new Point(192, 37);
            userNameOrIDTextBox.Name = "userNameOrIDTextBox";
            userNameOrIDTextBox.Size = new Size(197, 31);
            userNameOrIDTextBox.TabIndex = 3;
            // 
            // techHomeGenderLabel
            // 
            techHomeGenderLabel.AutoSize = true;
            techHomeGenderLabel.Location = new Point(6, 144);
            techHomeGenderLabel.Name = "techHomeGenderLabel";
            techHomeGenderLabel.Size = new Size(69, 25);
            techHomeGenderLabel.TabIndex = 2;
            techHomeGenderLabel.Text = "Gender";
            // 
            // techHomeDateLabel
            // 
            techHomeDateLabel.AutoSize = true;
            techHomeDateLabel.Location = new Point(6, 93);
            techHomeDateLabel.Name = "techHomeDateLabel";
            techHomeDateLabel.Size = new Size(49, 25);
            techHomeDateLabel.TabIndex = 1;
            techHomeDateLabel.Text = "Date";
            // 
            // gbUserNameLabel
            // 
            gbUserNameLabel.AutoSize = true;
            gbUserNameLabel.Location = new Point(6, 40);
            gbUserNameLabel.Name = "gbUserNameLabel";
            gbUserNameLabel.Size = new Size(144, 25);
            gbUserNameLabel.TabIndex = 0;
            gbUserNameLabel.Text = "User Name or ID";
            // 
            // thResultViewButton
            // 
            thResultViewButton.Location = new Point(970, 559);
            thResultViewButton.Name = "thResultViewButton";
            thResultViewButton.Size = new Size(99, 34);
            thResultViewButton.TabIndex = 10;
            thResultViewButton.Text = "View";
            thResultViewButton.UseVisualStyleBackColor = true;
            thResultViewButton.Click += thResultViewButton_Click;
            // 
            // thDataGridView
            // 
            thDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            thDataGridView.Columns.AddRange(new DataGridViewColumn[] { Record_ID, Patient_ID, UserName, HealthMetric, Value });
            thDataGridView.Location = new Point(304, 263);
            thDataGridView.Name = "thDataGridView";
            thDataGridView.RowHeadersWidth = 62;
            thDataGridView.Size = new Size(765, 290);
            thDataGridView.TabIndex = 11;
            thDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Record_ID
            // 
            Record_ID.HeaderText = "Record_ID";
            Record_ID.MinimumWidth = 8;
            Record_ID.Name = "Record_ID";
            Record_ID.Width = 150;
            // 
            // Patient_ID
            // 
            Patient_ID.HeaderText = "Patient ID";
            Patient_ID.MinimumWidth = 8;
            Patient_ID.Name = "Patient_ID";
            Patient_ID.Width = 150;
            // 
            // UserName
            // 
            UserName.HeaderText = "User Name";
            UserName.MinimumWidth = 8;
            UserName.Name = "UserName";
            UserName.Width = 150;
            // 
            // HealthMetric
            // 
            HealthMetric.HeaderText = "Metric";
            HealthMetric.MinimumWidth = 8;
            HealthMetric.Name = "HealthMetric";
            HealthMetric.Width = 150;
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.MinimumWidth = 8;
            Value.Name = "Value";
            Value.Width = 150;
            // 
            // techHomeLogoutButton
            // 
            techHomeLogoutButton.Location = new Point(310, 559);
            techHomeLogoutButton.Name = "techHomeLogoutButton";
            techHomeLogoutButton.Size = new Size(95, 29);
            techHomeLogoutButton.TabIndex = 12;
            techHomeLogoutButton.Text = "Logout";
            techHomeLogoutButton.UseVisualStyleBackColor = true;
            techHomeLogoutButton.Click += button1_Click;
            // 
            // technicianHomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 617);
            Controls.Add(techHomeLogoutButton);
            Controls.Add(thDataGridView);
            Controls.Add(thResultViewButton);
            Controls.Add(techHomeGroupBox);
            Controls.Add(techHomeTreeView);
            Controls.Add(thMenuStrip);
            MainMenuStrip = thMenuStrip;
            Name = "technicianHomeForm";
            Text = "Technician Home";
            Load += technicianHomeForm_Load;
            thMenuStrip.ResumeLayout(false);
            thMenuStrip.PerformLayout();
            techHomeGroupBox.ResumeLayout(false);
            techHomeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)thDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void thECTLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip thMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private TreeView techHomeTreeView;
        private GroupBox techHomeGroupBox;
        private Button techHomeResetButton;
        private Button techHomeSearchButton;
        private ComboBox techHomeGenderComboBox;
        private DateTimePicker dateTimePicker1;
        private TextBox userNameOrIDTextBox;
        private Label techHomeGenderLabel;
        private Label techHomeDateLabel;
        private Label gbUserNameLabel;
        private Label thRecordIDLabel;
        private Label thPatientIDLabel;
        private Label thUserNameLabel;
        private Label thECTLabel;
        private Label thEUTLabel;
        private Button thResultViewButton;
        private DataGridView thDataGridView;
        private DataGridViewTextBoxColumn Record_ID;
        private DataGridViewTextBoxColumn Patient_ID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn HealthMetric;
        private DataGridViewTextBoxColumn Value;
        private Button techHomeLogoutButton;
    }
}
