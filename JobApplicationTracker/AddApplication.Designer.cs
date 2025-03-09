using System.Runtime.CompilerServices;
using static JobApplicationTracker.Constants;
namespace JobApplicationTracker
{
    partial class Add_Application
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BackToJobApplicationBtn = new System.Windows.Forms.Button();
            this.AddApplicationBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.RejectedStatusBtn = new System.Windows.Forms.RadioButton();
            this.AppliedStatusBtn = new System.Windows.Forms.RadioButton();
            this.InterviewedStatusBtn = new System.Windows.Forms.RadioButton();
            this.OfferedStatusBtn = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 96);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(197, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 52);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(197, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 52);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reminders:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(324, 180);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(381, 22);
            this.textBox2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(197, 246);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 52);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "DateApplied:";
            // 
            // BackToJobApplicationBtn
            // 
            this.BackToJobApplicationBtn.Location = new System.Drawing.Point(48, 473);
            this.BackToJobApplicationBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackToJobApplicationBtn.Name = "BackToJobApplicationBtn";
            this.BackToJobApplicationBtn.Size = new System.Drawing.Size(165, 52);
            this.BackToJobApplicationBtn.TabIndex = 7;
            this.BackToJobApplicationBtn.Text = "Back to Job Applications";
            this.BackToJobApplicationBtn.UseVisualStyleBackColor = true;
            this.BackToJobApplicationBtn.Click += new System.EventHandler(this.BackToJobApplicationBtn_Click);
            // 
            // AddApplicationBtn
            // 
            this.AddApplicationBtn.Location = new System.Drawing.Point(607, 473);
            this.AddApplicationBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddApplicationBtn.Name = "AddApplicationBtn";
            this.AddApplicationBtn.Size = new System.Drawing.Size(165, 52);
            this.AddApplicationBtn.TabIndex = 8;
            this.AddApplicationBtn.Text = "Add Application";
            this.AddApplicationBtn.UseVisualStyleBackColor = true;
            this.AddApplicationBtn.Click += new System.EventHandler(this.AddApplicationBtn_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(197, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(509, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "add a application";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 263);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(381, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(197, 326);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 52);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Status:";
            // 
            // RejectedStatusBtn
            // 
            this.RejectedStatusBtn.AutoSize = true;
            this.RejectedStatusBtn.Location = new System.Drawing.Point(324, 326);
            this.RejectedStatusBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RejectedStatusBtn.Name = "RejectedStatusBtn";
            this.RejectedStatusBtn.Size = new System.Drawing.Size(83, 20);
            this.RejectedStatusBtn.TabIndex = 12;
            this.RejectedStatusBtn.TabStop = true;
            this.RejectedStatusBtn.Text = "Rejected";
            this.RejectedStatusBtn.UseVisualStyleBackColor = true;
            // 
            // AppliedStatusBtn
            // 
            this.AppliedStatusBtn.AutoSize = true;
            this.AppliedStatusBtn.Location = new System.Drawing.Point(324, 354);
            this.AppliedStatusBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AppliedStatusBtn.Name = "AppliedStatusBtn";
            this.AppliedStatusBtn.Size = new System.Drawing.Size(75, 20);
            this.AppliedStatusBtn.TabIndex = 13;
            this.AppliedStatusBtn.TabStop = true;
            this.AppliedStatusBtn.Text = "Applied";
            this.AppliedStatusBtn.UseVisualStyleBackColor = true;
            // 
            // InterviewedStatusBtn
            // 
            this.InterviewedStatusBtn.AutoSize = true;
            this.InterviewedStatusBtn.Location = new System.Drawing.Point(423, 326);
            this.InterviewedStatusBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InterviewedStatusBtn.Name = "InterviewedStatusBtn";
            this.InterviewedStatusBtn.Size = new System.Drawing.Size(96, 20);
            this.InterviewedStatusBtn.TabIndex = 14;
            this.InterviewedStatusBtn.TabStop = true;
            this.InterviewedStatusBtn.Text = "Interviewed";
            this.InterviewedStatusBtn.UseVisualStyleBackColor = true;
            // 
            // OfferedStatusBtn
            // 
            this.OfferedStatusBtn.AutoSize = true;
            this.OfferedStatusBtn.Location = new System.Drawing.Point(423, 357);
            this.OfferedStatusBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OfferedStatusBtn.Name = "OfferedStatusBtn";
            this.OfferedStatusBtn.Size = new System.Drawing.Size(72, 20);
            this.OfferedStatusBtn.TabIndex = 15;
            this.OfferedStatusBtn.TabStop = true;
            this.OfferedStatusBtn.Text = "Offered";
            this.OfferedStatusBtn.UseVisualStyleBackColor = true;
            // 
            // Add_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 554);
            this.Controls.Add(this.OfferedStatusBtn);
            this.Controls.Add(this.InterviewedStatusBtn);
            this.Controls.Add(this.AppliedStatusBtn);
            this.Controls.Add(this.RejectedStatusBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddApplicationBtn);
            this.Controls.Add(this.BackToJobApplicationBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Add_Application";
            this.Text = "Add_Application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackToJobApplicationBtn;
        private System.Windows.Forms.Button AddApplicationBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RejectedStatusBtn;
        private System.Windows.Forms.RadioButton AppliedStatusBtn;
        private System.Windows.Forms.RadioButton InterviewedStatusBtn;
        private System.Windows.Forms.RadioButton OfferedStatusBtn;
    }
}