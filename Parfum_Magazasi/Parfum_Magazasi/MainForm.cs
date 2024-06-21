using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parfum_Magazasi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void DeleteProduct(int productID)
        {
            string query = "DELETE FROM Products WHERE ProductID = @ProductID";
            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productID);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void LoadProducts()
        {
            string query = "SELECT * FROM Products";
            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewProducts.DataSource = dataTable;
                }
            }
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            LoadProducts();
        }

        private void btnDeleteProduct_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells["ProductID"].Value);
                DeleteProduct(productId);
                MessageBox.Show("Ürün başarıyla silindi.");
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin.");
            }
        }

        private void btnUpdateProduct_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells["ProductID"].Value);
                UpdateProductForm updateProductForm = new UpdateProductForm(productId);
                updateProductForm.ShowDialog();
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir ürün seçin.");
            }
        }

        private void btnCreateOrder_Click_1(object sender, EventArgs e)
        {
            CreateOrderForm createOrderForm = new CreateOrderForm();
            createOrderForm.ShowDialog();
        }
    }
}
