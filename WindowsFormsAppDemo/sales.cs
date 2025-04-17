using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsAppDemo
{
    public partial class sales : Form
    {
        private void sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        SqlConnection connection;

        public sales()
        {
            InitializeComponent();
            this.FormClosed += sales_FormClosed;
        }

        private void sales_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Server=MONARCH-31205\\SQLEXPRESS; Database=StoreX; Integrated Security=true;");
            LoadData();
            LoadData3();
            LoadDataSalesDetail();
            LoadDataHistory();
        }

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

        private void LoadDataSalesDetail()
        {
            string query = "SELECT * FROM SalesDetails";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvo.DataSource = table;
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

        private void btnsearch2_Click(object sender, EventArgs e)
        {
            string productName = searchinput2.Text;
            string query = "SELECT * FROM SalesDetails WHERE ProductName LIKE @ProductName";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductName", "%" + productName + "%");
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvo.DataSource = table;
                }
            }
        }

        private void btnupd3_Click_1(object sender, EventArgs e)
        {
            if (dgvo.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvo.SelectedRows[0];
                string productName = prdn.Text;
                string quantity = qtt.Text;
                string price = prc.Text;

                string query = "UPDATE SalesDetails SET ProductName = @ProductName, Quantity = @Quantity, Price = @Price WHERE SalesDetailID = @SalesDetailID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@ProductName", productName);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    LoadDataSalesDetail();
                }
            }
        }

        private void btndel3_Click_1(object sender, EventArgs e)
        {
            if (dgvo.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvo.SelectedRows[0];
                int salesDetailID = Convert.ToInt32(row.Cells["SalesDetailID"].Value);

                string query = "DELETE FROM SalesDetails WHERE SalesDetailID = @SalesDetailID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SalesDetailID", salesDetailID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    LoadDataSalesDetail();
                }
            }
        }

        private void btnref3_Click_1(object sender, EventArgs e)
        {
            LoadDataSalesDetail();
        }
        //history
        private void LoadDataHistory()
        {
            string query = "SELECT * FROM Sales";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvh.DataSource = table;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = txt.Text.Trim();
            string query = "SELECT * FROM Customer WHERE CustomerID LIKE @keyword";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvh.DataSource = table;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Customer";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvh.DataSource = table;
            }
            LoadDataHistory();
        }

        private void btnupd2_Click(object sender, EventArgs e)
        {
            if (dgvh.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvh.SelectedRows[0];
                int salesID = Convert.ToInt32(row.Cells["SalesID"].Value);

                string productName = prdn.Text.Trim();
                string quantity = qtt.Text.Trim();
                string price = prc.Text.Trim();

                string query = "UPDATE Sales SET ProductName = @ProductName, Quantity = @Quantity, Price = @Price WHERE SalesID = @SalesID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@SalesID", salesID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    LoadDataHistory();
                    MessageBox.Show("Updated successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btndel2_Click(object sender, EventArgs e)
        {
            if (dgvh.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvh.SelectedRows[0];

                    int salesID = Convert.ToInt32(row.Cells[0].Value);

                    string query = "DELETE FROM Sales WHERE SalesID = @SalesID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SalesID", salesID);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        LoadDataHistory();
                        MessageBox.Show("Deleted successfully!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }


        private void btnref2_Click(object sender, EventArgs e)
        {
            LoadDataHistory();
            foreach (DataGridViewColumn column in dgvh.Columns)
            {
                column.Visible = true;
            }
            MessageBox.Show("Refreshed!");
        }

        private void btnadd2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(prdn.Text) || string.IsNullOrWhiteSpace(qtt.Text) || string.IsNullOrWhiteSpace(prc.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string productName = prdn.Text.Trim();
            string quantity = qtt.Text.Trim();
            string price = prc.Text.Trim();

            string query = "INSERT INTO SalesDetails (ProductName, Quantity, Price) VALUES (@ProductName, @Quantity, @Price)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Price", price);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                LoadDataSalesDetail();
                MessageBox.Show("Added successfully!");
            }
        }
        private void LoadData()
        {
            string query = "SELECT * FROM Product";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvp.DataSource = table;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pdn.Text) || string.IsNullOrEmpty(prc2.Text) ||
            string.IsNullOrEmpty(qtt2.Text) || string.IsNullOrEmpty(ctgr.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO Product (ProductName, SellingPrice, InventoryQuantity, Category) " +
                           "VALUES (@ProductName, @SellingPrice, @InventoryQuantity, @Category)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductName", pdn.Text);
            command.Parameters.AddWithValue("@SellingPrice", prc2.Text);
            command.Parameters.AddWithValue("@InventoryQuantity", qtt2.Text);
            command.Parameters.AddWithValue("@Category", ctgr.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            LoadData();
            MessageBox.Show("Added successfully!");
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            if (dgvp.SelectedRows.Count > 0)
            {
                string selectedID = dgvp.SelectedRows[0].Cells["ProductID"].Value.ToString();

                string query = "UPDATE Product SET ProductName=@ProductName, SellingPrice=@SellingPrice, InventoryQuantity=@InventoryQuantity, Category=@Category WHERE ProductID=@ProductID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", pdn.Text);
                command.Parameters.AddWithValue("@SellingPrice", prc2.Text);
                command.Parameters.AddWithValue("@InventoryQuantity", qtt2.Text);
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

        private void Statistic_Click(object sender, EventArgs e)
        {

            DateTime startDate = bgn.Value.Date;
            DateTime endDate = end.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be greater than end date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
            SELECT 
                SalesID, 
                ProductName, 
                TotalAmount, 
                SaleDate, 
                CustomerID
            FROM Sales
            WHERE SaleDate BETWEEN @startDate AND @endDate
            ORDER BY SaleDate";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@startDate", startDate);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@endDate", endDate);
            sqlDataAdapter.Fill(dataTable);

            dgvs.DataSource = dataTable;

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}