using JobApplicationTracker.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
            // Gets and builds the application path of the database location
            string basePath = CurrentPath.GetDbasePath() + "\\";
            string dbName = DbaseNames.JobApplicationDBase;
            string path = Path.Combine(basePath, dbName);

            // Gets the connection string from App.config
            string dbase = ConfigurationManager.ConnectionStrings["AccessDBOleDB"].ConnectionString;
            string cs = string.Format(dbase,path);

            _connectionString = cs;
        }

        public void AddJobApplication(JobApplication jobApplication)
        {
            try
            {
                using (var connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    var query = "INSERT INTO JobApplication (CompanyName, DateApplied, Status) VALUES (@CompanyName, @DateApplied, @Status)";
                    using (var command = new OleDbCommand(query, connection))
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
                Console.WriteLine($"[Add] Error: {ex.Message}");
            }
        }

        public List<JobApplication> GetJobApplications()
        {
            var jobApplications = new List<JobApplication>();
            try
            {
                using (var connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM JobApplication";
                    using (var command = new OleDbCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                jobApplications.Add(new JobApplication
                                (
                                    //Convert.ToInt32(reader["Id"]),
                                    reader["CompanyName"].ToString(),
                                    Convert.ToDateTime(reader["DateApplied"]),
                                    convertStringToStatus(reader["Status"].ToString())
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetAll] Error: {ex.Message}");
            }
            return jobApplications;
        }

        public JobApplication GetJobApplicationById(int id)
        {
            JobApplication jobApplication = null;
            try
            {
                using (var connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM JobApplication WHERE Id = @Id";
                    using (var command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                jobApplication = new JobApplication
                                (
                                   // Id = Convert.ToInt32(reader["Id"]),
                                    reader["CompanyName"].ToString(),
                                    Convert.ToDateTime(reader["DateApplied"]),
                                    convertStringToStatus(reader["Status"].ToString())
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetById] Error: {ex.Message}");
            }
            return jobApplication;
        }

        public void UpdateJobApplication(JobApplication jobApplication)
        {
            try
            {
                using (var connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    var query = "UPDATE JobApplication SET CompanyName = @CompanyName, DateApplied = @DateApplied, Status = @Status WHERE Id = @Id";
                    using (var command = new OleDbCommand(query, connection))
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
                Console.WriteLine($"[Update] Error: {ex.Message}");
            }
        }

        public void DeleteJobApplication(int id)
        {
            try
            {
                using (var connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    var query = "DELETE FROM JobApplication WHERE Id = @Id";
                    using (var command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Delete] Error: {ex.Message}");
            }
        }

        public List<JobApplication> GetJobApplicationsByStatus(Status status)
        {
            var jobApplications = new List<JobApplication>();
            try
            {
                using (var connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM JobApplication WHERE Status = @Status";
                    using (var command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", (int)status);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                jobApplications.Add(new JobApplication
                                (
                                    //Id = Convert.ToInt32(reader["Id"]),
                                    reader["CompanyName"].ToString(),
                                    Convert.ToDateTime(reader["DateApplied"]),
                                    convertStringToStatus(reader["Status"].ToString())
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetByStatus] Error: {ex.Message}");
            }
            return jobApplications;
        }
    }
}
