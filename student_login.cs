using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Academix
{
    public partial class student_login : Form
    {
        public student_login()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Visible = false;
            signup f1 = new signup();
            f1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "select dept, matric_number, email from student where matric_number='" + matricField.Text + "' and password= '" + pwordField.Text + "'";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            databaseconnection.Open();


            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);

            MySqlDataReader reader = databasecommand.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {

                MessageBox.Show("Login Successful!");
                Global.studentMatricNo = matricField.Text;
                Global.studentDept = reader["dept"].ToString();

                databaseconnection.Close();

                Visible = false;
                userDashboard dash = new userDashboard();
                dash.Show();
            }
            else
            {
                MessageBox.Show("User Not found");
          }
        }
    }
}
