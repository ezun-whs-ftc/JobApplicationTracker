
using static JobApplicationTracker.Constants;
namespace JobApplicationTracker
{
    partial class VisualChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OfferedOptionBtn = new System.Windows.Forms.Button();
            this.InterviewedOptionBtn = new System.Windows.Forms.Button();
            this.AppliedOptionBtn = new System.Windows.Forms.Button();
            this.RejectedOptionBtn = new System.Windows.Forms.Button();
            this.BackToHomePageBtn = new System.Windows.Forms.Button();
            this.GoToJobApplicationsBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.jobApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobApplicationDataSet = new JobApplicationTracker.JobApplicationDataSet();
            this.jobApplicationTableAdapter = new JobApplicationTracker.JobApplicationDataSetTableAdapters.JobApplicationTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobApplicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobApplicationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OfferedOptionBtn);
            this.panel1.Controls.Add(this.InterviewedOptionBtn);
            this.panel1.Controls.Add(this.AppliedOptionBtn);
            this.panel1.Controls.Add(this.RejectedOptionBtn);
            this.panel1.Location = new System.Drawing.Point(429, 465);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 74);
            this.panel1.TabIndex = 0;
            // 
            // OfferedOptionBtn
            // 
            this.OfferedOptionBtn.Location = new System.Drawing.Point(112, 39);
            this.OfferedOptionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.OfferedOptionBtn.Name = "OfferedOptionBtn";
            this.OfferedOptionBtn.Size = new System.Drawing.Size(100, 28);
            this.OfferedOptionBtn.TabIndex = 3;
            this.OfferedOptionBtn.Text = "Offered";
            this.OfferedOptionBtn.UseVisualStyleBackColor = true;
            this.OfferedOptionBtn.Click += new System.EventHandler(this.OfferedOptionBtn_Click);
            // 
            // InterviewedOptionBtn
            // 
            this.InterviewedOptionBtn.Location = new System.Drawing.Point(4, 39);
            this.InterviewedOptionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.InterviewedOptionBtn.Name = "InterviewedOptionBtn";
            this.InterviewedOptionBtn.Size = new System.Drawing.Size(100, 28);
            this.InterviewedOptionBtn.TabIndex = 2;
            this.InterviewedOptionBtn.Text = "Interviewed";
            this.InterviewedOptionBtn.UseVisualStyleBackColor = true;
            this.InterviewedOptionBtn.Click += new System.EventHandler(this.InterviewedOptionBtn_Click);
            // 
            // AppliedOptionBtn
            // 
            this.AppliedOptionBtn.Location = new System.Drawing.Point(112, 4);
            this.AppliedOptionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AppliedOptionBtn.Name = "AppliedOptionBtn";
            this.AppliedOptionBtn.Size = new System.Drawing.Size(100, 28);
            this.AppliedOptionBtn.TabIndex = 1;
            this.AppliedOptionBtn.Text = "Applied";
            this.AppliedOptionBtn.UseVisualStyleBackColor = true;
            this.AppliedOptionBtn.Click += new System.EventHandler(this.AppliedOptionBtn_Click);
            // 
            // RejectedOptionBtn
            // 
            this.RejectedOptionBtn.Location = new System.Drawing.Point(4, 4);
            this.RejectedOptionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RejectedOptionBtn.Name = "RejectedOptionBtn";
            this.RejectedOptionBtn.Size = new System.Drawing.Size(100, 28);
            this.RejectedOptionBtn.TabIndex = 0;
            this.RejectedOptionBtn.Text = "Rejected";
            this.RejectedOptionBtn.UseVisualStyleBackColor = true;
            this.RejectedOptionBtn.Click += new System.EventHandler(this.RejectedOptionBtn_Click);
            // 
            // BackToHomePageBtn
            // 
            this.BackToHomePageBtn.Location = new System.Drawing.Point(16, 480);
            this.BackToHomePageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackToHomePageBtn.Name = "BackToHomePageBtn";
            this.BackToHomePageBtn.Size = new System.Drawing.Size(144, 59);
            this.BackToHomePageBtn.TabIndex = 1;
            this.BackToHomePageBtn.Text = "Back to home page";
            this.BackToHomePageBtn.UseVisualStyleBackColor = true;
            this.BackToHomePageBtn.Click += new System.EventHandler(this.BackToHomePageBtn_Click);
            // 
            // GoToJobApplicationsBtn
            // 
            this.GoToJobApplicationsBtn.Location = new System.Drawing.Point(907, 480);
            this.GoToJobApplicationsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GoToJobApplicationsBtn.Name = "GoToJobApplicationsBtn";
            this.GoToJobApplicationsBtn.Size = new System.Drawing.Size(144, 59);
            this.GoToJobApplicationsBtn.TabIndex = 2;
            this.GoToJobApplicationsBtn.Text = "Go to job applications";
            this.GoToJobApplicationsBtn.UseVisualStyleBackColor = true;
            this.GoToJobApplicationsBtn.Click += new System.EventHandler(this.GoToJobApplicationsBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 423);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1067, 12);
            this.progressBar1.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 13);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Applications";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1067, 410);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // jobApplicationBindingSource
            // 
            this.jobApplicationBindingSource.DataMember = "JobApplication";
            this.jobApplicationBindingSource.DataSource = this.jobApplicationDataSet;
            // 
            // jobApplicationDataSet
            // 
            this.jobApplicationDataSet.DataSetName = "JobApplicationDataSet";
            this.jobApplicationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobApplicationTableAdapter
            // 
            this.jobApplicationTableAdapter.ClearBeforeFill = true;
            // 
            // VisualChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.GoToJobApplicationsBtn);
            this.Controls.Add(this.BackToHomePageBtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisualChart";
            this.Text = "VisualChart";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobApplicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobApplicationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OfferedOptionBtn;
        private System.Windows.Forms.Button InterviewedOptionBtn;
        private System.Windows.Forms.Button AppliedOptionBtn;
        private System.Windows.Forms.Button RejectedOptionBtn;
        private System.Windows.Forms.Button BackToHomePageBtn;
        private System.Windows.Forms.Button GoToJobApplicationsBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private JobApplicationDataSet jobApplicationDataSet;
        private System.Windows.Forms.BindingSource jobApplicationBindingSource;
        private JobApplicationDataSetTableAdapters.JobApplicationTableAdapter jobApplicationTableAdapter;
    }
}