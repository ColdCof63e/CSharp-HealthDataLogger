using System; 
using System.Collections.Generic; 
using System.IO; 
using System.Text.Json; 

namespace HealthDataLogger_CSharp
{
    // Class to manage the generation, loading, and saving of patient records
    public class GeneratePatientRecords
    {
        // Generates sample patient records and saves them to a JSON file.
        // This is used for testing or populating the application with initial data.
        public static void GenerateSamplePatientRecords()
        {
            // List to store sample patient records
            List<PatientRecord> patientRecords = new List<PatientRecord>
            {
                // Adding a patient record for "Yipeng Wang"
                new PatientRecord
                {
                    PatientID = 1, // Unique ID for the patient
                    UserName = "Yipeng Wang", // Username for the patient
                    Details = new PatientDetails // Detailed information about the patient
                    {
                        Name = "Yipeng Wang", // Full name of the patient
                        Age = 31, // Age of the patient
                        Gender = "Male", // Gender of the patient
                        BloodType = "O", // Blood type
                        Height = "177 cm", // Height of the patient
                        Weight = "80 kg" // Weight of the patient
                    },
                    CreatedTime = DateTime.Now.AddMonths(-3), // Record creation time (3 months ago)
                    UpdatedTime = DateTime.Now, // Record updated time (now)
                    Status = "Active", // Patient status (active)
                    RecordIDs = new List<int> { 101, 102, 103 } // Associated record IDs for health metrics
                },
                // Adding a patient record for "Narendra"
                new PatientRecord
                {
                    PatientID = 2, 
                    UserName = "Narendra", 
                    Details = new PatientDetails // Detailed information about the patient
                    {
                        Name = "Narendra", 
                        Age = 31, 
                        Gender = "Male", 
                        BloodType = "AB", 
                        Height = "170 cm", 
                        Weight = "65 kg" 
                    },
                    CreatedTime = DateTime.Now.AddMonths(-6), // Record creation time (6 months ago)
                    UpdatedTime = DateTime.Now, // Record updated time (now)
                    Status = "Inactive", // Patient status (inactive)
                    RecordIDs = new List<int> { 201, 202 } // Associated record IDs for health metrics
                }
            };

            // Serialize the patient records list to a JSON string with indented formatting for readability
            string json = JsonSerializer.Serialize(patientRecords, new JsonSerializerOptions { WriteIndented = true });

            // Write the serialized JSON string to a file named "PatientRecords.json"
            File.WriteAllText("PatientRecords.json", json);

            // Notify the user that the JSON file has been generated successfully
            Console.WriteLine("PatientRecords.json generated successfully!");
        }

        // Loads patient records from a JSON file.
        // return a list of patient records.
        public static List<PatientRecord> LoadPatientRecords(string filePath)
        {
            // Check if the JSON file exists
            if (!File.Exists(filePath))
            {
                // Notify the user that the file does not exist
                Console.WriteLine($"File not found: {filePath}");
                // Return an empty list since no data can be loaded
                return new List<PatientRecord>();
            }

            // Read the content of the JSON file
            string json = File.ReadAllText(filePath);

            // Deserialize the JSON content into a list of PatientRecord objects
            // If the JSON file is empty or null, return an empty list instead
            return JsonSerializer.Deserialize<List<PatientRecord>>(json) ?? new List<PatientRecord>();
        }

        // Saves patient records to a JSON file.
        // filePath is the path to save the JSON file.
        // patientRecords is the list of patient records to save.
        public static void SavePatientRecords(string filePath, List<PatientRecord> patientRecords)
        {
            // Serialize the patient records list to a JSON string with indented formatting for readability
            string json = JsonSerializer.Serialize(patientRecords, new JsonSerializerOptions { WriteIndented = true });

            // Write the serialized JSON string to the specified file path
            File.WriteAllText(filePath, json);
        }
    }
}


