using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JobApplicationTracker
{
    public partial class VisualChart : Form
    {
        public VisualChart()
        {
            InitializeComponent();
        }

        private void BackToHomePageBtn_Click(object sender, EventArgs e)
        {
            Pages.navigate(this, "Form1");
        }

        private void GoToJobApplicationsBtn_Click(object sender, EventArgs e)
        {
            Pages.navigate(this, "JobApplications");
        }

        private void RejectedOptionBtn_Click(object sender, EventArgs e)
        {

        }

        private void AppliedOptionBtn_Click(object sender, EventArgs e)
        {

        }

        private void InterviewedOptionBtn_Click(object sender, EventArgs e)
        {

        }

        private void OfferedOptionBtn_Click(object sender, EventArgs e)
        {

        }

       
    }
}
