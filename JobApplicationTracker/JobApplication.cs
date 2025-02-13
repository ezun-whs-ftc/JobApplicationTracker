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
        private System.DateTime DateApplied;
        private Status status;

        public JobApplication(String companyName, System.DateTime DateApplied)
        {
            this.companyName = companyName;
            this.DateApplied = DateApplied;
            this.status = Status.Applied;
        }
        public void SetStatus(Status x) => this.status = x;
        public Status GetStatus() => this.status;
        public String SetCompanyName(String x) => this.companyName = x;
        public String GetCompanyName() => this.companyName;
        public String SetDateApplied(String x) => this.DateApplied = x;
        public String GetDateApplied() => this.DateApplied;

    }
}
