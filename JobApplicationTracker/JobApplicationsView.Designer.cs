﻿
namespace JobApplicationTracker
{
    partial class JobApplicationsView
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
            this.BackToVisualChartBtn = new System.Windows.Forms.Button();
            this.AddApplicationBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToVisualChartBtn
            // 
            this.BackToVisualChartBtn.Location = new System.Drawing.Point(16, 485);
            this.BackToVisualChartBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackToVisualChartBtn.Name = "BackToVisualChartBtn";
            this.BackToVisualChartBtn.Size = new System.Drawing.Size(163, 28);
            this.BackToVisualChartBtn.TabIndex = 0;
            this.BackToVisualChartBtn.Text = "Back to Visual Chart";
            this.BackToVisualChartBtn.UseVisualStyleBackColor = true;
            this.BackToVisualChartBtn.Click += new System.EventHandler(this.BackToVisualChartBtn_Click);
            // 
            // AddApplicationBtn
            // 
            this.AddApplicationBtn.Location = new System.Drawing.Point(888, 485);
            this.AddApplicationBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddApplicationBtn.Name = "AddApplicationBtn";
            this.AddApplicationBtn.Size = new System.Drawing.Size(163, 28);
            this.AddApplicationBtn.TabIndex = 1;
            this.AddApplicationBtn.Text = "Add application";
            this.AddApplicationBtn.UseVisualStyleBackColor = true;
            this.AddApplicationBtn.Click += new System.EventHandler(this.AddApplicationBtn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(299, 135);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(444, 262);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(299, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Job Applications";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JobApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.AddApplicationBtn);
            this.Controls.Add(this.BackToVisualChartBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "JobApplications";
            this.Text = "JobApplications";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToVisualChartBtn;
        private System.Windows.Forms.Button AddApplicationBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;

    }
}