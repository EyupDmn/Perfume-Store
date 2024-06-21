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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void buttonAddProduct_Click_1(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            int stock = Convert.ToInt32(textBoxStock.Text);

            string query = "INSERT INTO Products (ProductName, Price, Stock) VALUES (@ProductName, @Price, @Stock)";

            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Stock", stock);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Ürün başarıyla eklendi.");
            this.Close();
        }
    }
}
