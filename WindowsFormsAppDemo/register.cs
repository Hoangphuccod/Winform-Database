using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static WindowsFormsAppDemo.login;

namespace WindowsFormsAppDemo
{
    public partial class register : Form
    {

        private void register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private string userRole = "";
        public register()
        {
            InitializeComponent();
            tabcnt.Selecting += tabcnt_Selecting;
            this.FormClosed += register_FormClosed;
        }

        SqlConnection connection;

        private void register_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Server=MONARCH-31205\\SQLEXPRESS; Database=StoreX; Integrated Security=true;");
        }
        private void tabcnt_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (string.IsNullOrEmpty(userRole))
            {
                string password = Prompt.ShowDialog("Enter Password:", "Require");

                if (password == "admin123")
                    userRole = "Admin";
                else if (password == "sale123")
                    userRole = "Sales";
                else if (password == "warehouse123")
                    userRole = "Warehouse";
                else
                {
                    MessageBox.Show("Wrong Password");
                    e.Cancel = true;
                    return;
                }
            }

            if ((e.TabPage == tabcnt.TabPages[1] && userRole != "Warehouse") ||
                (e.TabPage == tabcnt.TabPages[2] && userRole != "Sales") ||
                (e.TabPage == tabcnt.TabPages[3] && userRole != "Admin"))
            {
                MessageBox.Show("You don't have permission to access this Tab!");
                e.Cancel = true;
            }
        }

        private void reg2_Click(object sender, EventArgs e)
        {
            string employeeName = epyn2.Text;
            string username = usn2.Text;
            string password = pwd2.Text;
            string role = "Sales";
            if (string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Employee (EmployeeName, Username, Password,Role ) VALUES (@EmployeeName, @Username, @Password,@Role )";

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@EmployeeName", employeeName);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);

                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Employee registed successfully!");
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

        private void reg3_Click(object sender, EventArgs e)
        {
            string employeeName = epyn3.Text;
            string username = usn3.Text;
            string password = pwd3.Text;
            string role = "Admin";

            if (string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Employee (EmployeeName, Username, Password, Role) VALUES (@EmployeeName, @Username, @Password, @Role)";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeName", employeeName);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Admin employee registered successfully!");
                MessageBox.Show("Your access passsword is: admin123");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            string employeeName = epyn.Text;
            string username = usn.Text;
            string password = pwd.Text;
            string role = "Warehouse";

            if (string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Employee (EmployeeName, Username, Password, Role) VALUES (@EmployeeName, @Username, @Password, @Role)";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeName", employeeName);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Warehouse employee registered successfully!");
                MessageBox.Show("Your access passsword is: warehouse123");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
       
    }
}
