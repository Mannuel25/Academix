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
    public partial class dashboard : Form
    {
        private DataTable dataTable;
        public dashboard()
        {
            InitializeComponent();

        }

        private void view_students_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
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

        private void view_bursars_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Global.grid_view = "bursar";
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "select full_name, email, phone_no from bursar";
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

        private void view_students_Click_1(object sender, EventArgs e)
        {
            
        }

        private void all_stds_Click(object sender, EventArgs e)
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
            else if (Global.grid_view == "bursar")
            {
                Global.bursarName = row.Cells[0].Value.ToString();
                Visible = false;
                bursarDetails view = new bursarDetails();
                view.Show();
            }
        }

        private void search_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            MessageBox.Show("Logout successful!");
            user_login view = new user_login();
            view.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (search_input.Text == "")
            {
                MessageBox.Show("Please enter a student, bursar or department to search for");
            }
            string searchQuery = "'%" + search_input.Text + "%'";
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "select `matric_number`, `full_name`, `email`, `phone_no`, `level`, `faculty`, `dept`, `amt_paid`, `fees_balance` from student where full_name like " + searchQuery;
            if(Global.grid_view == "bursar"){
                querystr = "select `full_name`, `email`, `phone_no` from bursar where full_name like " + searchQuery;
            }
            else if(Global.grid_view == "department"){
                querystr = "select `dept`, `total_fees`, `faculty` from department where dept like " + searchQuery;
            }
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
    }
}
