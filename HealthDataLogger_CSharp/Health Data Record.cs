using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using HealthDataLogger_CSharp;
using HealthDataLogger_CSharp.utils;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;


namespace HealthDataLogger_CSharp
{
    // Represents the Health Data Record Form, allowing interaction with patient health metrics.
    public partial class healthDataRecordForm : Form
    {
        // ATTRIBUTES

        // Stores all patient records loaded from JSON
        // private List<PatientRecord> patientRecords;
        // Stores all health metrics loaded from JSON
        //private List<HealthMetric> healthMetrics = new List<HealthMetric>();
        // File path for storing health metrics in JSON format
        //private const string MetricsFile = "HealthMetrics.json";

        //string connectionString = "Server=MYTHINKPAD\\SQLEXPRESS;Database=HealthDataLogger;Trusted_Connection=True;TrustServerCertificate=True;";
        string connectionString = "Server=COLDCOF63E\\SQLEXPRESS;Database=HealthDataLogger;Integrated Security=True;TrustServerCertificate=True;";
        private List<HealthMetric> healthMetrics = new List<HealthMetric>();
        private string currentPatientID;

        // CONSTRUCTOR

        // Initializes the health data record form, loads health metrics data, and prepares the form.
        public healthDataRecordForm(string patientID)
        {
            InitializeComponent();
            currentPatientID = patientID;
            LoadHealthMetricsFromDatabase();
            LoadPatientDetailsFromDatabase();
        }

        // METHODS

        // Load patient details from the database
        private void LoadPatientDetailsFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // make sure sql query match database
                string query = "SELECT * FROM users WHERE email = @Email"; 
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", currentPatientID); // using currentPatientID as email

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    hdrPatientNameTextBox.Text = reader["name"].ToString();
                    hdrGenderTextBox.Text = reader["gender"].ToString();
                    hdrBloodTypeTextBox.Text = reader["bloodType"].ToString();
                    hdrHeightTextBox.Text = reader["height"].ToString();
                    hdrWeightTextBox.Text = reader["weight"].ToString();

                    // calculate age by DOB
                    if (DateTime.TryParse(reader["dob"].ToString(), out DateTime dob))
                    {
                        hdrAgeTextBox.Text = (DateTime.Now.Year - dob.Year).ToString();
                    }
                    else
                    {
                        hdrAgeTextBox.Text = "N/A"; // if can not parse dob，display N/A
                    }
                }

