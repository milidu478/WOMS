using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop
{

    public static class Manivariable
    {
        private static string globalString;

        public static string Mvariable
        {
            get { return globalString; }
            set { globalString = value; }
        }


    }

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
            Application.Run(new login2());
        }
    }
}
