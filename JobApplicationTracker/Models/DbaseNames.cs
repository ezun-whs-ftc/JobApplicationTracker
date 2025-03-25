using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationTracker.Models
{
    public static class DbaseNames
    {
        /*********************************************************
         * 1. Right click on the project name
         * 2. Select Properties
         * 3. Go To Build
         * 4. Uncheck "Prefer 32-bit"
         *********************************************************/

        public static string JobApplicationDBase { get; } = "JobApplication.accdb";
        public static string LabDriver { get; } = "{Microsoft Access Driver (*.mdb, *.accdb)}";
        public static string DSNName { get; } = "MSAccessDSN64.dsn";
    }
}
