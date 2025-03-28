﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationTracker
{
  public  class Constants
    {
        public enum Status
        {
            Applied,
            Interviewed,
            Offered,
            Rejected
        }
        static public void navigate(Form CurrentPage, Form NewPage)
        {
            CurrentPage.Close();
            Thread t = new Thread(() => Application.Run(NewPage));
            t.Start();
        }
        internal static class readOnly
        {
            private static bool isReadOnly = true;
            public static bool getReadOnly() => isReadOnly;

            public static void setReadOnly() => isReadOnly = !isReadOnly;

        }
        public static Status convertStringToStatus(String x)
        {
            switch (x)
            {
                case "Applied":
                    return Status.Applied;
                case "Interviewed":
                    return Status.Interviewed;
                case "Offered":
                    return Status.Offered;
                case "Rejected":
                    return Status.Rejected;
                default:
                    return Status.Applied;
            }
        }
    }
}
