namespace HealthDataLogger_CSharp
{
    partial class UserHome
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
            components = new System.ComponentModel.Container();
            mainTable = new TableLayoutPanel();
            TopCenterCellTable = new TableLayoutPanel();
            MyAccountBtn = new Button();
            GenerateReportBtn = new Button();
            label2 = new Label();
            userHomeMailBox = new TextBox();
            splitContainer1 = new SplitContainer();
            userHomeHealthMetricView = new DataGridView();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            tableLayoutPanel1 = new TableLayoutPanel();
            CreateNewEntryBtn = new Button();
            label1 = new Label();
            userHomeNameBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            FilterDataBtn = new Button();
            healthMetricBindingSource = new BindingSource(components);
            patientRecordBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            recordIDsBindingSource = new BindingSource(components);
            recordIDsBindingSource1 = new BindingSource(components);
            healthMetricBindingSource1 = new BindingSource(components);
            mainTable.SuspendLayout();
            TopCenterCellTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userHomeHealthMetricView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)healthMetricBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientRecordBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recordIDsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recordIDsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)healthMetricBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // mainTable
            // 
            mainTable.AutoSize = true;
            mainTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainTable.ColumnCount = 3;
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            mainTable.Controls.Add(TopCenterCellTable, 1, 0);
            mainTable.Controls.Add(splitContainer1, 0, 1);
            mainTable.Controls.Add(tableLayoutPanel1, 0, 0);
            mainTable.Controls.Add(tableLayoutPanel2, 2, 0);
            mainTable.Dock = DockStyle.Fill;
            mainTable.Location = new Point(0, 24);
            mainTable.Name = "mainTable";
            mainTable.RowCount = 3;
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            mainTable.Size = new Size(800, 426);
            mainTable.TabIndex = 0;
            // 
            // TopCenterCellTable
            // 
            TopCenterCellTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TopCenterCellTable.ColumnCount = 4;
            TopCenterCellTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TopCenterCellTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TopCenterCellTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TopCenterCellTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TopCenterCellTable.Controls.Add(MyAccountBtn, 0, 2);
            TopCenterCellTable.Controls.Add(GenerateReportBtn, 2, 2);
            TopCenterCellTable.Controls.Add(label2, 0, 0);
            TopCenterCellTable.Controls.Add(userHomeMailBox, 1, 0);
            TopCenterCellTable.Location = new Point(269, 3);
            TopCenterCellTable.Name = "TopCenterCellTable";
            TopCenterCellTable.RowCount = 4;
            TopCenterCellTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TopCenterCellTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TopCenterCellTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TopCenterCellTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TopCenterCellTable.Size = new Size(260, 135);
            TopCenterCellTable.TabIndex = 1;
            // 
            // MyAccountBtn
            // 
            MyAccountBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TopCenterCellTable.SetColumnSpan(MyAccountBtn, 2);
            MyAccountBtn.Location = new Point(3, 87);
            MyAccountBtn.Name = "MyAccountBtn";
            TopCenterCellTable.SetRowSpan(MyAccountBtn, 2);
            MyAccountBtn.Size = new Size(124, 26);
            MyAccountBtn.TabIndex = 0;
            MyAccountBtn.Text = "My &Account";
            MyAccountBtn.UseVisualStyleBackColor = true;
            MyAccountBtn.Click += MyAccountBtn_Click;
            // 
            // GenerateReportBtn
            // 
            GenerateReportBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TopCenterCellTable.SetColumnSpan(GenerateReportBtn, 2);
            GenerateReportBtn.Location = new Point(133, 89);
            GenerateReportBtn.Name = "GenerateReportBtn";
            TopCenterCellTable.SetRowSpan(GenerateReportBtn, 2);
            GenerateReportBtn.Size = new Size(124, 23);
            GenerateReportBtn.TabIndex = 1;
            GenerateReportBtn.Text = "Generate &Report";
            GenerateReportBtn.UseVisualStyleBackColor = true;
            GenerateReportBtn.Click += GenerateReportBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(7, 25);
            label2.Name = "label2";
            TopCenterCellTable.SetRowSpan(label2, 2);
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Email-ID:";
            // 
            // userHomeMailBox
            // 
            userHomeMailBox.Anchor = AnchorStyles.Left;
            TopCenterCellTable.SetColumnSpan(userHomeMailBox, 2);
            userHomeMailBox.Location = new Point(68, 21);
            userHomeMailBox.Name = "userHomeMailBox";
            TopCenterCellTable.SetRowSpan(userHomeMailBox, 2);
            userHomeMailBox.Size = new Size(124, 23);
            userHomeMailBox.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTable.SetColumnSpan(splitContainer1, 3);
            splitContainer1.Location = new Point(3, 144);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(userHomeHealthMetricView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(plotView1);
            mainTable.SetRowSpan(splitContainer1, 2);
            splitContainer1.Size = new Size(794, 279);
            splitContainer1.SplitterDistance = 322;
            splitContainer1.TabIndex = 8;
            // 
            // userHomeHealthMetricView
            // 
            userHomeHealthMetricView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userHomeHealthMetricView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userHomeHealthMetricView.Location = new Point(3, 3);
            userHomeHealthMetricView.Name = "userHomeHealthMetricView";
            userHomeHealthMetricView.Size = new Size(316, 273);
            userHomeHealthMetricView.TabIndex = 2;
            // 
            // plotView1
            // 
            plotView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plotView1.Location = new Point(3, 3);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(462, 276);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(CreateNewEntryBtn, 2, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(userHomeNameBox, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(260, 135);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // CreateNewEntryBtn
            // 
            CreateNewEntryBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(CreateNewEntryBtn, 2);
            CreateNewEntryBtn.Location = new Point(133, 89);
            CreateNewEntryBtn.Name = "CreateNewEntryBtn";
            tableLayoutPanel1.SetRowSpan(CreateNewEntryBtn, 2);
            CreateNewEntryBtn.Size = new Size(124, 23);
            CreateNewEntryBtn.TabIndex = 0;
            CreateNewEntryBtn.Text = "&Health Record";
            CreateNewEntryBtn.UseVisualStyleBackColor = true;
            CreateNewEntryBtn.Click += CreateNewEntryBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            tableLayoutPanel1.SetRowSpan(label1, 2);
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // userHomeNameBox
            // 
            userHomeNameBox.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(userHomeNameBox, 2);
            userHomeNameBox.Location = new Point(68, 21);
            userHomeNameBox.Name = "userHomeNameBox";
            tableLayoutPanel1.SetRowSpan(userHomeNameBox, 2);
            userHomeNameBox.Size = new Size(124, 23);
            userHomeNameBox.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(startDatePicker, 1, 0);
            tableLayoutPanel2.Controls.Add(endDatePicker, 1, 1);
            tableLayoutPanel2.Controls.Add(FilterDataBtn, 1, 2);
            tableLayoutPanel2.Location = new Point(535, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(262, 135);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(28, 7);
            label3.Name = "label3";
            label3.Size = new Size(34, 30);
            label3.TabIndex = 0;
            label3.Text = "Start Date:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(5, 60);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 1;
            label4.Text = "End Date:";
            // 
            // startDatePicker
            // 
            startDatePicker.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.SetColumnSpan(startDatePicker, 2);
            startDatePicker.Location = new Point(68, 11);
            startDatePicker.MaxDate = new DateTime(2024, 12, 11, 0, 0, 0, 0);
            startDatePicker.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(124, 23);
            startDatePicker.TabIndex = 2;
            startDatePicker.Value = new DateTime(2024, 12, 8, 0, 0, 0, 0);
            // 
            // endDatePicker
            // 
            endDatePicker.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.SetColumnSpan(endDatePicker, 2);
            endDatePicker.Location = new Point(68, 56);
            endDatePicker.MaxDate = new DateTime(2024, 12, 11, 0, 0, 0, 0);
            endDatePicker.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(124, 23);
            endDatePicker.TabIndex = 3;
            endDatePicker.Value = new DateTime(2024, 12, 8, 0, 0, 0, 0);
            // 
            // FilterDataBtn
            // 
            FilterDataBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(FilterDataBtn, 2);
            FilterDataBtn.Location = new Point(68, 93);
            FilterDataBtn.Name = "FilterDataBtn";
            FilterDataBtn.Size = new Size(124, 23);
            FilterDataBtn.TabIndex = 4;
            FilterDataBtn.Text = "&Filter Data";
            FilterDataBtn.UseVisualStyleBackColor = true;
            FilterDataBtn.Click += FilterDataBtn_Click_1;
            // 
            // healthMetricBindingSource
            // 
            healthMetricBindingSource.DataSource = typeof(HealthMetric);
            // 
            // patientRecordBindingSource
            // 
            patientRecordBindingSource.DataSource = typeof(PatientRecord);
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // recordIDsBindingSource
            // 
            recordIDsBindingSource.DataMember = "RecordIDs";
            recordIDsBindingSource.DataSource = patientRecordBindingSource;
            // 
            // recordIDsBindingSource1
            // 
            recordIDsBindingSource1.DataMember = "RecordIDs";
            recordIDsBindingSource1.DataSource = patientRecordBindingSource;
            // 
            // healthMetricBindingSource1
            // 
            healthMetricBindingSource1.DataSource = typeof(HealthMetric);
            // 
            // UserHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainTable);
            Controls.Add(menuStrip1);
            Name = "UserHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Home";
            mainTable.ResumeLayout(false);
            TopCenterCellTable.ResumeLayout(false);
            TopCenterCellTable.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userHomeHealthMetricView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)healthMetricBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientRecordBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)recordIDsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)recordIDsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)healthMetricBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel mainTable;
        private TableLayoutPanel TopCenterCellTable;
        private Button CreateNewEntryBtn;
        private DataGridView userHomeHealthMetricView;
        private DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private BindingSource patientRecordBindingSource;
        private MenuStrip menuStrip1;
        private Button GenerateReportBtn;
        private Button MyAccountBtn;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TextBox userHomeMailBox;
        private Label label1;
        private TextBox userHomeNameBox;
        private Label label3;
        private Label label4;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private Button FilterDataBtn;
        private BindingSource recordIDsBindingSource;
        private BindingSource recordIDsBindingSource1;
        private BindingSource healthMetricBindingSource;
        private BindingSource healthMetricBindingSource1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.Button filterDataBtn;

    }
}