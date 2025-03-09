using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JobApplicationTracker.Constants.readOnly;
using static JobApplicationTracker.Constants;
using System.Security.Authentication.ExtendedProtection.Configuration;
namespace JobApplicationTracker

{
    public partial class ApplicationView : Form
    {
        private int count = 0;
        public ApplicationView()
        {
            InitializeComponent();
            LoadJobApplications();
        }

        private void BackToJobApplicationsBtn_Click(object sender, EventArgs e)
        {
            Constants.navigate(this, new JobApplications());
        }

        private void EditJobApplicationBtn_Click(object sender, EventArgs e)
        {
            bool isReadOnly = Constants.readOnly.getReadOnly();

            if (isReadOnly && count%2 == 0)
            {
                JobApplicationService service = new JobApplicationService();
                service.UpdateJobApplication( new JobApplication(textBox1.Text,dateTimePicker1.Value,AddStatus()));
            }
            Constants.readOnly.setReadOnly();
        }
        private void LoadJobApplications()
        {
            JobApplicationService service = new JobApplicationService();
            textBox1.Text= service.GetJobApplications().CompanyName;
        }

        private Status AddStatus()
        {
            if (RejectedBtn.Checked)
            {
                return Status.Rejected;
            }
            else if (InterviewedBtn.Checked)
            {
                return Status.Interviewed;
            }
            else if (OfferedBtn.Checked)
            {
                return Status.Offered;
            }
            else
            {
                return Status.Applied;
            }
        }

        
    }
}

