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
    public partial class userDashboard : Form
    {
        private DataTable dataTable;
        public userDashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userDashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Global.grid_view = "student";
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "SELECT `matric_number`, `full_name`, `email`, `phone_no`, `level`, `faculty`, `dept`, `amt_paid`, `fees_balance` from student WHERE matric_number = @matric_number";
            //string querystr = "select `matric_number`, `full_name`, `email`, `phone_no`, `level`, `faculty`, `dept`, `amt_paid`, `fees_balance` from student " + "where matric_number='" + Global.studentMatricNo;
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            databasecommand.Parameters.AddWithValue("@matric_number", Global.studentMatricNo);
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
            Global.studentMatricNo = row.Cells[0].Value.ToString();
            Visible = false;
            userDetails view = new userDetails();
            view.Show();
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            user_login view = new user_login();
            view.Show();
        }
    }
}
