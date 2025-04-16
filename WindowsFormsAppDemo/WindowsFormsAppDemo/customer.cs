using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsAppDemo
{
    public partial class customer : Form
    {
        private void customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        SqlConnection connection;

        public customer()
        {
            InitializeComponent();
            this.FormClosed += customer_FormClosed;
        }

        private void customer_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Server=MONARCH-31205\\SQLEXPRESS; Database=StoreX; Integrated Security=true;");
            LoadData();
            LoadDataHistory();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Product";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
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

        private void btnsort_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Product ORDER BY SellingPrice ASC";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvp.DataSource = table;
        }

        private void searchinput_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(searchinput.Text);
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            SearchProduct(searchinput.Text);
        }

        private void SearchProduct(string keyword)
        {
            string query = "SELECT * FROM Product WHERE ProductName LIKE @keyword";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvp.DataSource = table;
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (dgvp.SelectedRows.Count > 0)
            {
                string selectedID = dgvp.SelectedRows[0].Cells["ProductID"].Value.ToString();

                string query = "DELETE FROM Product WHERE ProductID = @ProductID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", selectedID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    LoadData();
                    MessageBox.Show("Deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void btnref_Click(object sender, EventArgs e)
        {
            LoadData();
            foreach (DataGridViewColumn column in dgvp.Columns)
            {
                column.Visible = true;
            }
        }

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
            string query = "SELECT * FROM Sales WHERE CustomerID LIKE @keyword";

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            string customerQuery = "SELECT * FROM Sales";
            using (SqlDataAdapter customerAdapter = new SqlDataAdapter(customerQuery, connection))
            {
                DataTable customerTable = new DataTable();
                customerAdapter.Fill(customerTable);
                dgvh.DataSource = customerTable;
            }

            LoadDataHistory(); 
        }

    }
}
