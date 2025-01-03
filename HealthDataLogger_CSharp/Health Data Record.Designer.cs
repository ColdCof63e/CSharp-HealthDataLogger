namespace HealthDataLogger_CSharp
{
    partial class healthDataRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(healthDataRecordForm));
            TreeNode treeNode1 = new TreeNode("Blood Glucose");
            TreeNode treeNode2 = new TreeNode("Leucocyte Count");
            TreeNode treeNode3 = new TreeNode("Erythrocyte Count");
            TreeNode treeNode4 = new TreeNode("Blood Oxygen");
            TreeNode treeNode5 = new TreeNode("Blood Pressure");
            TreeNode treeNode6 = new TreeNode("Body Temperature");
            TreeNode treeNode7 = new TreeNode("Blood Metrics", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6 });
            TreeNode treeNode8 = new TreeNode("Heart Rate");
            TreeNode treeNode9 = new TreeNode("Cholesterol Level");
            TreeNode treeNode10 = new TreeNode("Coronary Artery Calcium");
            TreeNode treeNode11 = new TreeNode("Heart Metrics", new TreeNode[] { treeNode8, treeNode9, treeNode10 });
            TreeNode treeNode12 = new TreeNode("Respiratory Rate");
            TreeNode treeNode13 = new TreeNode("Vital Capacity");
            TreeNode treeNode14 = new TreeNode("Respiratory Metrics", new TreeNode[] { treeNode12, treeNode13 });
            healthDataRecordMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutUSToolStripMenuItem = new ToolStripMenuItem();
            healthDRPictureBox = new PictureBox();
            healthMetricsListGroupBox = new GroupBox();
            healthMetricsTreeView = new TreeView();
            basicPersonalInfoGroupBox = new GroupBox();
            hdrWeightTextBox = new TextBox();
            hdrBloodTypeTextBox = new TextBox();
            hdrGenderTextBox = new TextBox();
            hdrHeightTextBox = new TextBox();
            hdrAgeTextBox = new TextBox();
            hdrPatientNameTextBox = new TextBox();
            hdrWeightLabel = new Label();
            hdrBloodTypeLabel = new Label();
            hdrGenderLabel = new Label();
            hdrHeightLabel = new Label();
            hdrAgeLabel = new Label();
            hdrPatientNameLabel = new Label();
            selectedHDPGroupBox = new GroupBox();
            addOther = new Button();
            healthMetricsDataGridView = new DataGridView();
            Metric = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            CreatedTime = new DataGridViewTextBoxColumn();
            hdrBackButton = new Button();
            healthDataDeleteButton = new Button();
            healthDataSaveButton = new Button();
            healthDataModfiyButton = new Button();
            healthDataRecordMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)healthDRPictureBox).BeginInit();
            healthMetricsListGroupBox.SuspendLayout();
            basicPersonalInfoGroupBox.SuspendLayout();
            selectedHDPGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)healthMetricsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // healthDataRecordMenuStrip
            // 
            healthDataRecordMenuStrip.ImageScalingSize = new Size(24, 24);
            healthDataRecordMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem, aboutUSToolStripMenuItem });
            healthDataRecordMenuStrip.Location = new Point(0, 0);
            healthDataRecordMenuStrip.Name = "healthDataRecordMenuStrip";
            healthDataRecordMenuStrip.Padding = new Padding(4, 1, 0, 1);
            healthDataRecordMenuStrip.Size = new Size(761, 24);
            healthDataRecordMenuStrip.TabIndex = 0;
            healthDataRecordMenuStrip.Text = "menuStrip1";
            healthDataRecordMenuStrip.ItemClicked += healthDataRecordMenuStrip_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 22);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUSToolStripMenuItem
            // 
            aboutUSToolStripMenuItem.Name = "aboutUSToolStripMenuItem";
            aboutUSToolStripMenuItem.Size = new Size(69, 22);
            aboutUSToolStripMenuItem.Text = "About US";
            // 
            // healthDRPictureBox
            // 
            healthDRPictureBox.Image = (Image)resources.GetObject("healthDRPictureBox.Image");
            healthDRPictureBox.Location = new Point(19, 22);
            healthDRPictureBox.Margin = new Padding(2, 2, 2, 2);
            healthDRPictureBox.Name = "healthDRPictureBox";
            healthDRPictureBox.Size = new Size(153, 107);
            healthDRPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            healthDRPictureBox.TabIndex = 1;
            healthDRPictureBox.TabStop = false;
            healthDRPictureBox.Click += healthDRPictureBox_Click;
            // 
            // healthMetricsListGroupBox
            // 
            healthMetricsListGroupBox.Controls.Add(healthMetricsTreeView);
            healthMetricsListGroupBox.Location = new Point(8, 132);
            healthMetricsListGroupBox.Margin = new Padding(2, 2, 2, 2);
            healthMetricsListGroupBox.Name = "healthMetricsListGroupBox";
            healthMetricsListGroupBox.Padding = new Padding(2, 2, 2, 2);
            healthMetricsListGroupBox.Size = new Size(177, 266);
            healthMetricsListGroupBox.TabIndex = 2;
            healthMetricsListGroupBox.TabStop = false;
            healthMetricsListGroupBox.Text = "Health Metrics List";
            healthMetricsListGroupBox.Enter += healthMetricsListGroupBox_Enter;
            // 
            // healthMetricsTreeView
            // 
            healthMetricsTreeView.Location = new Point(10, 18);
            healthMetricsTreeView.Margin = new Padding(2, 2, 2, 2);
            healthMetricsTreeView.Name = "healthMetricsTreeView";
            treeNode1.Name = "bloodGlucoseNode";
            treeNode1.Text = "Blood Glucose";
            treeNode2.Name = "leucocyteCountNode";
            treeNode2.Text = "Leucocyte Count";
            treeNode3.Name = "erythrocyteCountNode";
            treeNode3.Text = "Erythrocyte Count";
            treeNode4.Name = "bloodOxygenNode";
            treeNode4.Text = "Blood Oxygen";
            treeNode5.Name = "bloodPressureNode";
            treeNode5.Text = "Blood Pressure";
            treeNode6.Name = "bodyTemperatureNode";
            treeNode6.Text = "Body Temperature";
            treeNode7.Name = "bloodMetricsNode";
            treeNode7.Text = "Blood Metrics";
            treeNode8.Name = "heartRateNode";
            treeNode8.Text = "Heart Rate";
            treeNode9.Name = "cholesterolLevelNode";
            treeNode9.Text = "Cholesterol Level";
            treeNode10.Name = "coronaryArteryCalciumNode";
            treeNode10.Text = "Coronary Artery Calcium";
            treeNode11.Name = "heartMetricsNode";
            treeNode11.Text = "Heart Metrics";
            treeNode12.Name = "respiratoryRateNode";
            treeNode12.Text = "Respiratory Rate";
            treeNode13.Name = "vitalCapacityNode";
            treeNode13.Text = "Vital Capacity";
            treeNode14.Name = "respiratoryMetricsNode";
            treeNode14.Text = "Respiratory Metrics";
            healthMetricsTreeView.Nodes.AddRange(new TreeNode[] { treeNode7, treeNode11, treeNode14 });
            healthMetricsTreeView.Size = new Size(155, 246);
            healthMetricsTreeView.TabIndex = 0;
            healthMetricsTreeView.AfterSelect += healthMetricsTreeView_AfterSelect;
            // 
            // basicPersonalInfoGroupBox
            // 
            basicPersonalInfoGroupBox.Controls.Add(hdrWeightTextBox);
            basicPersonalInfoGroupBox.Controls.Add(hdrBloodTypeTextBox);
            basicPersonalInfoGroupBox.Controls.Add(hdrGenderTextBox);
            basicPersonalInfoGroupBox.Controls.Add(hdrHeightTextBox);
            basicPersonalInfoGroupBox.Controls.Add(hdrAgeTextBox);
            basicPersonalInfoGroupBox.Controls.Add(hdrPatientNameTextBox);
            basicPersonalInfoGroupBox.Controls.Add(hdrWeightLabel);
            basicPersonalInfoGroupBox.Controls.Add(hdrBloodTypeLabel);
            basicPersonalInfoGroupBox.Controls.Add(hdrGenderLabel);
            basicPersonalInfoGroupBox.Controls.Add(hdrHeightLabel);
            basicPersonalInfoGroupBox.Controls.Add(hdrAgeLabel);
            basicPersonalInfoGroupBox.Controls.Add(hdrPatientNameLabel);
            basicPersonalInfoGroupBox.Location = new Point(184, 22);
            basicPersonalInfoGroupBox.Margin = new Padding(2, 2, 2, 2);
            basicPersonalInfoGroupBox.Name = "basicPersonalInfoGroupBox";
            basicPersonalInfoGroupBox.Padding = new Padding(2, 2, 2, 2);
            basicPersonalInfoGroupBox.Size = new Size(568, 107);
            basicPersonalInfoGroupBox.TabIndex = 3;
            basicPersonalInfoGroupBox.TabStop = false;
            basicPersonalInfoGroupBox.Text = "Basic Personal Info";
            basicPersonalInfoGroupBox.Enter += basicPersonalInfoGroupBox_Enter;
            // 
            // hdrWeightTextBox
            // 
            hdrWeightTextBox.Location = new Point(410, 76);
            hdrWeightTextBox.Margin = new Padding(2, 2, 2, 2);
            hdrWeightTextBox.Name = "hdrWeightTextBox";
            hdrWeightTextBox.Size = new Size(106, 23);
            hdrWeightTextBox.TabIndex = 11;
            hdrWeightTextBox.TextChanged += hdrWeightTextBox_TextChanged;
            // 
            // hdrBloodTypeTextBox
            // 
            hdrBloodTypeTextBox.Location = new Point(410, 47);
            hdrBloodTypeTextBox.Margin = new Padding(2, 2, 2, 2);
            hdrBloodTypeTextBox.Name = "hdrBloodTypeTextBox";
            hdrBloodTypeTextBox.Size = new Size(106, 23);
            hdrBloodTypeTextBox.TabIndex = 10;
            hdrBloodTypeTextBox.TextChanged += hdrBloodTypeTextBox_TextChanged;
            // 
            // hdrGenderTextBox
            // 
            hdrGenderTextBox.Location = new Point(410, 20);
            hdrGenderTextBox.Margin = new Padding(2, 2, 2, 2);
            hdrGenderTextBox.Name = "hdrGenderTextBox";
            hdrGenderTextBox.Size = new Size(106, 23);
            hdrGenderTextBox.TabIndex = 9;
            hdrGenderTextBox.TextChanged += hdrGenderTextBox_TextChanged;
            // 
            // hdrHeightTextBox
            // 
            hdrHeightTextBox.Location = new Point(130, 76);
            hdrHeightTextBox.Margin = new Padding(2, 2, 2, 2);
            hdrHeightTextBox.Name = "hdrHeightTextBox";
            hdrHeightTextBox.Size = new Size(106, 23);
            hdrHeightTextBox.TabIndex = 8;
            hdrHeightTextBox.TextChanged += hdrHeightTextBox_TextChanged;
            // 
            // hdrAgeTextBox
            // 
            hdrAgeTextBox.Location = new Point(130, 47);
            hdrAgeTextBox.Margin = new Padding(2, 2, 2, 2);
            hdrAgeTextBox.Name = "hdrAgeTextBox";
            hdrAgeTextBox.Size = new Size(106, 23);
            hdrAgeTextBox.TabIndex = 7;
            hdrAgeTextBox.TextChanged += hdrAgeTextBox_TextChanged;
            // 
            // hdrPatientNameTextBox
            // 
            hdrPatientNameTextBox.Location = new Point(130, 20);
            hdrPatientNameTextBox.Margin = new Padding(2, 2, 2, 2);
            hdrPatientNameTextBox.Name = "hdrPatientNameTextBox";
            hdrPatientNameTextBox.Size = new Size(106, 23);
            hdrPatientNameTextBox.TabIndex = 6;
            hdrPatientNameTextBox.TextChanged += hdrPatientNameTextBox_TextChanged;
            // 
            // hdrWeightLabel
            // 
            hdrWeightLabel.AutoSize = true;
            hdrWeightLabel.Location = new Point(296, 78);
            hdrWeightLabel.Margin = new Padding(2, 0, 2, 0);
            hdrWeightLabel.Name = "hdrWeightLabel";
            hdrWeightLabel.Size = new Size(45, 15);
            hdrWeightLabel.TabIndex = 5;
            hdrWeightLabel.Text = "Weight";
            hdrWeightLabel.Click += hdrWeightLabel_Click;
            // 
            // hdrBloodTypeLabel
            // 
            hdrBloodTypeLabel.AutoSize = true;
            hdrBloodTypeLabel.Location = new Point(296, 49);
            hdrBloodTypeLabel.Margin = new Padding(2, 0, 2, 0);
            hdrBloodTypeLabel.Name = "hdrBloodTypeLabel";
            hdrBloodTypeLabel.Size = new Size(65, 15);
            hdrBloodTypeLabel.TabIndex = 4;
            hdrBloodTypeLabel.Text = "Blood Type";
            hdrBloodTypeLabel.Click += hdrBloodTypeLabel_Click;
            // 
            // hdrGenderLabel
            // 
            hdrGenderLabel.AutoSize = true;
            hdrGenderLabel.Location = new Point(296, 22);
            hdrGenderLabel.Margin = new Padding(2, 0, 2, 0);
            hdrGenderLabel.Name = "hdrGenderLabel";
            hdrGenderLabel.Size = new Size(45, 15);
            hdrGenderLabel.TabIndex = 3;
            hdrGenderLabel.Text = "Gender";
            hdrGenderLabel.Click += hdrGenderLabel_Click;
            // 
            // hdrHeightLabel
            // 
            hdrHeightLabel.AutoSize = true;
            hdrHeightLabel.Location = new Point(18, 78);
            hdrHeightLabel.Margin = new Padding(2, 0, 2, 0);
            hdrHeightLabel.Name = "hdrHeightLabel";
            hdrHeightLabel.Size = new Size(43, 15);
            hdrHeightLabel.TabIndex = 2;
            hdrHeightLabel.Text = "Height";
            hdrHeightLabel.Click += hdrHeightLabel_Click;
            // 
            // hdrAgeLabel
            // 
            hdrAgeLabel.AutoSize = true;
            hdrAgeLabel.Location = new Point(18, 49);
            hdrAgeLabel.Margin = new Padding(2, 0, 2, 0);
            hdrAgeLabel.Name = "hdrAgeLabel";
            hdrAgeLabel.Size = new Size(28, 15);
            hdrAgeLabel.TabIndex = 1;
            hdrAgeLabel.Text = "Age";
            hdrAgeLabel.Click += hdrAgeLabel_Click;
            // 
            // hdrPatientNameLabel
            // 
            hdrPatientNameLabel.AutoSize = true;
            hdrPatientNameLabel.Location = new Point(18, 22);
            hdrPatientNameLabel.Margin = new Padding(2, 0, 2, 0);
            hdrPatientNameLabel.Name = "hdrPatientNameLabel";
            hdrPatientNameLabel.Size = new Size(79, 15);
            hdrPatientNameLabel.TabIndex = 0;
            hdrPatientNameLabel.Text = "Patient Name";
            hdrPatientNameLabel.Click += hdrPatientNameLabel_Click;
            // 
            // selectedHDPGroupBox
            // 
            selectedHDPGroupBox.Controls.Add(addOther);
            selectedHDPGroupBox.Controls.Add(healthMetricsDataGridView);
            selectedHDPGroupBox.Controls.Add(hdrBackButton);
            selectedHDPGroupBox.Controls.Add(healthDataDeleteButton);
            selectedHDPGroupBox.Controls.Add(healthDataSaveButton);
            selectedHDPGroupBox.Controls.Add(healthDataModfiyButton);
            selectedHDPGroupBox.Location = new Point(190, 132);
            selectedHDPGroupBox.Margin = new Padding(2, 2, 2, 2);
            selectedHDPGroupBox.Name = "selectedHDPGroupBox";
            selectedHDPGroupBox.Padding = new Padding(2, 2, 2, 2);
            selectedHDPGroupBox.Size = new Size(563, 262);
            selectedHDPGroupBox.TabIndex = 4;
            selectedHDPGroupBox.TabStop = false;
            selectedHDPGroupBox.Text = "Selected Health Data Presenting";
            selectedHDPGroupBox.Enter += selectedHDPGroupBox_Enter;
            // 
            // addOther
            // 
            addOther.Location = new Point(26, 218);
            addOther.Margin = new Padding(2, 2, 2, 2);
            addOther.Name = "addOther";
            addOther.Size = new Size(78, 20);
            addOther.TabIndex = 6;
            addOther.Text = "Add other";
            addOther.UseVisualStyleBackColor = true;
            addOther.Click += addOther_Click;
            // 
            // healthMetricsDataGridView
            // 
            healthMetricsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            healthMetricsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Metric, Value, CreatedTime });
            healthMetricsDataGridView.Location = new Point(70, 47);
            healthMetricsDataGridView.Margin = new Padding(2, 2, 2, 2);
            healthMetricsDataGridView.Name = "healthMetricsDataGridView";
            healthMetricsDataGridView.RowHeadersWidth = 62;
            healthMetricsDataGridView.Size = new Size(361, 135);
            healthMetricsDataGridView.TabIndex = 5;
            healthMetricsDataGridView.CellContentClick += healthMetricsDataGridView_CellContentClick;
            // 
            // Metric
            // 
            Metric.HeaderText = "Metric";
            Metric.MinimumWidth = 8;
            Metric.Name = "Metric";
            Metric.Width = 150;
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.MinimumWidth = 8;
            Value.Name = "Value";
            Value.Width = 150;
            // 
            // CreatedTime
            // 
            CreatedTime.HeaderText = "Create Time";
            CreatedTime.MinimumWidth = 8;
            CreatedTime.Name = "CreatedTime";
            CreatedTime.Width = 150;
            // 
            // hdrBackButton
            // 
            hdrBackButton.Location = new Point(471, 218);
            hdrBackButton.Margin = new Padding(2, 2, 2, 2);
            hdrBackButton.Name = "hdrBackButton";
            hdrBackButton.Size = new Size(78, 20);
            hdrBackButton.TabIndex = 4;
            hdrBackButton.Text = "Back";
            hdrBackButton.UseVisualStyleBackColor = true;
            hdrBackButton.Click += hdrBackButton_Click;
            // 
            // healthDataDeleteButton
            // 
            healthDataDeleteButton.Location = new Point(361, 218);
            healthDataDeleteButton.Margin = new Padding(2, 2, 2, 2);
            healthDataDeleteButton.Name = "healthDataDeleteButton";
            healthDataDeleteButton.Size = new Size(78, 20);
            healthDataDeleteButton.TabIndex = 3;
            healthDataDeleteButton.Text = "Delete";
            healthDataDeleteButton.UseVisualStyleBackColor = true;
            healthDataDeleteButton.Click += healthDataDeleteButton_Click;
            // 
            // healthDataSaveButton
            // 
            healthDataSaveButton.Location = new Point(253, 218);
            healthDataSaveButton.Margin = new Padding(2, 2, 2, 2);
            healthDataSaveButton.Name = "healthDataSaveButton";
            healthDataSaveButton.Size = new Size(78, 20);
            healthDataSaveButton.TabIndex = 2;
            healthDataSaveButton.Text = "Save";
            healthDataSaveButton.UseVisualStyleBackColor = true;
            healthDataSaveButton.Click += healthDataSaveButton_Click;
            // 
            // healthDataModfiyButton
            // 
            healthDataModfiyButton.Location = new Point(150, 218);
            healthDataModfiyButton.Margin = new Padding(2, 2, 2, 2);
            healthDataModfiyButton.Name = "healthDataModfiyButton";
            healthDataModfiyButton.Size = new Size(78, 20);
            healthDataModfiyButton.TabIndex = 1;
            healthDataModfiyButton.Text = "Modify";
            healthDataModfiyButton.UseVisualStyleBackColor = true;
            healthDataModfiyButton.Click += healthDataModfiyButton_Click;
            // 
            // healthDataRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 405);
            Controls.Add(selectedHDPGroupBox);
            Controls.Add(basicPersonalInfoGroupBox);
            Controls.Add(healthMetricsListGroupBox);
            Controls.Add(healthDRPictureBox);
            Controls.Add(healthDataRecordMenuStrip);
            MainMenuStrip = healthDataRecordMenuStrip;
            Margin = new Padding(2, 2, 2, 2);
            Name = "healthDataRecordForm";
            Text = "Health Data Record";
            Load += healthDataRecordForm_Load;
            healthDataRecordMenuStrip.ResumeLayout(false);
            healthDataRecordMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)healthDRPictureBox).EndInit();
            healthMetricsListGroupBox.ResumeLayout(false);
            basicPersonalInfoGroupBox.ResumeLayout(false);
            basicPersonalInfoGroupBox.PerformLayout();
            selectedHDPGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)healthMetricsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip healthDataRecordMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutUSToolStripMenuItem;
        private PictureBox healthDRPictureBox;
        private GroupBox healthMetricsListGroupBox;
        private GroupBox basicPersonalInfoGroupBox;
        private GroupBox selectedHDPGroupBox;
        private TreeView healthMetricsTreeView;
        private Button healthDataDeleteButton;
        private Button healthDataSaveButton;
        private Button healthDataModfiyButton;
        private Label hdrWeightLabel;
        private Label hdrBloodTypeLabel;
        private Label hdrGenderLabel;
        private Label hdrHeightLabel;
        private Label hdrAgeLabel;
        private Label hdrPatientNameLabel;
        private TextBox hdrWeightTextBox;
        private TextBox hdrBloodTypeTextBox;
        private TextBox hdrGenderTextBox;
        private TextBox hdrHeightTextBox;
        private TextBox hdrAgeTextBox;
        private TextBox hdrPatientNameTextBox;
        private Button hdrBackButton;
        private DataGridView healthMetricsDataGridView;
        private Button addOther;
        private DataGridViewTextBoxColumn Metric;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewTextBoxColumn CreatedTime;
    }
}