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
using static JobApplicationTracker.Constants;
namespace JobApplicationTracker
{
    public partial class VisualChart : Form
    {
        private Status Which;
        JobApplicationService service = new JobApplicationService();
        public VisualChart()
        {
            InitializeComponent();
            VisualChart_Load();
        }
        private void VisualChart_Load()
        {
            // TODO: This line of code loads data into the 'jobApplicationDataSet.JobApplication' table. You can move, or remove it, as needed.
            this.jobApplicationTableAdapter.Fill(this.jobApplicationDataSet.JobApplication);
            this.chart1.Series["Applications"].Points.Clear();
            

            this.chart1.Series["Applications"].Points.AddXY("Rejected", service.GetJobApplicationsByStatus(Constants.Status.Rejected).Count);
            this.chart1.Series["Applications"].Points.AddXY("Applied", service.GetJobApplicationsByStatus(Constants.Status.Applied).Count);
            this.chart1.Series["Applications"].Points.AddXY("Interviewed", service.GetJobApplicationsByStatus(Constants.Status.Interviewed).Count);
            this.chart1.Series["Applications"].Points.AddXY("Offered", service.GetJobApplicationsByStatus(Constants.Status.Offered).Count);
        }

        private void BackToHomePageBtn_Click(object sender, EventArgs e)
        {
            Constants.navigate(this, new Form1() );
        }

        private void GoToJobApplicationsBtn_Click(object sender, EventArgs e)
        {
            Constants.navigate(this, new JobApplicationsView(Which));
        }

        private void RejectedOptionBtn_Click(object sender, EventArgs e)
        {
            Which = Status.Rejected;
        }

        private void AppliedOptionBtn_Click(object sender, EventArgs e)
        {
            Which = Status.Applied;
        }

        private void InterviewedOptionBtn_Click(object sender, EventArgs e)
        {
            Which = Status.Interviewed;
        }

        private void OfferedOptionBtn_Click(object sender, EventArgs e)
        {
            Which = Status.Offered;
        }


        
    }
}
