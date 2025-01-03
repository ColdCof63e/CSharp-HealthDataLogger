using HealthDataLogger_CSharp.utils;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

/*
 * Purpose of technicianHomeForm:
 * --------------------------------
 * This class represents the main interface for technicians in the Health Data Logger system. 
 * It provides functionalities to manage and search for patient records and acts as a gateway to 
 * other related features like Patient Account Management and Health Data Records. The form is 
 * designed to allow technicians to interact with the patient data stored in a JSON file, perform
 * actions such as searching for patient details, viewing associated health data, and navigating 
 * to other modules. The class encapsulates the logic for data loading, filtering, and saving,
 * ensuring that patient data is easily accessible and modifiable while maintaining a user-friendly 
 * interface.
 */


namespace HealthDataLogger_CSharp
{
    // The Technician Home form class, used to handle events and manage patient records
    public partial class technicianHomeForm : Form
    {
        //string connectionString = "Server=MYTHINKPAD\\SQLEXPRESS;Database=HealthDataLogger;Trusted_Connection=True;TrustServerCertificate=True;";
        string connectionString = "Server=COLDCOF63E\\SQLEXPRESS;Database=HealthDataLogger;Integrated Security=True;TrustServerCertificate=True;";
        // List to store patient records
        //private List<PatientRecord> patientRecords;
        // File name where patient records are stored in JSON format
        //private const string PatientFile = "PatientRecords.json";

        // Constructor for the Technician Home form
        public technicianHomeForm()
        {
            InitializeComponent(); // Initialize the form components
            //LoadPatientRecords(); // Load patient records from the JSON file
        }

        // Event triggered when the form loads
        private void technicianHomeForm_Load(object sender, EventArgs e)
        {
            // Automatically select the first node in the TreeView on form load
            if (techHomeTreeView.Nodes.Count > 0)
            {
                techHomeTreeView.SelectedNode = techHomeTreeView.Nodes[0];
            }
        }

        /**
        // Method to load patient records from a JSON file
        private void LoadPatientRecords()
        {
            try
            {
                if (File.Exists(PatientFile)) // Check if the JSON file exists
                {
                    // Read the content of the JSON file
                    string json = File.ReadAllText(PatientFile);
                    // Deserialize the JSON content into a list of PatientRecord objects
                    patientRecords = JsonSerializer.Deserialize<List<PatientRecord>>(json) ?? new List<PatientRecord>();
                }
                else
                {
                    // If the file doesn't exist, initialize an empty list
                    patientRecords = new List<PatientRecord>();
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"Error loading patient records: {ex.Message}");
                // Initialize an empty list in case of an error
                patientRecords = new List<PatientRecord>();
            }
        } **/

        /**
        // Method to save patient records back to the JSON file
        private void SavePatientRecords()
        {
            try
            {
                // Serialize the list of patient records to JSON format
                string json = JsonSerializer.Serialize(patientRecords);
                // Write the serialized JSON content to the file
                File.WriteAllText(PatientFile, json);
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"Error saving patient records: {ex.Message}");
            }
        } **/

        // Event handler for selecting a node in the TreeView
        private void techHomeTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Patient Account Management":
                    // Open the Patient Account Management form
                    patientAccountManagementForm patientAccountForm = new patientAccountManagementForm();
                    patientAccountForm.Show(); // Show the new form
                    this.Hide(); // Hide the current form
                    break;
                case "My Account":
                    // Placeholder for future implementation
                    //MessageBox.Show("My Account functionality will be implemented later.");
                    MyAccount myacc = new MyAccount();
                    myacc.Show();
                    this.Hide();
                    break;
            }
        }

        // Event handler for the search button in Technician Home
        private void techHomeSearchButton_Click(object sender, EventArgs e)
        {
            string PatientID = userNameOrIDTextBox.Text.Trim(); // Get the Patient ID from the text box
            if (!string.IsNullOrWhiteSpace(PatientID))
            {
                LoadHealthRecords(PatientID);
            }
            else
            {
                MessageBox.Show("Please enter a valid Patient ID.");
            }
        }

        // Event handler for the reset button
        private void techHomeResetButton_Click(object sender, EventArgs e)
        {
            // Clear input fields and reset DataGridView
            userNameOrIDTextBox.Clear();
            techHomeGenderComboBox.SelectedIndex = -1; // Deselect any selected gender
            dateTimePicker1.Value = DateTime.Now; // Reset date picker to current date
            thDataGridView.DataSource = null; // Clear the DataGridView
        }

        // Event handler for the "View" button
        private void thResultViewButton_Click(object sender, EventArgs e)
        {
            if (thDataGridView.SelectedRows.Count > 0)
            {
                // Access the "patient_id" column from the selected row
                DataGridViewRow selectedRow = thDataGridView.SelectedRows[0];
                string PatientID = selectedRow.Cells["patient_id"].Value?.ToString();

                if (!string.IsNullOrEmpty(PatientID))
                {
                    // Open the Health Data Record form and pass the PatientID
                    healthDataRecordForm healthDataRecord = new healthDataRecordForm(PatientID);
                    healthDataRecord.Show();
                    this.Hide(); // Hide the current form
                }
                else
                {
                    MessageBox.Show("No valid Patient ID found in the selected row.");
                }
            }
            else
            {
                MessageBox.Show("Please select a record to view.");
            }
        }


        // Event handler for the menu strip item click (currently unused)
        private void thMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Placeholder for handling menu item clicks
        }

        // Event handler triggered when the Technician Home form is closing
        private void TechnicianHomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the patient records before closing the form
            //SavePatientRecords();
            Application.Exit();
        }

        private void thSearchingResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Load health records from the database and display in DataGridView
        private void LoadHealthRecords(string PatientID)
        {
            string query = "SELECT record_ID, patient_id, metric, value FROM dbo.healthrecords WHERE patient_id = @PatientID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Explicitly map columns to the DataGridView
                    thDataGridView.AutoGenerateColumns = false;
                    thDataGridView.Columns.Clear();

                    // Add columns with correct names
                    thDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Record ID", DataPropertyName = "record_ID", Name = "record_ID" });
                    thDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Patient ID", DataPropertyName = "patient_id", Name = "patient_id" });
                    thDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Metric", DataPropertyName = "metric", Name = "metric" });
                    thDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Value", DataPropertyName = "value", Name = "value" });

                    thDataGridView.DataSource = dataTable; // Bind data to DataGridView
                }
            }
        }

        // logout to login interface
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide the current technician home form
                this.Hide();

                // Clear current user session
                UserSession.CurrentUser = null;

                // Create and show new login form
                Login loginForm = new Login();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.MaximizeBox = false;
                loginForm.Show();

                // Close the current form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during logout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Class representing a patient record
    public class PatientRecord
    {
        public int PatientID { get; set; } // Unique identifier for the patient
        public string UserName { get; set; } 
        public PatientDetails Details { get; set; } // Detailed information about the patient
        public DateTime CreatedTime { get; set; } // When the patient record was created
        public DateTime UpdatedTime { get; set; } 
        public string Status { get; set; }
        public List<int> RecordIDs { get; set; } // IDs of associated health metrics records
    }
}

