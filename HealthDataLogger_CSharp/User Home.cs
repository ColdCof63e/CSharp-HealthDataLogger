using HealthDataLogger_CSharp.database;
using HealthDataLogger_CSharp.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System.Diagnostics;
using OxyPlot.Legends;
using System.Xml;
using System.Reflection.Metadata;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Pdf.Canvas;


namespace HealthDataLogger_CSharp
{
    public partial class UserHome : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private List<HealthMetricData> allMetrics;

        public UserHome()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            userHomeNameBox.Text = UserSession.CurrentUser.Name;
            userHomeMailBox.Text = UserSession.CurrentUser.Email;
            LoadHealthMetricsFromDatabase();

            //this.filterDataBtn.Click += new EventHandler(FilterDataBtn_Click);
            this.userHomeHealthMetricView.CellClick += new DataGridViewCellEventHandler(this.userHomeHealthMetricView_CellClick);
            this.Click += new EventHandler(UserHome_Click);
            this.GenerateReportBtn.Click += new EventHandler(GenerateReportBtn_Click);

        }

        private void MyAccountBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyAccount myAccount = new MyAccount();
            myAccount.Show();
        }

        private void CreateNewEntryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            healthDataRecordForm record = new healthDataRecordForm(UserSession.CurrentUser.Email);
            record.Show();
        }

        private void LoadHealthMetricsFromDatabase()
        {
            try
            {
                string currentUserEmail = UserSession.CurrentUser.Email;
                Debug.WriteLine($"Fetching health metrics for {currentUserEmail}");

                var metrics = DatabaseCommunication.GetHealthMetrics(currentUserEmail);

                // Sort the metrics by DateRecorded, most recent first
                var sortedMetrics = metrics.OrderByDescending(hm => hm.DateRecorded).ToList();

                allMetrics = sortedMetrics;
                bindingSource.DataSource = sortedMetrics;

                Debug.WriteLine($"{bindingSource.Count} health metrics retrieved.");

                BindHealthMetricsToDataGridView();

                // Add status column to the DataGridView

                userHomeHealthMetricView.Columns.Add("Status", "Status");


                // Populate the status column

                foreach (DataGridViewRow row in userHomeHealthMetricView.Rows)

                {

                    var metric = (HealthMetricData)row.DataBoundItem;


                    // Check if metric is not null

                    if (metric != null)

                    {

                        string status = GetMetricStatus.GetStatus(metric);

                        row.Cells["Status"].Value = status;

                    }

                    else

                    {

                        row.Cells["Status"].Value = "Unknown"; // Handle null metric

                    }

                }

                PlotLineChart(sortedMetrics);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading health metrics: " + ex.Message);
            }
        }


        private void BindHealthMetricsToDataGridView()
        {
            userHomeHealthMetricView.DataSource = bindingSource;
        }

        private void PlotLineChart(List<HealthMetricData> metrics)
        {
            var plotModel = new PlotModel { Title = "Health Metrics Over Time" };

            if (metrics != null && metrics.Count > 0)
            {
                // Grouping the metrics by MetricName to create separate lines for each metric
                var groupedMetrics = metrics
                    .GroupBy(hm => hm.MetricName)  // Group by MetricName
                    .ToList();

                // Enable the legend visibility (for automatic legend handling)
                plotModel.IsLegendVisible = true; // Legend will be automatically shown based on Series Titles

                foreach (var group in groupedMetrics)
                {
                    var lineSeries = new LineSeries
                    {
                        Title = group.Key,  // The title is the MetricName, which appears in the legend
                        StrokeThickness = 2,
                        MarkerSize = 4,
                        MarkerType = MarkerType.Circle,
                    };

                    // Sorting metrics by DateRecorded (and time) to ensure they are in chronological order
                    var sortedMetrics = group.OrderBy(hm => hm.DateRecorded).ToList();

                    foreach (var metric in sortedMetrics)
                    {
                        if (metric.MetricName == "Blood Pressure") // Handle Blood Pressure
                        {
                            var bloodPressure = metric.Value;  // Example: "120/80"
                            var pressureValues = bloodPressure.Split('/');

                            if (pressureValues.Length == 2)
                            {
                                // Try parsing systolic and diastolic values
                                if (double.TryParse(pressureValues[0], out double systolic) &&
                                    double.TryParse(pressureValues[1], out double diastolic))
                                {
                                    // Example: plotting the average of systolic and diastolic
                                    double averagePressure = (systolic + diastolic) / 2;

                                    lineSeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(metric.DateRecorded), averagePressure));
                                }
                                else
                                {
                                    Debug.WriteLine($"Invalid blood pressure value: {bloodPressure}");
                                }
                            }
                            else
                            {
                                Debug.WriteLine($"Invalid blood pressure format: {bloodPressure}");
                            }
                        }
                        else
                        {
                            // For other metrics
                            if (double.TryParse(metric.Value, out double value))
                            {
                                lineSeries.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(metric.DateRecorded), value));
                            }
                            else
                            {
                                Debug.WriteLine($"Invalid value for metric: {metric.Value}");
                            }
                        }
                    }

                    // Add the series to the plot model
                    plotModel.Series.Add(lineSeries);
                }

                // Set up the plot view
                var plotView = new PlotView
                {
                    Model = plotModel,
                    Dock = DockStyle.Fill
                };

                // Clear previous plot and add the new one
                plotView1.Controls.Clear();
                plotView1.Controls.Add(plotView);

                // Set up the x-axis to show date and time
                var dateAxis = new DateTimeAxis
                {
                    Position = AxisPosition.Bottom,
                    Title = "Date and Time",
                    StringFormat = "MMM-dd HH:mm",  // Format for date and time
                    IntervalType = DateTimeIntervalType.Hours, // Adjust based on your data's time range
                    MajorGridlineStyle = OxyPlot.LineStyle.Solid,
                    MinorGridlineStyle = OxyPlot.LineStyle.Dot
                };

                plotModel.Axes.Add(dateAxis);
            }
            else
            {
                Debug.WriteLine("No health metrics to plot.");
            }
        }

        private void GenerateReportBtn_Click(object sender, EventArgs e)
        {
            // Create a new context menu
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // Add items to the context menu
            ToolStripMenuItem csvItem = new ToolStripMenuItem("CSV");
            ToolStripMenuItem textFileItem = new ToolStripMenuItem("Text File");
            ToolStripMenuItem pdfItem = new ToolStripMenuItem("PDF");

            // Add event handlers for each menu item
            csvItem.Click += (s, args) => ExportToCSV((List<HealthMetricData>)bindingSource.DataSource);
            textFileItem.Click += (s, args) => ExportToTextFile((List<HealthMetricData>)bindingSource.DataSource);
            pdfItem.Click += (s, args) => ExportToPDF((List<HealthMetricData>)bindingSource.DataSource);

            // Add items to the context menu
            contextMenu.Items.Add(csvItem);
            contextMenu.Items.Add(textFileItem);
            contextMenu.Items.Add(pdfItem);

            // Get the screen coordinates of the GenerateReportBtn control
            Point screenPoint = GenerateReportBtn.PointToScreen(new Point(0, GenerateReportBtn.Height));

            // Show the context menu at the screen coordinates
            contextMenu.Show(screenPoint);
        }


        private void ExportToPDF(List<HealthMetricData> healthMetrics)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var writer = new PdfWriter(saveFileDialog.FileName))
                    {
                        using (var pdf = new PdfDocument(writer))
                        {
                            var document = new iText.Layout.Document(pdf);

                            // Add title to the document with bold font
                            document.Add(new Paragraph("Health Metrics Report")
                                .SetFontSize(18)
                                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                            document.Add(new Paragraph("\n"));
                            document.Add(new Paragraph("Name: "+UserSession.CurrentUser.Name + "\n"));
                            document.Add(new Paragraph("Email ID: "+UserSession.CurrentUser.Email + "\n"));
                            document.Add(new Paragraph("Phone Number: "+UserSession.CurrentUser.PhoneNumber + "\n"));

                            // Loop through health metrics and add to the PDF
                            foreach (var metric in healthMetrics)
                            {
                                string status = GetMetricStatus.GetStatus(metric);
                                document.Add(new Paragraph($"RecordID: {metric.RecordID}"));
                                document.Add(new Paragraph($"PatientID: {metric.PatientID}"));
                                document.Add(new Paragraph($"Metric Name: {metric.MetricName}"));
                                document.Add(new Paragraph($"Value: {metric.Value}\t\t\t\t{status}"));
                                document.Add(new Paragraph($"Date Recorded: {metric.DateRecorded}"));
                                document.Add(new Paragraph("\n"));
                            }

                            document.Close();
                        }
                    }

                    MessageBox.Show("PDF report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportToTextFile(List<HealthMetricData> healthMetrics)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Write a title for the report
                        writer.WriteLine("Health Metrics Report");
                        writer.WriteLine("====================================");
                        writer.WriteLine("Name: "+UserSession.CurrentUser.Name);
                        writer.WriteLine("Email-ID: " + UserSession.CurrentUser.Email);
                        writer.WriteLine("Phone Number: " + UserSession.CurrentUser.PhoneNumber);
                        //writer.WriteLine(UserSession.CurrentUser.BloodType);
                        writer.WriteLine("====================================");
                        writer.WriteLine("\n");

                        // Write each health metric data
                        foreach (var metric in healthMetrics)
                        {
                            string status = GetMetricStatus.GetStatus(metric);
                            writer.WriteLine($"RecordID: {metric.RecordID}");
                            writer.WriteLine($"PatientID: {metric.PatientID}");
                            writer.WriteLine($"Metric Name: {metric.MetricName}");
                            writer.WriteLine($"Value: {metric.Value}\t\t\t\t{status}");
                            writer.WriteLine($"Date Recorded: {metric.DateRecorded}");
                            writer.WriteLine("------------------------------------");
                        }
                    }

                    MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating text file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportToCSV(List<HealthMetricData> healthMetrics)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File (*.csv)|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Write header
                        writer.WriteLine("RecordID,PatientID,MetricName,Value,DateRecorded,Status");
                        writer.WriteLine("\n");

                        writer.WriteLine("Name: " + UserSession.CurrentUser.Name);
                        writer.WriteLine("Email-ID: " + UserSession.CurrentUser.Email);
                        writer.WriteLine("Phone Number: " + UserSession.CurrentUser.PhoneNumber);

                        // Write each health metric data
                        foreach (var metric in healthMetrics)
                        {
                            string status = GetMetricStatus.GetStatus(metric);
                            writer.WriteLine($"{metric.RecordID},{metric.PatientID},{metric.MetricName},{metric.Value},{metric.DateRecorded}, {status}");
                        }
                    }

                    MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Based on clicked metric data
        private void userHomeHealthMetricView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected health metric from the DataGridView
                var selectedMetric = (HealthMetricData)bindingSource[e.RowIndex];

                // Extract the MetricName of the selected row
                string metricName = selectedMetric.MetricName;

                // Filter the overall data to include only the selected metric name
                var allMetrics = (List<HealthMetricData>)bindingSource.DataSource;
                var filteredMetrics = allMetrics.Where(m => m.MetricName == metricName).ToList();

                // Plot only the selected metric data
                PlotLineChart(filteredMetrics);
            }
        }


        // Clicking outside the table, reset the chart
        private void UserHome_Click(object sender, EventArgs e)
        {
            // Check if the click was outside the DataGridView
            if (!userHomeHealthMetricView.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                // Reset the chart to show all metrics
                PlotLineChart((List<HealthMetricData>)bindingSource.DataSource);
            }
        }

        private void FilterDataBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get the start and end dates from the date pickers
                DateTime startDate = startDatePicker.Value.Date;
                DateTime endDate = endDatePicker.Value.Date;

                // Validate the date range
                if (endDate < startDate)
                {
                    MessageBox.Show("End date cannot be earlier than start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Filter the data based on the date range
                var filteredMetrics = allMetrics
                    .Where(hm => hm.DateRecorded >= startDate && hm.DateRecorded <= endDate)
                    .ToList();

                // Bind the filtered data to the DataGridView
                bindingSource.DataSource = filteredMetrics;

                // Refresh the DataGridView
                userHomeHealthMetricView.DataSource = bindingSource;

                // Reset the plot with the filtered data
                PlotLineChart(filteredMetrics);

                MessageBox.Show("Data filtered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
