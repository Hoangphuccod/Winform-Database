using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsAppDemo
{
    public partial class login : Form
    {
        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private string userRole = "";

        public login()
        {
            InitializeComponent();
            tabControl1.Selecting += tabControl1_Selecting;
            this.FormClosed += login_FormClosed;
        }

        private bool ValidateLogin(string username, string password, string role)
        {
            using (SqlConnection connection = new SqlConnection("Server=MONARCH-31205\\SQLEXPRESS; Database=StoreX; Integrated Security=true;"))
            {
                string query = "SELECT COUNT(*) FROM Employee WHERE Username = @Username AND Password = @Password AND Role = @Role";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", role);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (string.IsNullOrEmpty(userRole))
            {
                MessageBox.Show("Current role: " + userRole);
                string password = Prompt.ShowDialog("Enter password:", "Authentication");

                if (password == "admin123")
                    userRole = "Admin";
                else if (password == "sale123")
                    userRole = "Sales";
                else if (password == "warehouse123")
                    userRole = "Warehouse";
                else
                {
                    MessageBox.Show("Incorrect password!");
                    e.Cancel = true;
                    return;
                }
            }

            if ((e.TabPage == tabControl1.TabPages[3] && userRole != "Admin") ||
                (e.TabPage == tabControl1.TabPages[2] && userRole != "Sales") ||
                (e.TabPage == tabControl1.TabPages[1] && userRole != "Warehouse"))
            {
                MessageBox.Show("You do not have permission to access this tab!");
                e.Cancel = true;
            }
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 300,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };

                Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 250 };
                TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 250, PasswordChar = '*' };
                Button confirmation = new Button() { Text = "OK", Left = 100, Width = 100, Top = 80, DialogResult = DialogResult.OK };

                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
            }
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            string username = usn3.Text;
            string password = pwd3.Text;
            string role = "Warehouse";

            if (ValidateLogin(username, password, role))
            {
                MessageBox.Show("Warehouse login successful!");
                this.Hide();
                warehouse mainForm = new warehouse();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect login information!");
            }
        }

        private void btnlog2_Click(object sender, EventArgs e)
        {
            string username = usn2.Text;
            string password = pwd2.Text;
            string role = "Sales";

            if (ValidateLogin(username, password, role))
            {
                MessageBox.Show("Sale login successful!");
                this.Hide();
                sales mainForm = new sales();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect login information!");
            }
        }

        private void btnlog3_Click(object sender, EventArgs e)
        {
            string username = usn.Text;
            string password = pwd.Text;
            string role = "Admin";

            if (ValidateLogin(username, password, role))
            {
                MessageBox.Show("Admin login successful!");
                this.Hide();
                admin mainForm = new admin();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect login information!");
            }
        }
        
    }
}
