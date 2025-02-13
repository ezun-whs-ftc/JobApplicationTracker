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
    }
}
