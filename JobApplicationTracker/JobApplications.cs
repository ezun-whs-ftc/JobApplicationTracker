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
using static JobApplicationTracker.ApplicationsTracker;
namespace JobApplicationTracker
{
    public partial class JobApplications : Form
    {
        public JobApplications()
        {
            InitializeComponent();
        }

        private void BackToVisualChartBtn_Click(object sender, EventArgs e)
        {
            Constants.navigate(this, new VisualChart());
        }

        private void AddApplicationBtn_Click(object sender, EventArgs e)
        {
            Constants.navigate(this, new Add_Application());
        }

        private void update(Status x)
        {
            switch (x)
            {
                case Status.Rejected:
                    this.listView1.Items.Add(GetApplication(x, NumberOfApplications(x) - 1).GetCompanyName());
                    break;
                case Status.Applied:
                    this.listView1.Items.Add(GetApplication(x, NumberOfApplications(x) - 1).GetCompanyName());
                    break;
                case Status.Interviewed:
                    this.listView1.Items.Add(GetApplication(x, NumberOfApplications(x) - 1).GetCompanyName());
                    break;
                case Status.Offered:
                    this.listView1.Items.Add(GetApplication(x, NumberOfApplications(x) - 1).GetCompanyName());
                    break;
            }
        }

        
    }
}
