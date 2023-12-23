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
    public partial class bursarDashboard : Form
    {
        private DataTable dataTable;
        public bursarDashboard()
        {
            InitializeComponent();
        }

        private void all_stds_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Global.grid_view = "student";
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "select `matric_number`, `full_name`, `email`, `phone_no`, `level`, `faculty`, `dept`, `amt_paid`, `fees_balance` from student";
            //string querystr = "select `matric_number`, `full_name`, `email`, `phone_no`, `level`, `faculty`, `dept`, `amt_paid`, `fees_balance` from student";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            dataTable = new DataTable();
            try
            {
                databaseconnection.Open();

                // Fill the DataTable with the retrieved data
                MySqlDataAdapter adapter = new MySqlDataAdapter(databasecommand);
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView control
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                databaseconnection.Close();
            }
        }

        private void view_depts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Global.grid_view = "department";
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "select dept, faculty, total_fees from department";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            dataTable = new DataTable();
            try
            {
                databaseconnection.Open();

                // Fill the DataTable with the retrieved data
                MySqlDataAdapter adapter = new MySqlDataAdapter(databasecommand);
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView control
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                databaseconnection.Close();
            }
        }

        private void bursarDashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Global.grid_view = "student";
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "select `matric_number`, `full_name`, `email`, `phone_no`, `level`, `faculty`, `dept`, `amt_paid`, `fees_balance` from student";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            dataTable = new DataTable();
            try
            {
                databaseconnection.Open();

                // Fill the DataTable with the retrieved data
                MySqlDataAdapter adapter = new MySqlDataAdapter(databasecommand);
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView control
                dataGridView1.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                databaseconnection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (Global.grid_view == "student")
            {
                Global.studentMatricNo = row.Cells[0].Value.ToString();
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

                
                Visible = false;
                userDetails view = new userDetails();
                view.Show();
            }
            else if (Global.grid_view == "department")
            {
                Global.departmentName = row.Cells[0].Value.ToString();
                Visible = false;
                deptDetails view = new deptDetails();
                view.Show();
            }
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            MessageBox.Show("Logout successful!");
            user_login view = new user_login();
            view.Show();
        }

        private void add_dept_Click(object sender, EventArgs e)
        {

            Visible = false;
            addDepartment f2 = new addDepartment();
            f2.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (search_input.Text == "")
            {
                MessageBox.Show("Please enter a student or department to search for");
            }
            string searchQuery = "'%" + search_input.Text + "%'";
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "select `matric_number`, `full_name`, `email`, `phone_no`, `level`, `faculty`, `dept`, `amt_paid`, `fees_balance` from student where full_name like " + searchQuery;
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            dataTable = new DataTable();
            try
            {
                databaseconnection.Open();

                // Fill the DataTable with the retrieved data
                MySqlDataAdapter adapter = new MySqlDataAdapter(databasecommand);
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView control
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                databaseconnection.Close();
            }
        }

        private void search_input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
