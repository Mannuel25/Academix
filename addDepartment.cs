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
    public partial class addDepartment : Form
    {
        static string GenerateRandomString(int length)
        {
            Random random = new Random();
            const string chars = "0123456789";
            StringBuilder stringBuilder = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(chars.Length);
                stringBuilder.Append(chars[randomIndex]);
            }

            return stringBuilder.ToString();
        }
        public addDepartment()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";

            MySqlConnection databaseconnection = new MySqlConnection(constr);

            string querystr = "INSERT INTO department (dept_id, dept, total_fees, faculty) VALUES (@dept_id, @dept, @total_fees, @faculty)";
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            databasecommand.Parameters.AddWithValue("@dept_id", GenerateRandomString(3));
            databasecommand.Parameters.AddWithValue("@dept", deptField.Text);
            databasecommand.Parameters.AddWithValue("@faculty", facultyField.Text);
            databasecommand.Parameters.AddWithValue("@total_fees", feesField.Text);
            databaseconnection.Open();
            databasecommand.ExecuteReader();

            MessageBox.Show("Department added successfully!");
            Visible = false;
            
            bursarDashboard view = new bursarDashboard();
            view.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            bursarDashboard view = new bursarDashboard();
            view.Show();
        }
    }
}
