using JobApplicationTracker.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using static JobApplicationTracker.Models.DbaseNames;
using static JobApplicationTracker.Constants;

namespace JobApplicationTracker
{
    class JobApplicationService
    {
        private readonly string _connectionString;

        public JobApplicationService()
        {
            
                //Gets and Builds the Application Path of the applicatino location
                string basePath = CurrentPath.GetDbasePath() + "\\";
                //Gets name of the database
                string dbName = DbaseNames.JobApplicationDBase;
                //Combines the Path with the Database
                string path = Path.Combine(basePath, dbName); // Safely combines paths

                //Gets the Connection String from the App.Config file
                string dbase = ConfigurationManager.ConnectionStrings["AccessDbODBC"].ConnectionString;

                //Replaces {0} and {1} with correct values
                string cs = string.Format(dbase, DbaseNames.LabDriver, path);

                //Connection String we will use
                _connectionString = cs;
            
        }

        public void AddJobApplication(JobApplication jobApplication)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "INSERT INTO JobApplications (CompanyName, DateApplied, Status) VALUES (@CompanyName, @DateApplied, @Status)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CompanyName", jobApplication.CompanyName);
                        command.Parameters.AddWithValue("@DateApplied", jobApplication.DateApplied);
                        command.Parameters.AddWithValue("@Status", jobApplication.Status);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public List<JobApplication> GetJobApplications()
        {
            var jobApplications = new List<JobApplication>();
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM JobApplications";
                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                jobApplications.Add(new JobApplication
                                {
                                    Id = reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetDateTime(2),
                                    (Status)reader.GetInt32(3)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return jobApplications;
        }

        public JobApplication GetJobApplicationById(int id)
        {
            JobApplication jobApplication = null;
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM JobApplications WHERE Id = @Id";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                jobApplication = new JobApplication
                                {
                                    Id = reader.GetInt32(0),
                                    CompanyName = reader.GetString(1),
                                    DateApplied = reader.GetDateTime(2),
                                    Status = (Status) reader.GetString(3)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return jobApplication;
        }

        public void UpdateJobApplication(JobApplication jobApplication)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "UPDATE JobApplications SET CompanyName = @CompanyName, DateApplied = @DateApplied, Status = @Status WHERE Id = @Id";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CompanyName", jobApplication.CompanyName);
                        command.Parameters.AddWithValue("@DateApplied", jobApplication.DateApplied);
                        command.Parameters.AddWithValue("@Status", jobApplication.Status);
                        command.Parameters.AddWithValue("@Id", jobApplication.Id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void DeleteJobApplication(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "DELETE FROM JobApplications WHERE Id = @Id";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public List<JobApplication> GetJobApplicationsByStatus(Status status)
        {
            var jobApplications = new List<JobApplication>();
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM JobApplications WHERE Status = @Status";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", status);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                jobApplications.Add(new JobApplication
                                {
                                    Id = reader.GetInt32(0),
                                    CompanyName = reader.GetString(1),
                                    DateApplied = reader.GetDateTime(2),
                                    Status = (Status)reader.GetString(3)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return jobApplications;
        }
    }
}
