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
    public partial class loginC : Form
    {
        private void loginC_FormClosed(object sender, FormClosedEventArgs e)
        {;
            if (Application.OpenForms.Count == 0)
            {
                Environment.Exit(0);
            }
        }
        public loginC()
        {
            InitializeComponent();
            
        }
        public static int LoggedInCustomerID;
        private bool ValidateLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection("Server=MONARCH-31205\\SQLEXPRESS; Database=StoreX; Integrated Security=true;"))
            {
                string query = "SELECT CustomerID FROM Customer WHERE CustomerName = @CustomerName AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        LoggedInCustomerID = Convert.ToInt32(result);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            string username = usn.Text;
            string password = pwd.Text;

            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                customer mainForm = new customer();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
