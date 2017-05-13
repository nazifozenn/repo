using System;
using System.Linq;
using System.Windows.Forms;

namespace Service_Desk
{
    
    static class Program
    {
        public static int login_control=0;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login_form());
        }
    }
}