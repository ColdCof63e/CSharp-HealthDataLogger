using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using HealthDataLogger_CSharp;
using Microsoft.Data.SqlClient;


/*
    * Purpose of patientAccountManagementForm Class:
    * --------------------------------------------------
    * This class represents the Patient Account Management interface, which allows users to search for, 
    * view, and manage patient records. It loads patient data from a JSON file, enables filtered search 
    * functionality, and displays results in a user-friendly interface. It also facilitates navigation 
    * to other modules, such as Technician Home or My Account.
    */

namespace HealthDataLogger_CSharp
{
    public partial class patientAccountManagementForm : Form
    {

        // ATTRIBUTES

        //string connectionString = "Server=MYTHINKPAD\\SQLEXPRESS;Database=HealthDataLogger;Trusted_Connection=True;TrustServerCertificate=True;";
        string connectionString = "Server=COLDCOF63E\\SQLEXPRESS;Database=HealthDataLogger;Integrated Security=True;TrustServerCertificate=True;";

        // Initializes the Patient Account Management form, loading patient records and preparing the UI.
        public patientAccountManagementForm()
        {
            InitializeComponent(); // Initializes the form components.
            //  LoadPatientRecords(); // Loads the patient records from the JSON file.
        }

        /**
        // Loads patient records from the JSON file into the patientRecords list.
        // If the file doesn't exist or an error occurs, an empty list is initialized.
        private void LoadPatientRecords()
        {
            try
            {
                if (File.Exists(PatientFile))
                {
                    string json = File.ReadAllText(PatientFile);
                    patientRecords = JsonSerializer.Deserialize<List<PatientRecord>>(json) ?? new List<PatientRecord>();
                }
                else
                {
                    patientRecords = new List<PatientRecord>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patient records: {ex.Message}");
                patientRecords = new List<PatientRecord>();
            }
        } **/


        // NOT WORKING NOW. Handles the event when the form loads. Populates TreeView nodes with predefined options.
        private void patientAccountManagementForm_Load(object sender, EventArgs e)
        {
            //// Populate the TreeView with nodes
            //TreeNode technicianNode = new TreeNode("Technician Home");
            //TreeNode myAccountNode = new TreeNode("My Account");
            //TreeNode patientHealthNode = new TreeNode("Patient Health Data Management");

            //// Add nodes to the TreeView
            //userAccManTreeView.Nodes.Add(technicianNode);
            //userAccManTreeView.Nodes.Add(myAccountNode);
            //userAccManTreeView.Nodes.Add(patientHealthNode);

            //// Optionally, select the first node by default
            //userAccManTreeView.SelectedNode = technicianNode;

            // Optionally, select the first node by default in the TreeView
            if (userAccManTreeView.Nodes.Count > 0)
            {
                userAccManTreeView.SelectedNode = userAccManTreeView.Nodes[0];
            }

        }

        private void PopulateTreeView()
        {

        }


