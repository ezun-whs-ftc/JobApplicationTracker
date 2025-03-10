using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using static JobApplicationTracker.Constants;
namespace JobApplicationTracker
{
     class JobApplicationService
    {
        public void AddJobApplication(JobApplication jobApplication)
        {
            try
            {
                using (var context = new JobApplicationContext())
                {
                    context.JobApplications.Add(jobApplication);
                    context.SaveChanges();
                }
            }
            catch (DbEntityValidationException ex)
            {
                // Handle validation errors
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                // Handle database update errors
                Console.WriteLine($"An error occurred while updating the database: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle all other errors
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public List<JobApplication> GetJobApplications()
        {
            try
            {
                using (var context = new JobApplicationContext())
                {
                    return context.JobApplications.ToList();
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<JobApplication>();
            }
        }

        public JobApplication GetJobApplicationById(int id)
        {
            try
            {
                using (var context = new JobApplicationContext())
                {
                    return context.JobApplications.FirstOrDefault(ja => ja.Id == id);
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        public void UpdateJobApplication(JobApplication jobApplication)
        {
            try
            {
                using (var context = new JobApplicationContext())
                {
                    var existingJobApplication = context.JobApplications.FirstOrDefault(ja => ja.Id == jobApplication.Id);
                    if (existingJobApplication != null)
                    {
                        existingJobApplication.CompanyName = jobApplication.CompanyName;
                        existingJobApplication.DateApplied = jobApplication.DateApplied;
                        existingJobApplication.Status = jobApplication.Status;
                        context.SaveChanges();
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                // Handle database update errors
                Console.WriteLine($"An error occurred while updating the database: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle all other errors
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void DeleteJobApplication(int id)
        {
            try
            {
                using (var context = new JobApplicationContext())
                {
                    var jobApplication = context.JobApplications.FirstOrDefault(ja => ja.Id == id);
                    if (jobApplication != null)
                    {
                        context.JobApplications.Remove(jobApplication);
                        context.SaveChanges();
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                // Handle database update errors
                Console.WriteLine($"An error occurred while updating the database: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle all other errors
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public List<JobApplication> GetJobApplicationsByStatus(Status status)
        {
            try
            {
                using (var context = new JobApplicationContext())
                {
                    return context.JobApplications.Where(ja => ja.Status == status).ToList();
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<JobApplication>();
            }
        }
    }
}
