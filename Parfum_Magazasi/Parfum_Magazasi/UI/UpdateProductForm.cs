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
    public partial class UpdateProductForm : Form
    {

        private int productId;
        public UpdateProductForm(int productID)
        {
            productId = productID;
            InitializeComponent();
            PopulateProductDetails(productID);
        }

        private void PopulateProductDetails(int productID)
        {
            string query = "SELECT ProductName, Price, Stock FROM Products WHERE ProductID = @ProductID";

            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productID);

                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxProductName.Text = reader["ProductName"].ToString();
                            textBoxPrice.Text = reader["Price"].ToString();
                            textBoxStock.Text = reader["Stock"].ToString();
                        }
                    }
                }
            }
        }

        private void buttonUpdateProduct_Click_1(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            int stock = Convert.ToInt32(textBoxStock.Text);

            string query = "UPDATE Products SET ProductName = @ProductName, Price = @Price, Stock = @Stock WHERE ProductID = @ProductID";

            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Stock", stock);
                    command.Parameters.AddWithValue("@ProductID", productId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Ürün başarıyla güncellendi.");
            this.Close();
        }
    }
}
