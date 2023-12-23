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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailField_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwordConfrmField_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "select email, password from " + Global.user_type + " where email='" + emailField.Text + "' and password= '" + pwordField.Text + "'";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            databaseconnection.Open();

            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);

            MySqlDataReader reader = databasecommand.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {

                MessageBox.Show("Login Successful!");

                databaseconnection.Close();
                if (Global.user_type == "admin")
                {
                    dashboard dash = new dashboard();
                    dash.Show();
                    Visible = false;
                }
                else
                {
                    bursarDashboard dash = new bursarDashboard();
                    dash.Show();
                    Visible = false;
                }
            }
            else
                MessageBox.Show("User Not found");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            signup f1 = new signup();
            f1.Show();
            Visible = false;
        }
    }
}
