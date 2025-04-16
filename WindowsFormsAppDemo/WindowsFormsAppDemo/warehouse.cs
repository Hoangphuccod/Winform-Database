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
    public partial class warehouse : Form
    {
        private void warehouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        SqlConnection connection;
        public warehouse()
        {
            InitializeComponent();
            this.FormClosed += warehouse_FormClosed;
        }
        private void warehouse_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Server=MONARCH-31205\\SQLEXPRESS; Database=StoreX; Integrated Security=true;");
            LoadData();
            LoadDataSalesDetail();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Product";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvp.DataSource = table;
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
        private void btnflt_Click_1(object sender, EventArgs e)
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

        private void btnref_Click_1(object sender, EventArgs e)
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

        private void btnsort_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Product ORDER BY SellingPrice ASC";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvp.DataSource = table;
        }

        private void btnupd_Click_1(object sender, EventArgs e)
        {
            if (dgvo.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvo.SelectedRows[0];
                int salesDetailID = Convert.ToInt32(row.Cells["SalesDetailID"].Value);
                string salesID = prdn.Text;
                string quantity = qtt.Text;
                string price = prc.Text;

                string query = "UPDATE SalesDetail SET SalesID = @SalesID, Quantity = @Quantity, Price = @Price WHERE SalesDetailID = @SalesDetailID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SalesID", salesID);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@SalesDetailID", salesDetailID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    LoadDataSalesDetail();
                }
            }
        }

        private void btndel_Click_1(object sender, EventArgs e)
        {
            if (dgvo.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvo.SelectedRows[0];
                int salesDetailID = Convert.ToInt32(row.Cells["SalesDetailID"].Value);

                string query = "DELETE FROM SalesDetail WHERE SalesDetailID = @SalesDetailID";

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

        private void btnseach_Click_1(object sender, EventArgs e)
        {
            string keyword = searchinput.Text.Trim();
            if (keyword == "") return;

            string query = "SELECT * FROM Product WHERE ProductID LIKE @ProductID";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@ProductID", "%" + keyword + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvo.DataSource = table;
            }
        }

        private void btnupd2_Click(object sender, EventArgs e)
        {
            if (dgvo.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvo.SelectedRows[0].Cells["SalesDetailID"].Value);
                string query = "UPDATE SalesDetails SET ProductName = @ProductName, Quantity = @Quantity, Price = @Price WHERE SalesDetailID = @SalesDetailID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductName", prdn.Text.Trim());
                    cmd.Parameters.AddWithValue("@Quantity", qtt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Price", prc.Text.Trim());
                    cmd.Parameters.AddWithValue("@SalesDetailID", id);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                LoadDataSalesDetail();
                MessageBox.Show("Updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnsearch2_Click(object sender, EventArgs e)
        {
            string keyword = searchinput2.Text.Trim();
            string query = "SELECT * FROM SalesDetails WHERE SalesDetailID LIKE @keyword";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvo.DataSource = table;
                }
            }
        }

        private void btndel2_Click(object sender, EventArgs e)
        {
            if (dgvo.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvo.SelectedRows[0].Cells["SalesDetailID"].Value);
                string query = "DELETE FROM SalesDetails WHERE SalesDetailID = @SalesDetailID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SalesDetailID", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                LoadDataSalesDetail();
                MessageBox.Show("Deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnref2_Click(object sender, EventArgs e)
        {
            LoadDataSalesDetail();
            foreach (DataGridViewColumn col in dgvo.Columns)
            {
                col.Visible = true;
            }
            MessageBox.Show("Refreshed!");
        }

    }
}
