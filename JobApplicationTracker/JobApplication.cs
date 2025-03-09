using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static JobApplicationTracker.Constants;
using System.ComponentModel.DataAnnotations;
namespace JobApplicationTracker
{
    class JobApplication
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime DateApplied { get; set; }
        public Status Status { get; set; }
        public JobApplication() { }

        public JobApplication(string companyName, DateTime dateApplied, Status status)
        {
            CompanyName = companyName;
            DateApplied = dateApplied;
            Status = status;
        }

    }
}
