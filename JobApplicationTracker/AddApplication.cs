using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JobApplicationTracker.Constants;
namespace JobApplicationTracker
{
    public partial class Add_Application : Form
    {
        public Add_Application()
        {
            InitializeComponent();
        }


        private void AddApplicationBtn_Click(object sender, EventArgs e)
        {
            ApplicationsTracker.AddApplication(new JobApplication(textBox1.Text, dateTimePicker1.Value,AddStatus()));
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void BackToJobApplicationBtn_Click(object sender, EventArgs e)
        {
            Constants.navigate(this, new JobApplications());
        }

        private Status AddStatus()
        {
            if (RejectedStatusBtn.Checked)
            {
                return Status.Rejected;
            } else if(InterviewedStatusBtn.Checked)
            {
                return Status.Interviewed;
            } else if (OfferedStatusBtn.Checked)
            {
                return Status.Offered;
            } else
            {
                return Status.Applied;
            }
        }
    }
}
