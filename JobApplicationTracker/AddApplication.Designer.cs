﻿namespace JobApplicationTracker
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(148, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 42);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(148, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 42);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reminders:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 20);
            this.textBox2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(148, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(89, 42);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "DateApplied:";
            // 
            // BackToJobApplicationBtn
            // 
            this.BackToJobApplicationBtn.Location = new System.Drawing.Point(36, 384);
            this.BackToJobApplicationBtn.Name = "BackToJobApplicationBtn";
            this.BackToJobApplicationBtn.Size = new System.Drawing.Size(124, 42);
            this.BackToJobApplicationBtn.TabIndex = 7;
            this.BackToJobApplicationBtn.Text = "Back to Job Applications";
            this.BackToJobApplicationBtn.UseVisualStyleBackColor = true;
            this.BackToJobApplicationBtn.Click += new System.EventHandler(this.BackToJobApplicationBtn_Click);
            // 
            // AddApplicationBtn
            // 
            this.AddApplicationBtn.Location = new System.Drawing.Point(664, 384);
            this.AddApplicationBtn.Name = "AddApplicationBtn";
            this.AddApplicationBtn.Size = new System.Drawing.Size(124, 42);
            this.AddApplicationBtn.TabIndex = 8;
            this.AddApplicationBtn.Text = "Add Application";
            this.AddApplicationBtn.UseVisualStyleBackColor = true;
            this.AddApplicationBtn.Click += new System.EventHandler(this.AddApplicationBtn_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(148, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "add a application";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(243, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // Add_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddApplicationBtn);
            this.Controls.Add(this.BackToJobApplicationBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Add_Application";
            this.Text = "Add_Application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
    }
}