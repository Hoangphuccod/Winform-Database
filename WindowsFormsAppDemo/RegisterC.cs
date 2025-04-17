using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDemo
{
    public partial class RegisterC : Form
    {
        private void RegisterC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        public RegisterC()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=MONARCH-31205\\SQLEXPRESS; Database=StoreX; Integrated Security=true;");
        }
        SqlConnection connection;
        private void epylog_Click(object sender, EventArgs e)
        {
            login regForm = new login();
            regForm.Show();
            this.Hide();
        }

        private void chp_Click(object sender, EventArgs e)
        {
            register regForm = new register();
            regForm.Show();
            this.Hide();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            string customerName = usn.Text;
            string phoneNumber = pen.Text;
            string password = pwd.Text;

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Customer (CustomerName, PhoneNumber, Password) VALUES (@CustomerName, @PhoneNumber, @Password)";

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerName", customerName);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Password", password);

                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Customer registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            this.Hide();
            loginC loginForm = new loginC();
            loginForm.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginC loginForm = new loginC();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
