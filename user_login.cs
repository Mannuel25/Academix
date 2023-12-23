using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academix
{
    public partial class user_login : Form
    {
        public user_login()
        {
            InitializeComponent();
        }

        private void stu_login_btn_Click(object sender, EventArgs e)
        {
            Global.signup_user = "student";
            Global.user_type = "student";
            student_login l = new student_login();
            l.Show();
            Visible = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            signup f1 = new signup();
            f1.Show();
            Visible = false;
        }

        private void bus_login_btn_Click(object sender, EventArgs e)
        {
            Global.signup_user = "bursar";
            Global.user_type = "bursar";
            login l = new login();
            l.Show();
            Visible = false;
        }

        private void admin_login_btn_Click(object sender, EventArgs e)
        {
            Global.signup_user = "admin";
            Global.user_type = "admin";
            login l = new login();
            l.Show();
            Visible = false;
        }
    }
}
