using HealthDataLogger_CSharp.utils;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace HealthDataLogger_CSharp.database
{
    internal class DatabaseCommunication
    {
        private static SqlConnection connection = DatabaseConnection.Instance.GetConnection();

        // Method to insert data into the table
        public static void InsertData(string email, string password, string name, string isTech, string phoneNumber,
                               string height, string weight, string address, string gender, string bloodType, DateTime dob)
        {
            string insertQuery = "INSERT INTO users (email, password, name, isTech, phoneNumber, height, weight, address, gender, bloodType, dob) " +
                                 "VALUES (@Email, @Password, @Name, @IsTech, @PhoneNumber, @Height, @Weight, @Address, @Gender, @BloodType, @Dob)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    // Adding parameters
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@IsTech", isTech);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Height", height);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@BloodType", bloodType);
                    cmd.Parameters.AddWithValue("@Dob", dob);

                    // Execute the command (INSERT query)
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Data successfully inserted!");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error while inserting data: " + e.Message);
            }
        }

        // Method to read data from the database
        public static List<Credentials> ReadData()
        {
            List<Credentials> credentialsList = new List<Credentials>();
            string selectQuery = "SELECT * FROM users";

            try
            {
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string email = reader.GetString(0);
                            string password = reader.GetString(1);
                            string name = reader.GetString(2);
                            string isTech = reader.GetString(3);
                            string phoneNumber = reader.GetString(4);
                            int height = reader.GetInt32(5);
                            int weight = reader.GetInt32(6);
                            string address = reader.GetString(7);
                            string gender = reader.GetString(8);
                            string bloodType = reader.GetString(9);
                            DateTime dob = reader.GetDateTime(10);

                            // Now passing all required parameters to the Credentials constructor
                            credentialsList.Add(new Credentials(email, password, name, isTech, phoneNumber,
                                height, weight, address, gender, bloodType, dob));
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return credentialsList;
        }

        // Method to update the password of a user
        public static Boolean UpdatePassword(string email, string newPassword)
        {
            string updatePasswordQuery = "UPDATE users SET password = @Password WHERE email = @Email";

            try
            {
                using (SqlCommand cmd = new SqlCommand(updatePasswordQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Email", email);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Password Successfully Reset!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Password Failed To Reset!");
                        return false;
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public static List<HealthMetricData> GetHealthMetrics(string patientEmail)
        {
            List<HealthMetricData> healthMetrics = new List<HealthMetricData>();
            string query = "SELECT record_id, patient_id, metric, value, date_recorded FROM healthrecords WHERE patient_id = @PatientEmail";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PatientEmail", patientEmail);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            healthMetrics.Add(new HealthMetricData
                            {
                                RecordID = reader["record_id"].ToString(),
                                PatientID = reader["patient_id"].ToString(),
                                MetricName = reader["metric"].ToString(),
                                Value = reader["value"].ToString(),
                                DateRecorded = reader["date_recorded"] != DBNull.Value ? Convert.ToDateTime(reader["date_recorded"]) : DateTime.MinValue
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error fetching health metrics: {ex.Message}");
            }
            return healthMetrics;
        }

        // Method to update user data in the database
        public static bool UpdateUserDataInDatabase(string email, string name, string phoneNumber,
                                                     int height, int weight, string address,
                                                     string gender, string bloodType, DateTime dob)
        {
            string updateQuery = "UPDATE users SET " +
                                 "name = @Name, " +
                                 "phoneNumber = @PhoneNumber, " +
                                 "height = @Height, " +
                                 "weight = @Weight, " +
                                 "address = @Address, " +
                                 "gender = @Gender, " +
                                 "bloodType = @BloodType, " +
                                 "dob = @Dob " +
                                 "WHERE email = @Email";

            try
            {
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    // Adding parameters
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Height", height);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@BloodType", bloodType);
                    cmd.Parameters.AddWithValue("@Dob", dob);
                    cmd.Parameters.AddWithValue("@Email", email);

                    // Execute the command (UPDATE query)
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if the update was successful
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("User data successfully updated!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("User data update failed!");
                        return false;
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error while updating data: " + e.Message);
                return false;
            }
        }
    }
}
