using System.Runtime.CompilerServices;
using static JobApplicationTracker.Constants.readOnly;
namespace JobApplicationTracker
{
    partial class ApplicationView
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BackToJobApplicationsBtn = new System.Windows.Forms.Button();
            this.EditApplicationBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RejectedBtn = new System.Windows.Forms.RadioButton();
            this.AppliedBtn = new System.Windows.Forms.RadioButton();
            this.InterviewedBtn = new System.Windows.Forms.RadioButton();
            this.OfferedBtn = new System.Windows.Forms.RadioButton();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 139);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(508, 22);
            this.textBox1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(281, 289);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 52);
            this.panel4.TabIndex = 10;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(281, 230);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 52);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Status:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(408, 186);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(381, 22);
            this.textBox2.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(281, 171);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 52);
            this.panel2.TabIndex = 7;
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
            // BackToJobApplicationsBtn
            // 
            this.BackToJobApplicationsBtn.Location = new System.Drawing.Point(16, 487);
            this.BackToJobApplicationsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackToJobApplicationsBtn.Name = "BackToJobApplicationsBtn";
            this.BackToJobApplicationsBtn.Size = new System.Drawing.Size(165, 52);
            this.BackToJobApplicationsBtn.TabIndex = 13;
            this.BackToJobApplicationsBtn.Text = "Back to Job Applications";
            this.BackToJobApplicationsBtn.UseVisualStyleBackColor = true;
            this.BackToJobApplicationsBtn.Click += new System.EventHandler(this.BackToJobApplicationsBtn_Click);
            // 
            // EditApplicationBtn
            // 
            this.EditApplicationBtn.Location = new System.Drawing.Point(885, 487);
            this.EditApplicationBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditApplicationBtn.Name = "EditApplicationBtn";
            this.EditApplicationBtn.Size = new System.Drawing.Size(165, 52);
            this.EditApplicationBtn.TabIndex = 14;
            this.EditApplicationBtn.Text = "Edit Application";
            this.EditApplicationBtn.UseVisualStyleBackColor = true;
            this.EditApplicationBtn.Click += new System.EventHandler(this.EditJobApplicationBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(418, 306);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // RejectedBtn
            // 
            this.RejectedBtn.AutoSize = true;
            this.RejectedBtn.Location = new System.Drawing.Point(418, 230);
            this.RejectedBtn.Name = "RejectedBtn";
            this.RejectedBtn.Size = new System.Drawing.Size(83, 20);
            this.RejectedBtn.TabIndex = 17;
            this.RejectedBtn.TabStop = true;
            this.RejectedBtn.Text = "Rejected\r\n";
            this.RejectedBtn.UseVisualStyleBackColor = true;
            // 
            // AppliedBtn
            // 
            this.AppliedBtn.AutoSize = true;
            this.AppliedBtn.Location = new System.Drawing.Point(418, 262);
            this.AppliedBtn.Name = "AppliedBtn";
            this.AppliedBtn.Size = new System.Drawing.Size(75, 20);
            this.AppliedBtn.TabIndex = 18;
            this.AppliedBtn.TabStop = true;
            this.AppliedBtn.Text = "Applied";
            this.AppliedBtn.UseVisualStyleBackColor = true;
            // 
            // InterviewedBtn
            // 
            this.InterviewedBtn.AutoSize = true;
            this.InterviewedBtn.Location = new System.Drawing.Point(527, 230);
            this.InterviewedBtn.Name = "InterviewedBtn";
            this.InterviewedBtn.Size = new System.Drawing.Size(96, 20);
            this.InterviewedBtn.TabIndex = 19;
            this.InterviewedBtn.TabStop = true;
            this.InterviewedBtn.Text = "Interviewed";
            this.InterviewedBtn.UseVisualStyleBackColor = true;
            // 
            // OfferedBtn
            // 
            this.OfferedBtn.AutoSize = true;
            this.OfferedBtn.Location = new System.Drawing.Point(527, 262);
            this.OfferedBtn.Name = "OfferedBtn";
            this.OfferedBtn.Size = new System.Drawing.Size(72, 20);
            this.OfferedBtn.TabIndex = 20;
            this.OfferedBtn.TabStop = true;
            this.OfferedBtn.Text = "Offered";
            this.OfferedBtn.UseVisualStyleBackColor = true;
            // 
            // ApplicationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.OfferedBtn);
            this.Controls.Add(this.InterviewedBtn);
            this.Controls.Add(this.AppliedBtn);
            this.Controls.Add(this.RejectedBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.EditApplicationBtn);
            this.Controls.Add(this.BackToJobApplicationsBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ApplicationView";
            this.Text = "ApplicationView";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackToJobApplicationsBtn;
        private System.Windows.Forms.Button EditApplicationBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton RejectedBtn;
        private System.Windows.Forms.RadioButton AppliedBtn;
        private System.Windows.Forms.RadioButton InterviewedBtn;
        private System.Windows.Forms.RadioButton OfferedBtn;
    }
}