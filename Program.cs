using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academix
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
            Application.Run(new user_login());
        }
    }
    class Global
    {

        public static string signup_user = "";
        public static string user_type = "";
        public static string studentMatricNo = "";
        public static string departmentName = "";
        public static string bursarName = "";
        public static string grid_view = "";
        public static string studentDept = "";
        public static string AmountFeesPaid = "";
        public static int studentTotalFees = 0;
        public static int Balance = 0;

    }
}
