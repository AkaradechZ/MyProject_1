using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
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
            Application.Run(new login_form());
        }
        //public static string myGlobalVar;
        public static string user;//fname
        public static string user2;//lname
        public static string nameselect;
        public static string choice;
        public static string date;
        public static string list001;
        public static string money;
        public static string inex;
        public static string recorder;
        public static string yoloemail;
        public static string inexselect;
        public static string inorex;
        public static string emailid;
    }

}
    
