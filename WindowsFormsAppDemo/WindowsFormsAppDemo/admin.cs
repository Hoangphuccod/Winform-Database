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
    public partial class admin : Form
    {
        private void admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        SqlConnection connection;

        public admin()
        {
            InitializeComponent();
            this.FormClosed += admin_FormClosed;
        }

        private void admin_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Server=MONARCH-31205\\SQLEXPRESS; Database=StoreX; Integrated Security=true;");
            LoadData();
            LoadData2(); 
            LoadData3();
        }
        //Product
        private void LoadData()
        {
            string query = "SELECT * FROM Product";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvp.DataSource = table;
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            if (dgvp.SelectedRows.Count > 0)
            {
                string selectedID = dgvp.SelectedRows[0].Cells["ProductID"].Value.ToString();

                string query = "UPDATE Product SET ProductName=@ProductName, SellingPrice=@SellingPrice, InventoryQuantity=@InventoryQuantity, Category=@Category WHERE ProductID=@ProductID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", pdn.Text);
                command.Parameters.AddWithValue("@SellingPrice", price.Text);
                command.Parameters.AddWithValue("@InventoryQuantity", quantity.Text);
                command.Parameters.AddWithValue("@Category", ctgr.Text);
                command.Parameters.AddWithValue("@ProductID", selectedID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                LoadData();
                MessageBox.Show("Updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            string keyword = searchinput.Text;

            string query = "SELECT * FROM Product WHERE ProductID LIKE @keyword";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvp.DataSource = table;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (dgvp.SelectedRows.Count > 0)
            {
                string selectedID = dgvp.SelectedRows[0].Cells["ProductID"].Value.ToString();

                string query = "DELETE FROM Product WHERE ProductID = @ProductID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", selectedID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                LoadData();
                MessageBox.Show("Deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pdn.Text) || string.IsNullOrEmpty(price.Text) ||
        string.IsNullOrEmpty(quantity.Text) || string.IsNullOrEmpty(ctgr.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Product (ProductName, SellingPrice, InventoryQuantity, Category) " +
                           "VALUES (@ProductName, @SellingPrice, @InventoryQuantity, @Category)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductName", pdn.Text);
            command.Parameters.AddWithValue("@SellingPrice", price.Text);
            command.Parameters.AddWithValue("@InventoryQuantity", quantity.Text);
            command.Parameters.AddWithValue("@Category", ctgr.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            LoadData();
            MessageBox.Show("Added successfully!");
        }

        private void btnsort_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Product ORDER BY SellingPrice ASC";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvp.DataSource = table;
        }

        private void btnflt_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbb.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("Please select a category to filter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvp.DataSource];
            currencyManager.SuspendBinding(); 
            foreach (DataGridViewRow row in dgvp.Rows)
            {
                if (row.IsNewRow) continue;

                var categoryCell = row.Cells["Category"].Value?.ToString().Trim().ToLower();
                row.Visible = (categoryCell == selectedCategory);
            }

            currencyManager.ResumeBinding(); 
        }


        private void btnref_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Product";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvp.DataSource = table;

            foreach (DataGridViewColumn column in dgvp.Columns)
            {
                column.Visible = true;
            }
        }
        //Employee
        private void LoadData2()
        {
            string query = "SELECT * FROM Employee";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgve.DataSource = table;
            }
        }
        private void btnadd2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emn.Text) || string.IsNullOrWhiteSpace(role1.Text) ||
                string.IsNullOrWhiteSpace(eusn.Text) || string.IsNullOrWhiteSpace(epwd.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Employee (EmployeeName, Role, Username, Password) VALUES (@EmployeeName, @Role, @Username, @Password)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EmployeeName", emn.Text);
                command.Parameters.AddWithValue("@Role", role1.Text);
                command.Parameters.AddWithValue("@Username", eusn.Text);
                command.Parameters.AddWithValue("@Password", epwd.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            LoadData2();
            MessageBox.Show("Added successfully!");
        }

        private void btnfil_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbb.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("Please select a category to filter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvp.DataSource];
            currencyManager.SuspendBinding();
            foreach (DataGridViewRow row in dgvp.Rows)
            {
                if (row.IsNewRow) continue;

                var categoryCell = row.Cells["Category"].Value?.ToString().Trim().ToLower();
                row.Visible = (categoryCell == selectedCategory);
            }

            currencyManager.ResumeBinding();
        }

        private void btnsort2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Employee ORDER BY Role ASC";
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgve.DataSource = table;
            }
        }

        private void cmbb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColumn = cmbb2.Text;

            foreach (DataGridViewColumn column in dgve.Columns)
            {
                column.Visible = (column.Name == selectedColumn);
            }
        }

        private void SearchEmployee(string keyword)
        {
            string query = "SELECT * FROM Employee WHERE EmployeeID LIKE @keyword";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgve.DataSource = table;
                }
            }
        }

        private void seachinput2_TextChanged(object sender, EventArgs e)
        {
            SearchEmployee(searchinput2.Text);
        }

        private void btnseach2_Click(object sender, EventArgs e)
        {
            SearchEmployee(searchinput2.Text);
        }

        private void btnupd2_Click(object sender, EventArgs e)
        {
            if (dgve.SelectedRows.Count > 0)
            {
                string selectedID = dgve.SelectedRows[0].Cells["EmployeeID"].Value.ToString();

                string query = "UPDATE Employee SET EmployeeName=@EmployeeName, Role=@Role, Username=@Username, Password=@Password WHERE EmployeeID=@EmployeeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeName", emn.Text);
                    command.Parameters.AddWithValue("@Role", role1.Text);
                    command.Parameters.AddWithValue("@Username", eusn.Text);
                    command.Parameters.AddWithValue("@Password", epwd.Text);
                    command.Parameters.AddWithValue("@EmployeeID", selectedID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                LoadData2();
                MessageBox.Show("Updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btndel2_Click(object sender, EventArgs e)
        {
            if (dgve.SelectedRows.Count > 0)
            {
                string selectedID = dgve.SelectedRows[0].Cells["EmployeeID"].Value.ToString();

                string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", selectedID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                LoadData2();
                MessageBox.Show("Deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnref2_Click(object sender, EventArgs e)
        {
            LoadData2();
            foreach (DataGridViewColumn column in dgve.Columns)
            {
                column.Visible = true;
            }
        }
        //Customer
        private void LoadData3()
        {
            string query = "SELECT * FROM Customer";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvc.DataSource = table;
            }
        }

        private void btnadd3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ctmn.Text) || string.IsNullOrWhiteSpace(pen.Text) || string.IsNullOrWhiteSpace(pwd3.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Customer (CustomerName, PhoneNumber, Password) VALUES (@CustomerName, @PhoneNumber, @Password)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CustomerName", ctmn.Text);
                command.Parameters.AddWithValue("@PhoneNumber", pen.Text);
                command.Parameters.AddWithValue("@Password", pwd3.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            LoadData3();
            MessageBox.Show("Added successfully!");
        }

        private void SearchCustomer(string keyword)
        {
            string query = "SELECT * FROM Customer WHERE CustomerID LIKE @keyword";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvc.DataSource = table;
                }
            }
        }

        private void searchinpu3_TextChanged(object sender, EventArgs e)
        {
            SearchCustomer(searchinpu3.Text);
        }

        private void btnsearch3_Click(object sender, EventArgs e)
        {
            SearchCustomer(searchinpu3.Text);
        }

        private void btnupd3_Click(object sender, EventArgs e)
        {
            if (dgvc.SelectedRows.Count > 0)
            {
                string selectedID = dgvc.SelectedRows[0].Cells["CustomerID"].Value.ToString();

                string query = "UPDATE Customer SET CustomerName=@CustomerName, PhoneNumber=@PhoneNumber, Password=@Password WHERE CustomerID=@CustomerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", ctmn.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", pen.Text);
                    command.Parameters.AddWithValue("@Password", pwd3.Text);
                    command.Parameters.AddWithValue("@CustomerID", selectedID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                LoadData3();
                MessageBox.Show("Updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btndel3_Click(object sender, EventArgs e)
        {
            if (dgvc.SelectedRows.Count > 0)
            {
                string selectedID = dgvc.SelectedRows[0].Cells["CustomerID"].Value.ToString();

                string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", selectedID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                LoadData3();
                MessageBox.Show("Deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnref3_Click(object sender, EventArgs e)
        {
            LoadData3();
            foreach (DataGridViewColumn column in dgvc.Columns)
            {
                column.Visible = true;
            }
        }
    }
}
