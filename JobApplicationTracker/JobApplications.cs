﻿using System;
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
    public partial class JobApplications : Form
    {
        public JobApplications()
        {
            InitializeComponent();
        }

        private void BackToVisualChartBtn_Click(object sender, EventArgs e)
        {
            Pages.navigate(this, "Visualchart");
        }

        private void AddApplicationBtn_Click(object sender, EventArgs e)
        {
            Pages.navigate(this, "AddApplication");
        }
    }
}
