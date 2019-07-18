using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301045531
{
    public static class Program
    {
        public static MainForm mainform;
        public static StartForm startform;
        public static EndForm endform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainform = new MainForm();
            startform = new StartForm();
            endform = new EndForm();
            Application.Run(new StartForm());
        }
    }
}
