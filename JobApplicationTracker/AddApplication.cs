using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ApplicationsTracker.applications.Add
            (
                new JobApplication(textBox1.Text, dateTimePicker1.Value)
            );
        }

        private void BackToJobApplicationBtn_Click(object sender, EventArgs e)
        {
            Pages.navigate(this, "JobApplications");
        }

    }
}
