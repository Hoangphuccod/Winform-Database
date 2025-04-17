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
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Product";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvp.Rows.Count == 0)
                {
                    MessageBox.Show("No data available to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Save Products Data",
                    FileName = "Products.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new ClosedXML.Excel.XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Products");

                        for (int i = 0; i < dgvp.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvp.Columns[i].HeaderText;
                        }

                        for (int i = 0; i < dgvp.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvp.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dgvp.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            if (dgvp.SelectedRows.Count > 0)
            {
                string selectedID = dgvp.SelectedRows[0].Cells["ProductID"].Value.ToString();

                if (decimal.TryParse(price.Text, out decimal sellingPrice) && int.TryParse(quantity.Text, out int inventoryQty))
                {
                    string query = "UPDATE Product SET ProductName=@ProductName, SellingPrice=@SellingPrice, InventoryQuantity=@InventoryQuantity, Category=@Category WHERE ProductID=@ProductID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", pdn.Text);
                    command.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                    command.Parameters.AddWithValue("@InventoryQuantity", inventoryQty);
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
                    MessageBox.Show("Please enter valid numeric values for price and quantity.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btndel_Click_1(object sender, EventArgs e)
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

        private void btnseach_Click(object sender, EventArgs e)
        {
            string keyword = searchinput1.Text;

            string query = "SELECT * FROM Product WHERE ProductID LIKE @keyword";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvp.DataSource = table;
        }
    }
}
