using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyline.StaffTracking.Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(@"Mjc5OTk3QDMxMzgyZTMxMmUzMG1tMVluSDY5UnZKTjZhcDhHU3g3NG9OejY0eTY2NE81ZTdhdWh6M0I4c2c9");
            Application.Run(new frmMain());
        }
    }
}