        private void userAccManMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // Still try finish. Handles TreeView node selection and navigates to different modules.
        private void userAccManTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Technician Home":
                    technicianHomeForm technicianHome = new technicianHomeForm();
                    technicianHome.Show();
                    this.Hide();
                    break;
                case "My Account":
                    MessageBox.Show("My Account functionality will be implemented later.");
                    break;
            }
        }


        private void userAccManGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void patientAccManUNIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void pAMUNIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pAMDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void pAMDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pAMRegionLabel_Click(object sender, EventArgs e)
        {

        }

        private void pAMRegionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Filters patient records based on the search criteria (Patient ID) 
        // and displays the filtered results in the UI.

        // Event handler for the Search button
        private void pAMSearchButton_Click(object sender, EventArgs e)
        {
            string PatientId = pAMUNIDTextBox.Text.Trim(); // Get the input email or PatientID
            LoadUsers(PatientId);
        }

        // Load users from the database and display in DataGridView
        private void LoadUsers(string patientID)
        {
            // Use aliases to ensure database column names match DataGridView column names
            string query = @"
        SELECT 
            email AS PatientID, 
            name AS UserName, 
            phoneNumber AS Phone, 
            address AS Address 
        FROM dbo.users 
        WHERE email LIKE @PatientID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Use parameterized query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@PatientID", "%" + patientID + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to DataGridView
                    pAccMandataGridView.DataSource = dataTable;

                    // Ensure DataGridView column headers are explicitly set
                    FormatDataGridView();
                }
            }
        }

        // Format DataGridView columns
        private void FormatDataGridView()
        {
            pAccMandataGridView.Columns.Clear();

            pAccMandataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Patient ID",
                DataPropertyName = "PatientID",
                Name = "PatientID"
            });
            pAccMandataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "User Name",
                DataPropertyName = "UserName",
                Name = "UserName"
            });
            pAccMandataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Phone",
                DataPropertyName = "Phone",
                Name = "Phone"
            });
            pAccMandataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Address",
                DataPropertyName = "Address",
                Name = "Address"
            });

            pAccMandataGridView.AutoGenerateColumns = false; // Prevent auto-generating columns
        }


        /**
        // Displays search results for a list of PatientRecord objects in the results textbox.
        private void DisplaySearchResults(List<PatientRecord> patients)
        {
            patientAccManResultingTextBox.Clear();

            if (patients.Count == 0)
            {
                patientAccManResultingTextBox.AppendText("No results found.\n");
                return;
            }

            foreach (var patient in patients)
            {
                patientAccManResultingTextBox.AppendText(
                    $"Patient ID: {patient.PatientID}, Name: {patient.Details.Name}, Status: {patient.Status}\n");
            }
        } **/


        // Clears all search filters and resets the UI to its default state.
        // Event handler for the Reset button
        private void pAMResetButton_Click(object sender, EventArgs e)
        {
            // Clear all input fields and reset the DataGridView
            pAMUNIDTextBox.Clear();
            pAMDateTimePicker.Value = DateTime.Now;
            pAMRegionComboBox.SelectedIndex = -1;
            pAccMandataGridView.DataSource = null; // Clear DataGridView
        }

        private void patAccManPIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void patAccManUNLabel_Click(object sender, EventArgs e)
        {

        }

        private void patAccManRoleLabel_Click(object sender, EventArgs e)
        {

        }

        private void patAccManACTlabel_Click(object sender, EventArgs e)
        {

        }

        private void patAccManAUTLabel_Click(object sender, EventArgs e)
        {

        }

        private void patAccManSatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void patAccManOperationLabel_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the Delete button
        private void patAccManResultingDeleteButton_Click(object sender, EventArgs e)
        {
            if (pAccMandataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = pAccMandataGridView.SelectedRows[0];
                string patientID = selectedRow.Cells["PatientID"].Value?.ToString();

                if (!string.IsNullOrEmpty(patientID))
                {
                    // Delete the user and refresh the DataGridView
                    DeleteUser(patientID);
                    LoadUsers(pAMUNIDTextBox.Text.Trim());
                    MessageBox.Show("User deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Selected record does not have a valid Patient ID.");
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }


        // Delete a user from the database
        private void DeleteUser(string patientId)
        {
            // Use the correct column name 'email' instead of 'patient_id'
            string query = "DELETE FROM dbo.users WHERE email = @PatientID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Use parameterized query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    cmd.ExecuteNonQuery();
                }
            }
        }



        /**
        // Helper method to extract Patient ID from the selected text in the TextBox
        // RETURNS: The extracted Patient ID as a string, or null if not found.
        private string ExtractSelectedPatientID()
        {
            // Example logic to parse out the Patient ID from the selected text
            string selectedText = patientAccManResultingTextBox.SelectedText;
            var tokens = selectedText.Split(',');
            var idToken = tokens.FirstOrDefault(t => t.Contains("ID:"));
            return idToken?.Split(':')[1].Trim();
        }
        **/

        /**
        //Not finish yet. Opens the details of a specific patient account based on the provided Patient ID.
        private void OpenPatientAccountDetails(string patientID)
        {
            MessageBox.Show($"Opening details for Patient ID: {patientID}");
            // For future, here we can instantiate the PatientAccountDetails form
            // PatientAccountDetailsForm detailsForm = new PatientAccountDetailsForm(patientID);
            // detailsForm.ShowDialog();
        }
        **/

        private void patientAccManResultingTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pAccMandataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pAccManBackButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the Technician Home form
            technicianHomeForm technicianHome = new technicianHomeForm();

            // Show the Technician Home form
            technicianHome.Show();

            // Close the current (Health Data Record) form
            this.Close();
        }
    }

    // DATA MODELS

    // Represents a patient's account information, including ID, username, role, and related metadata.
    public class PatientAccount
    {
        public int PatientID { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string Status { get; set; }
        public string Region { get; set; }
    }

}
