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
    public partial class deptDetails : Form
    {
        public deptDetails()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "SELECT * FROM `department` WHERE dept = @dept";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            databaseconnection.Open();

            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            databasecommand.Parameters.AddWithValue("@dept", Global.departmentName);

            MySqlDataReader reader = databasecommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    deptField.Text = reader["dept"].ToString();
                    facultyField.Text = reader["faculty"].ToString();
                    fees_field.Text = reader["total_fees"].ToString();
                }

                databaseconnection.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "UPDATE department SET dept = @dept, total_fees = @total_fees, faculty = @faculty WHERE dept = @dept";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);

            databasecommand.Parameters.AddWithValue("@dept", deptField.Text);
            databasecommand.Parameters.AddWithValue("@faculty", facultyField.Text);
            databasecommand.Parameters.AddWithValue("@total_fees", fees_field.Text);

            databaseconnection.Open();
            databasecommand.ExecuteReader();
            databaseconnection.Close();
            MessageBox.Show("Department Details updated successfully!");
            Visible = false;
            bursarDashboard dash = new bursarDashboard();
            dash.Show();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "DELETE FROM department WHERE dept = @dept";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            databasecommand.Parameters.AddWithValue("@dept", deptField.Text);
            databaseconnection.Open();
            databasecommand.ExecuteReader();
            databaseconnection.Close();
            MessageBox.Show("Record for " + deptField.Text + " successfully deleted");
            Visible = false;
            bursarDashboard dash = new bursarDashboard();
            dash.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            bursarDashboard dash = new bursarDashboard();
            dash.Show();
        }

        private void fees_field_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
