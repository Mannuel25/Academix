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
    public partial class bursarDetails : Form
    {
        public bursarDetails()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "SELECT * FROM `bursar` WHERE full_name = @full_name";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            databaseconnection.Open();

            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            databasecommand.Parameters.AddWithValue("@full_name", Global.bursarName);

            MySqlDataReader reader = databasecommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    nameField.Text = reader["full_name"].ToString();
                    emailField.Text = reader["email"].ToString();
                    phone_no_field.Text = reader["phone_no"].ToString();
                }

                databaseconnection.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "UPDATE bursar SET full_name = @full_name, email = @email, phone_no = @phone_no WHERE full_name = @full_name";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);

            databasecommand.Parameters.AddWithValue("@full_name", nameField.Text);
            databasecommand.Parameters.AddWithValue("@email", emailField.Text);
            databasecommand.Parameters.AddWithValue("@phone_no", phone_no_field.Text);

            databaseconnection.Open();
            databasecommand.ExecuteReader();
            databaseconnection.Close();
            MessageBox.Show("Bursar Details updated successfully!");
            dashboard dash = new dashboard();
            dash.Show();
            Visible = false;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";
            string querystr = "DELETE FROM bursar WHERE full_name = @full_name";
            MySqlConnection databaseconnection = new MySqlConnection(constr);
            MySqlCommand databasecommand = new MySqlCommand(querystr, databaseconnection);
            databasecommand.Parameters.AddWithValue("@full_name", Global.bursarName);
            databaseconnection.Open();
            databasecommand.ExecuteReader();
            databaseconnection.Close();
            MessageBox.Show("Record for " + nameField.Text + " successfully deleted");
            dashboard dash = new dashboard();
            dash.Show();
            Visible = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
