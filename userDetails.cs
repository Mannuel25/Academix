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
    public partial class userDetails : Form
    {
        public userDetails()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            if (Global.user_type != "admin")
            {
                delBtn.Visible = false;
            }
            if (Global.user_type == "bursar")
            {
                amount_paid.ReadOnly = false;
                fees_balance.ReadOnly = false;
            }

            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "SELECT * FROM `student` WHERE matric_number = " + Global.studentMatricNo;
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            databaseconnection.Open();

            string querystr1 = "SELECT total_fees FROM `department` WHERE dept = @dept";

            MySqlCommand databasecommand1 = new MySqlCommand(querystr1, databaseconnection);
            databasecommand1.Parameters.AddWithValue("@dept", Global.studentDept);

            MySqlDataReader reader1 = databasecommand1.ExecuteReader();
            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    Global.studentTotalFees = int.Parse(reader1["total_fees"].ToString());
                }
            }
            reader1.Close();
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);

            MySqlDataReader reader = databasecommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    matric_number_field.Text = reader["matric_number"].ToString();
                    nameField.Text = reader["full_name"].ToString();
                    emailField.Text = reader["email"].ToString();
                    phone_no_field.Text = reader["phone_no"].ToString();
                    deptField.Text = reader["dept"].ToString();
                    facultyField.Text = reader["faculty"].ToString();
                    levelField.Text = reader["level"].ToString();
                    amount_paid.Text = reader["amt_paid"].ToString();
                    int fees_balance1 = int.Parse(reader["amt_paid"].ToString());
                    Global.Balance = Global.studentTotalFees - fees_balance1;
                    fees_balance.Text = reader["fees_balance"].ToString();
                }

                databaseconnection.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "UPDATE student SET matric_number = @matric_number, full_name = @full_name, email = @email, phone_no = @phone_no, dept = @dept, faculty = @faculty, level = @level, amt_paid = @amt_paid, fees_balance = @fees_balance WHERE matric_number = @matric_number";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);

            int fees_balance2 = int.Parse(amount_paid.Text);
            Global.Balance = Global.studentTotalFees - fees_balance2;

            databasecommand.Parameters.AddWithValue("@matric_number", matric_number_field.Text);
            databasecommand.Parameters.AddWithValue("@full_name", nameField.Text);
            databasecommand.Parameters.AddWithValue("@email", emailField.Text);
            databasecommand.Parameters.AddWithValue("@phone_no", phone_no_field.Text);
            databasecommand.Parameters.AddWithValue("@dept", deptField.Text);
            databasecommand.Parameters.AddWithValue("@faculty", facultyField.Text);
            databasecommand.Parameters.AddWithValue("@level", levelField.Text);
            databasecommand.Parameters.AddWithValue("@amt_paid", amount_paid.Text);
            databasecommand.Parameters.AddWithValue("@fees_balance", Global.Balance);

            databaseconnection.Open();
            databasecommand.ExecuteReader();
            databaseconnection.Close();
            MessageBox.Show("User Details updated successfully!");
            if (Global.user_type == "student")
            {
                userDashboard dash = new userDashboard();
                dash.Show();
            }
            else if (Global.user_type == "admin")
            {
                dashboard dash = new dashboard();
                dash.Show();
            }
            else if (Global.user_type == "bursar")
            {
                bursarDashboard dash = new bursarDashboard();
                dash.Show();
            }
            Visible = false;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "DELETE FROM student WHERE matric_number = @matric_number";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            databasecommand.Parameters.AddWithValue("@matric_number", Global.studentMatricNo);
            databaseconnection.Open();
            databasecommand.ExecuteReader();
            databaseconnection.Close();
            MessageBox.Show("Record for " + nameField.Text + " successfully deleted");
            if (Global.user_type == "student")
            {
                userDashboard dash = new userDashboard();
                dash.Show();
            }
            else if (Global.user_type == "admin")
            {
                dashboard dash = new dashboard();
                dash.Show();
            }
            else if (Global.user_type == "bursar")
            {
                bursarDashboard dash = new bursarDashboard();
                dash.Show();
            }
            Visible = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            if (Global.user_type == "student")
            {
                userDashboard dash = new userDashboard();
                dash.Show();
            }
            else if (Global.user_type == "admin")
            {
                dashboard dash = new dashboard();
                dash.Show();
            }
            else if (Global.user_type == "bursar")
            {
                bursarDashboard dash = new bursarDashboard();
                dash.Show();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void userDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
