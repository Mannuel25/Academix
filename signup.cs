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
    public partial class signup : Form
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

        public signup()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            string constr = "datasource=127.0.0.1;port=3306;username=root;password=;database=academix;";

            MySqlConnection databaseconnection = new MySqlConnection(constr);

            // save to bursar table
            if ((emailField.Text == "bus@gmail.com") || (emailField.Text == "bursar@gmail.com"))
            {
                string bursar_querystr = "INSERT INTO bursar (bus_id, full_name, email, password) VALUES (@bus_id, @full_name, @email, @password)";
                MySqlCommand bursardatabasecommand = new MySqlCommand(bursar_querystr, databaseconnection);
                bursardatabasecommand.Parameters.AddWithValue("@bus_id", GenerateRandomString(3));
                bursardatabasecommand.Parameters.AddWithValue("@full_name", nameField.Text);
                bursardatabasecommand.Parameters.AddWithValue("@email", emailField.Text);
                bursardatabasecommand.Parameters.AddWithValue("@password", pwordField.Text);
                databaseconnection.Open();
                bursardatabasecommand.ExecuteReader();

                MessageBox.Show("Signup successful. Kindly proceed to login with your email address and password");
                Visible = false;
                // proceed to login upon signup
                login f2 = new login();
                f2.Show();
                
            }

            // save to admin table
            else if ((emailField.Text == "admin@gmail.com") || (emailField.Text == "administrator@gmail.com"))
            {
                string admin_querystr = "INSERT INTO admin (admin_id, full_name, email, password) VALUES (@admin_id, @full_name, @email, @password)";
                MySqlCommand admindatabasecommand = new MySqlCommand(admin_querystr, databaseconnection);
                admindatabasecommand.Parameters.AddWithValue("@admin_id", GenerateRandomString(3));
                admindatabasecommand.Parameters.AddWithValue("@full_name", nameField.Text);
                admindatabasecommand.Parameters.AddWithValue("@email", emailField.Text);
                admindatabasecommand.Parameters.AddWithValue("@password", pwordField.Text);
                databaseconnection.Open();
                admindatabasecommand.ExecuteReader();

                 MessageBox.Show("Signup successful. Kindly proceed to login with your email address and password");
                 Visible = false;
                // proceed to login upon signup
                login f2 = new login();
                f2.Show();
            }

            // save to students table
            else 
            {
                string user_querystr = "INSERT INTO student (stu_id, matric_number, full_name, email, password) VALUES (@stu_id, @matric_number, @full_name, @email, @password)";
                MySqlCommand userdatabasecommand = new MySqlCommand(user_querystr, databaseconnection);
                userdatabasecommand.Parameters.AddWithValue("@stu_id", GenerateRandomString(3));
                userdatabasecommand.Parameters.AddWithValue("@matric_number", GenerateRandomString(10));
                userdatabasecommand.Parameters.AddWithValue("@full_name", nameField.Text);
                userdatabasecommand.Parameters.AddWithValue("@email", emailField.Text);
                userdatabasecommand.Parameters.AddWithValue("@password", pwordField.Text);
                databaseconnection.Open();
                userdatabasecommand.ExecuteReader();

                MessageBox.Show("Signup successful. Your matric number is " + GenerateRandomString(10) + ". Kindly copy your matric number to proceed to login with your matric number and password");
                Visible = false;
                // proceed to login upon signup
                student_login f1 = new student_login();
                f1.Show();
           }


            
            databaseconnection.Close();
            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Visible = false;
            user_login f1 = new user_login();
            f1.Show();
        }
    }
}
