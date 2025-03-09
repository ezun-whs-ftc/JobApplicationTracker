﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JobApplicationTracker.Constants;
namespace JobApplicationTracker
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Database.SetInitializer(new CreateDatabaseIfNotExists<JobApplicationContext>());
            using (var context = new JobApplicationContext())
            {
                context.Database.Initialize(force: true);
            }

            
        }
    }
}
