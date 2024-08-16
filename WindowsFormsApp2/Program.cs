using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
            Application.Run(new frm1());
            Application.Run(new frm2());
            Application.Run(new frm3());
            Application.Run(new frm4());
            Application.Run(new frm5());
            Application.Run(new frm6());
            Application.Run(new frm7());
            Application.Run(new frm8());
            Application.Run(new frm9());
            Application.Run(new frm10());
            Application.Run(new frm11());
            Application.Run(new frm12());
        }
    }
}