                reader.Close();
            }
        }



        // Load health metrics from the database
        private void LoadHealthMetricsFromDatabase()
        {
            healthMetrics.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT record_id, patient_id, metric, value, date_recorded FROM healthrecords WHERE patient_id = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", currentPatientID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    healthMetrics.Add(new HealthMetric
                    {
                        RecordID = reader["record_id"].ToString(),
                        PatientID = reader["patient_id"].ToString(),
                        MetricName = reader["metric"].ToString(),
                        Value = reader["value"].ToString(),
                        DateRecorded = reader["date_recorded"] != DBNull.Value ? (DateTime)reader["date_recorded"] : DateTime.MinValue
                    });
                }

                reader.Close();
            }

            BindHealthMetricsToDataGridView();
        }



        // Bind health metrics to the DataGridView
        private void BindHealthMetricsToDataGridView()
        {
            healthMetricsDataGridView.DataSource = null;
            healthMetricsDataGridView.AutoGenerateColumns = false;
            healthMetricsDataGridView.Columns.Clear();

            // Add column definitions and ensure DataPropertyName is correctly mapped to the model's properties
            healthMetricsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Record ID",
                DataPropertyName = "RecordID", // make sure with HealthMetrics
                Name = "RecordID"
            });
            healthMetricsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Patient ID",
                DataPropertyName = "PatientID", 
                Name = "PatientID"
            });
            healthMetricsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Metric Name",
                DataPropertyName = "MetricName", 
                Name = "MetricName"
            });
            healthMetricsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Value",
                DataPropertyName = "Value", 
                Name = "Value"
            });
            healthMetricsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Date Recorded",
                DataPropertyName = "DateRecorded", 
                Name = "DateRecorded"
            });

            // bind data source
            healthMetricsDataGridView.DataSource = healthMetrics;
        }




        /**
        // Saves the current health metrics list to a JSON file.
        private void SaveHealthMetrics()
        {
            try
            {
                string json = JsonSerializer.Serialize(healthMetrics, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(MetricsFile, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving health metrics: {ex.Message}");
            }
        } **/

        /**
        // Loads personal details of a specific patient by their ID and displays them on the form.
        // patientID is the ID of the patient to load details for.
        private void LoadPatientDetails(int patientID)
        {
            // Find the patient record
            var patient = patientRecords.FirstOrDefault(p => p.PatientID == patientID);

            if (patient != null && patient.Details != null)
            {
                hdrPatientNameTextBox.Text = patient.Details.Name;
                hdrAgeTextBox.Text = patient.Details.Age.ToString();
                hdrGenderTextBox.Text = patient.Details.Gender;
                hdrBloodTypeTextBox.Text = patient.Details.BloodType;
                hdrHeightTextBox.Text = patient.Details.Height;
                hdrWeightTextBox.Text = patient.Details.Weight;
            }
            else
            {
                MessageBox.Show("Patient details not found.");
            }
        }

        **/


        private void healthDataRecordForm_Load(object sender, EventArgs e)
        {
            // Example patient ID passed to load patient details
            //int patientID = 1;
            //LoadPatientRecords();
            //LoadPatientDetails(patientID);
        }       

        private void healthDataRecordMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void healthDRPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void basicPersonalInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void hdrPatientNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void hdrPatientNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hdrAgeLabel_Click(object sender, EventArgs e)
        {

        }

        private void hdrAgeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hdrHeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void hdrHeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hdrGenderLabel_Click(object sender, EventArgs e)
        {

        }

        private void hdrGenderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hdrBloodTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void hdrBloodTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hdrWeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void hdrWeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void healthMetricsListGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void healthMetricsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Parent != null)
            {
                string selectedMetric = e.Node.Text;

                // Search for matching rows in DataGridView (including null values)
                var rows = healthMetricsDataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => row.Cells["MetricName"].Value != null &&
                                  row.Cells["MetricName"].Value.ToString() == selectedMetric)
                    .ToList();

                if (rows.Any())
                {
                    // If matches found, select the first one
                    healthMetricsDataGridView.ClearSelection();
                    rows[0].Selected = true;
                    healthMetricsDataGridView.FirstDisplayedScrollingRowIndex = rows[0].Index;
                }
                else
                {
                    // If no match found, prompt to add new
                    DialogResult result = MessageBox.Show(
                        $"No matching metric '{selectedMetric}' found. Would you like to add it?",
                        "Metric Not Found",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Show dialog for value input
                        string newValue = Prompt.ShowDialog($"Enter value for metric: {selectedMetric}", "Add Metric Value");

                        if (!string.IsNullOrWhiteSpace(newValue))
                        {
                            // Validate the input value
                            if (!ValidateHealthMetric(selectedMetric, newValue))
                            {
                                return; // Exit if validation fails
                            }

                            try
                            {
                                // Insert data into database
                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    string query = @"
                            INSERT INTO healthrecords (record_id, patient_id, metric, value, date_recorded) 
                            VALUES (NEWID(), @PatientID, @MetricName, @Value, @DateRecorded)";

                                    SqlCommand command = new SqlCommand(query, connection);
                                    command.Parameters.AddWithValue("@PatientID", currentPatientID);
                                    command.Parameters.AddWithValue("@MetricName", selectedMetric);
                                    command.Parameters.AddWithValue("@Value", newValue);
                                    command.Parameters.AddWithValue("@DateRecorded", DateTime.Now);

                                    connection.Open();
                                    command.ExecuteNonQuery();
                                }

                                // Refresh data display
                                LoadHealthMetricsFromDatabase();
                                MessageBox.Show("Metric and value added successfully.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred while adding the metric: {ex.Message}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No value entered. Please try again.");
                        }
                    }
                }
            }
        }


        private void selectedHDPGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void healthDataNameWithValue_TextChanged(object sender, EventArgs e)
        {

        }

        // Allows the user to modify the selected health metric.

        // Modify the selected metric's value
        private void healthDataModfiyButton_Click(object sender, EventArgs e)
        {
            if (healthMetricsDataGridView.SelectedRows.Count > 0)
            {
                if (!UserSession.CurrentUser.IsTech.Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    // get the row that we selected recorded time
                    var rows = healthMetricsDataGridView.SelectedRows[0];
                    if (rows.Cells["DateRecorded"].Value is DateTime recordTime)
                    {
                        TimeSpan timeDifference = DateTime.Now - recordTime;

                        // if it takes more than ten minutes, display message and return
                        if (timeDifference.TotalMinutes > 10)
                        {
                            MessageBox.Show("You can only modify records within 10 minutes of creation.",
                                          "Time Limit Exceeded",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                // Verify column existence
                if (!healthMetricsDataGridView.Columns.Contains("RecordID") ||
                    !healthMetricsDataGridView.Columns.Contains("Value") ||
                    !healthMetricsDataGridView.Columns.Contains("MetricName"))
                {
                    MessageBox.Show("Required columns do not exist in the DataGridView.");
                    return;
                }

                // Get selected row data
                var row = healthMetricsDataGridView.SelectedRows[0];
                var recordIDValue = row.Cells["RecordID"].Value;
                var currentValueValue = row.Cells["Value"].Value;
                var metricName = row.Cells["MetricName"].Value?.ToString();

                // Validate data presence
                if (recordIDValue == null || string.IsNullOrWhiteSpace(recordIDValue.ToString()) ||
                    currentValueValue == null || string.IsNullOrWhiteSpace(currentValueValue.ToString()))
                {
                    MessageBox.Show("Invalid record data. Please select a valid record to modify.");
                    return;
                }

                string recordID = recordIDValue.ToString();
                string currentValue = currentValueValue.ToString();

                // Show input dialog for new value
                string newValue = Prompt.ShowDialog("Modify value (Current: " + currentValue + ")", "Modify Metric Value");

                // Validate new value
                if (!string.IsNullOrWhiteSpace(newValue))
                {
                    // Validate the input value
                    if (!ValidateHealthMetric(metricName, newValue))
                    {
                        return; // Exit if validation fails
                    }

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE healthrecords SET value = @Value WHERE record_id = @RecordID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Value", newValue);
                        command.Parameters.AddWithValue("@RecordID", recordID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Value modified successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No record was updated. Please check the record ID.");
                        }
                    }

                    // Refresh display
                    LoadHealthMetricsFromDatabase();
                }
                else
                {
                    MessageBox.Show("New value cannot be empty. Please enter a valid value.");
                }
            }
            else
            {
                MessageBox.Show("Please select a record to modify.");
            }
        }


        private void healthDataSaveButton_Click(object sender, EventArgs e)
        {
            if (healthMetricsDataGridView.SelectedRows.Count > 0)
            {
                // Ensure column names exist
                if (!healthMetricsDataGridView.Columns.Contains("MetricName") || !healthMetricsDataGridView.Columns.Contains("Value"))
                {
                    MessageBox.Show("Columns 'MetricName' or 'Value' do not exist in the DataGridView. Please check your column definitions.");
                    return;
                }

                // Get the selected row
                DataGridViewRow selectedRow = healthMetricsDataGridView.SelectedRows[0];
                var metricNameValue = selectedRow.Cells["MetricName"].Value;
                var newValueValue = selectedRow.Cells["Value"].Value;

                // Check if column values are empty
                if (metricNameValue == null || string.IsNullOrWhiteSpace(metricNameValue.ToString()) || newValueValue == null || string.IsNullOrWhiteSpace(newValueValue.ToString()))
                {
                    MessageBox.Show("Metric Name or Value is empty. Please provide valid data.");
                    return;
                }

                string metricName = metricNameValue.ToString();
                string newValue = newValueValue.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if matching records exist in the database
                    string queryCheck = "SELECT COUNT(*) FROM healthrecords WHERE metric = @MetricName";
                    SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@MetricName", metricName);

                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        // Update existing records
                        string queryUpdate = @"
                UPDATE healthrecords
                SET value = @Value, date_recorded = @DateRecorded
                WHERE metric = @MetricName";
                        SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                        cmdUpdate.Parameters.AddWithValue("@Value", newValue);
                        cmdUpdate.Parameters.AddWithValue("@DateRecorded", DateTime.Now);
                        cmdUpdate.Parameters.AddWithValue("@MetricName", metricName);

                        cmdUpdate.ExecuteNonQuery();
                        MessageBox.Show("Health metric updated successfully.");
                    }
                    else
                    {
                        // Insert new records
                        string queryInsert = @"
                INSERT INTO healthrecords (metric, value, date_recorded)
                VALUES (@MetricName, @Value, @DateRecorded)";
                        SqlCommand cmdInsert = new SqlCommand(queryInsert, conn);
                        cmdInsert.Parameters.AddWithValue("@MetricName", metricName);
                        cmdInsert.Parameters.AddWithValue("@Value", newValue);
                        cmdInsert.Parameters.AddWithValue("@DateRecorded", DateTime.Now);

                        cmdInsert.ExecuteNonQuery();
                        MessageBox.Show("New health metric added successfully.");
                    }
                }

                // Refresh the DataGridView data
                LoadHealthMetricsFromDatabase();
            }
            else
            {
                MessageBox.Show("Please select a metric in the data grid.");
            }
        }




        // Validates health metric data for specific types like Blood Glucose, Blood Pressure, etc.
        // returns: True if valid, false otherwise.
        private bool ValidateHealthMetric(string metric, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("Value cannot be empty.");
                return false;
            }

            // Trim and standardize the input value
            value = value.Trim();

            try
            {
                switch (metric)
                {
                    case "Blood Glucose":
                        // Add unit if not present
                        if (!value.ToLower().Contains("mg/dl"))
                            value += " mg/dL";

                        var glucoseStr = value.ToLower().Replace("mg/dl", "").Trim();
                        if (int.TryParse(glucoseStr, out int glucose) && glucose >= 60 && glucose <= 190)
                            return true;
                        MessageBox.Show("Blood Glucose must be a number between 60 and 190 mg/dL.");
                        break;

                    case "Blood Pressure":
                        // Add unit if not present
                        if (!value.ToLower().Contains("mmhg"))
                            value += " mmHg";

                        if (System.Text.RegularExpressions.Regex.IsMatch(value, @"^\d{2,3}/\d{2,3}\s*mmHg$", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            string[] parts = value.ToLower().Replace("mmhg", "").Trim().Split('/');
                            if (int.TryParse(parts[0], out int systolic) &&
                                int.TryParse(parts[1], out int diastolic) &&
                                systolic >= 70 && systolic <= 190 &&
                                diastolic >= 40 && diastolic <= 100)
                                return true;
                        }
                        MessageBox.Show("Blood Pressure must be in format '120/80 mmHg' with systolic between 70-190 and diastolic between 40-100.");
                        break;

                    case "Heart Rate":
                        // Add unit if not present
                        if (!value.ToLower().Contains("bpm"))
                            value += " bpm";

                        var heartRateStr = value.ToLower().Replace("bpm", "").Trim();
                        if (int.TryParse(heartRateStr, out int heartRate) && heartRate >= 50 && heartRate <= 190)
                            return true;
                        MessageBox.Show("Heart Rate must be between 50 and 190 bpm.");
                        break;

                    case "Body Temperature":
                        // Add unit if not present
                        if (!value.Contains("°F"))
                            value += "°F";

                        var tempStr = value.Replace("°F", "").Trim();
                        if (double.TryParse(tempStr, out double temp) && temp >= 80 && temp <= 110)
                            return true;
                        MessageBox.Show("Body Temperature must be between 80°F and 110°F.");
                        break;

                    case "Respiratory Rate":
                        // Add unit if not present
                        if (!value.ToLower().Contains("breaths/min"))
                            value += " breaths/min";

                        var respRateStr = value.ToLower().Replace("breaths/min", "").Trim();
                        if (int.TryParse(respRateStr, out int respRate) && respRate >= 8 && respRate <= 30)
                            return true;
                        MessageBox.Show("Respiratory Rate must be between 8 and 30 breaths/min.");
                        break;

                    case "Blood Oxygen":
                        // Add unit if not present
                        if (!value.Contains("%"))
                            value += "%";

                        var oxygenStr = value.Replace("%", "").Trim();
                        if (int.TryParse(oxygenStr, out int oxygen) && oxygen >= 70 && oxygen <= 100)
                            return true;
                        MessageBox.Show("Blood Oxygen must be between 70% and 100%.");
                        break;

                    case "Cholesterol Level":
                        // Add unit if not present
                        if (!value.ToLower().Contains("mg/dl"))
                            value += " mg/dL";

                        var cholesterolStr = value.ToLower().Replace("mg/dl", "").Trim();
                        if (int.TryParse(cholesterolStr, out int cholesterol) && cholesterol >= 80 && cholesterol <= 320)
                            return true;
                        MessageBox.Show("Cholesterol Level must be between 80 and 320 mg/dL.");
                        break;

                    default:
                        // For metrics without specific validation
                        return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid format: {ex.Message}");
                return false;
            }

            return false;
        }

        // Delete the selected metric's record
        private void healthDataDeleteButton_Click(object sender, EventArgs e)
        {
            if (healthMetricsDataGridView.SelectedRows.Count > 0)
            {
                // Check if column names are correct
                if (!healthMetricsDataGridView.Columns.Contains("RecordID"))
                {
                    MessageBox.Show("Column 'RecordID' does not exist in the DataGridView. Please check your column definitions.");
                    return;
                }

                // Retrieve the RecordID value from the selected row
                var recordIDValue = healthMetricsDataGridView.SelectedRows[0].Cells["RecordID"].Value;
                if (recordIDValue == null || string.IsNullOrEmpty(recordIDValue.ToString()))
                {
                    MessageBox.Show("No valid RecordID found for the selected row. Please try again.");
                    return;
                }

                // Ensure RecordID is a string (GUID) and not an integer
                string recordID = recordIDValue.ToString();

                // Confirm deletion
                var confirmationResult = MessageBox.Show("Are you sure you want to delete the selected metric?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmationResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM healthrecords WHERE record_id = @RecordID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@RecordID", recordID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Metric deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No matching record found. Please check the RecordID.");
                        }
                    }

                    // Reload data and refresh the interfac
                    LoadHealthMetricsFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Please select a metric to delete.");
            }
        }



        private void hdrBackButton_Click(object sender, EventArgs e)
        {
            if(UserSession.CurrentUser.IsTech.Equals("true", StringComparison.OrdinalIgnoreCase))
            {
                // Create an instance of the Technician Home form
                technicianHomeForm technicianHome = new technicianHomeForm();

                // Show the Technician Home form
                technicianHome.Show();

                // Close the current (Health Data Record) form
                this.Close();
            }
            else 
            {
                UserHome uh = new UserHome();
                uh.Show();
                this.Close();

            }
        }


        private void healthMetricsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Add other value for a metric
        private void addOther_Click(object sender, EventArgs e)
        {
            if (healthMetricsDataGridView.SelectedRows.Count > 0)
            {
                // Verify column existence
                if (!healthMetricsDataGridView.Columns.Contains("MetricName"))
                {
                    MessageBox.Show("MetricName column not found in DataGridView.");
                    return;
                }

                // Get metric name from selected row
                string metricName = healthMetricsDataGridView.SelectedRows[0].Cells["MetricName"].Value?.ToString();

                if (string.IsNullOrEmpty(metricName))
                {
                    MessageBox.Show("Please select a valid metric from the list.");
                    return;
                }

                // Show input dialog
                string newValue = Prompt.ShowDialog($"Enter value for metric: {metricName}", "Add Metric Value");

                if (!string.IsNullOrWhiteSpace(newValue))
                {
                    // Validate the input value
                    if (!ValidateHealthMetric(metricName, newValue))
                    {
                        return; // Exit if validation fails
                    }

                    try
                    {
                        // Insert into database
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string query = @"
                        INSERT INTO healthrecords (record_id, patient_id, metric, value, date_recorded) 
                        VALUES (NEWID(), @PatientID, @MetricName, @Value, @DateRecorded)";

                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@PatientID", currentPatientID);
                            command.Parameters.AddWithValue("@MetricName", metricName);
                            command.Parameters.AddWithValue("@Value", newValue);
                            command.Parameters.AddWithValue("@DateRecorded", DateTime.Now);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }

                        // Refresh display
                        LoadHealthMetricsFromDatabase();
                        MessageBox.Show("Value added successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while adding the value: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("No value entered. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select a metric in the DataGridView.");
            }
        }


    }


    // Helper class for input dialog
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 20, Top = 60, Width = 340 };
            Button confirmation = new Button() { Text = "OK", Left = 260, Width = 100, Top = 100, DialogResult = DialogResult.OK };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
        }
    }
    // DATA MODELS

    // Represents a single health metric, including its name, value, and the date it was recorded.
    [Serializable]
    // Data model for health metrics
    public class HealthMetric
    {
        public string RecordID { get; set; }
        public string PatientID { get; set; }
        public string MetricName { get; set; }
        public string Value { get; set; }
        public DateTime DateRecorded { get; set; }
    }
}
