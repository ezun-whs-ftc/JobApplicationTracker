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
    public partial class JobApplicationsView : Form
    {
        private JobApplicationService service = new JobApplicationService();
        private Status status;
        public JobApplicationsView(Status x)
        {
            InitializeComponent();
            status = x;
            LoadAndSortJobApplications(status);
            listView1.ItemActivate += new EventHandler(listView1_ItemActivate);
        }

        private void BackToVisualChartBtn_Click(object sender, EventArgs e)
        {
            Constants.navigate(this, new VisualChart());
        }

        private void AddApplicationBtn_Click(object sender, EventArgs e)
        {
            Constants.navigate(this, new Add_Application());
        }
        public void listView1_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            Constants.Equals(this, new ApplicationView(
                item.SubItems[2].ToString(), item.SubItems[0].ToString(), item.SubItems[1].ToString()));
        }
        private void LoadAndSortJobApplications(Status x)
        {
            var jobApplications = service.GetJobApplicationsByStatus(x);
            BubbleSort(jobApplications);
            DisplayJobApplications(jobApplications);
        }

        private void BubbleSort(List<JobApplication> jobApplications)
        {
            int n = jobApplications.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (jobApplications[j].DateApplied > jobApplications[j + 1].DateApplied)
                    {
                        // Swap jobApplications[j] and jobApplications[j + 1]
                        var temp = jobApplications[j];
                        jobApplications[j] = jobApplications[j + 1];
                        jobApplications[j + 1] = temp;
                    }
                }
            }
        }

        private void DisplayJobApplications(List<JobApplication> jobApplications)
        {
            listView1.Items.Clear();
            foreach (var jobApplication in jobApplications)
            {
                var listViewItem = new ListViewItem(jobApplication.CompanyName);
                listViewItem.SubItems.Add(jobApplication.CompanyName);
                listViewItem.SubItems.Add(jobApplication.DateApplied.ToString("yyyy-MM-dd HH:mm:ss"));
                listViewItem.SubItems.Add(jobApplication.Status.ToString());
                listView1.Items.Add(listViewItem);
            }
        }
    }
}
