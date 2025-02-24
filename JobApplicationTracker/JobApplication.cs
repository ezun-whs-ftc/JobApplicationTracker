using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static JobApplicationTracker.Constants;
namespace JobApplicationTracker
{
    class JobApplication
    {
        private String companyName;
        private DateTime DateApplied;
        private Status status;

        public JobApplication(String companyName, DateTime DateApplied,Status status)
        {
            this.companyName = companyName;
            this.DateApplied = DateApplied;
            this.status = status;
        }
        public void SetStatus(Status x) => this.status = x;
        public Status GetStatus() => this.status;
        public void SetCompanyName(String x) => this.companyName = x;
        public String GetCompanyName() => this.companyName;
        public void SetDateApplied(DateTime x) => this.DateApplied = x;
        public DateTime GetDateApplied() => this.DateApplied;

    }
}
