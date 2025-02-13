using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationTracker
{
    static class Pages
    {
        private static readonly Dictionary<string, Form> pages = new Dictionary<String, Form>()
        {
            {"Homepage", new Form1() },
            {"Visualchart", new VisualChart() },
            {"JobApplications", new JobApplications() },
            {"ApplicationView", new ApplicationView() },
            {"AddApplication", new Add_Application() },
        };
        static private Form GetPage(String page)
        {
            return pages[page];
        }
        static public void navigate(Form CurrentPage, String NewPage)
        {
            CurrentPage.Close();
            Thread t = new Thread(() => Application.Run(GetPage(NewPage)));
            t.Start();
        }
    }
}
