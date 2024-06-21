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
    public partial class CreateOrderForm : Form
    {
        public CreateOrderForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadProducts();
        }

        private void LoadCustomers()
        {
            string query = "SELECT CustomerID, CONCAT(FirstName, ' ', LastName) AS FullName FROM Customers";

            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxCustomer.Items.Add(new { Text = reader["FullName"].ToString(), Value = reader["CustomerID"] });
                        }
                    }
                }
            }

            comboBoxCustomer.DisplayMember = "Text";
            comboBoxCustomer.ValueMember = "Value";
        }

        private void LoadProducts()
        {
            string query = "SELECT ProductID, ProductName FROM Products";

            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBoxProducts.Items.Add(new { Text = reader["ProductName"].ToString(), Value = reader["ProductID"] });
                        }
                    }
                }
            }

            listBoxProducts.DisplayMember = "Text";
            listBoxProducts.ValueMember = "Value";
        }

        private void buttonAddToOrder_Click_1(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null && numericUpDownQuantity.Value > 0)
            {
                var selectedProduct = (dynamic)listBoxProducts.SelectedItem;
                listBoxOrderDetails.Items.Add($"{selectedProduct.Text} - Miktar: {numericUpDownQuantity.Value}");
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin ve miktarı girin.");
            }
        }

        private void buttonCreateOrder_Click_1(object sender, EventArgs e)
        {
            if (comboBoxCustomer.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
                return;
            }

            if (listBoxOrderDetails.Items.Count == 0)
            {
                MessageBox.Show("Lütfen siparişe ürün ekleyin.");
                return;
            }

            var selectedCustomer = (dynamic)comboBoxCustomer.SelectedItem;
            int customerId = selectedCustomer.Value;
            decimal totalAmount = 0;

            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Sipariş Ekle
                    string insertOrderQuery = "INSERT INTO Orders (CustomerID, OrderDate, TotalAmount) VALUES (@CustomerID, @OrderDate, @TotalAmount)";
                    MySqlCommand insertOrderCommand = new MySqlCommand(insertOrderQuery, connection, transaction);
                    insertOrderCommand.Parameters.AddWithValue("@CustomerID", customerId);
                    insertOrderCommand.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    insertOrderCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    insertOrderCommand.ExecuteNonQuery();

                    int orderId = (int)insertOrderCommand.LastInsertedId;

                    // Sipariş Detayları Ekle
                    foreach (string item in listBoxOrderDetails.Items)
                    {
                        string[] parts = item.Split('-');
                        string productName = parts[0].Trim();
                        int quantity = int.Parse(parts[1].Split(':')[1].Trim());

                        string getProductQuery = "SELECT ProductID, Price FROM Products WHERE ProductName = @ProductName";
                        MySqlCommand getProductCommand = new MySqlCommand(getProductQuery, connection, transaction);
                        getProductCommand.Parameters.AddWithValue("@ProductName", productName);

                        int productId = 0;
                        decimal price = 0;
                        using (MySqlDataReader reader = getProductCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productId = reader.GetInt32("ProductID");
                                price = reader.GetDecimal("Price");
                            }
                        }

                        totalAmount += price * quantity;

                        string insertOrderDetailQuery = "INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Price) VALUES (@OrderID, @ProductID, @Quantity, @Price)";
                        MySqlCommand insertOrderDetailCommand = new MySqlCommand(insertOrderDetailQuery, connection, transaction);
                        insertOrderDetailCommand.Parameters.AddWithValue("@OrderID", orderId);
                        insertOrderDetailCommand.Parameters.AddWithValue("@ProductID", productId);
                        insertOrderDetailCommand.Parameters.AddWithValue("@Quantity", quantity);
                        insertOrderDetailCommand.Parameters.AddWithValue("@Price", price);
                        insertOrderDetailCommand.ExecuteNonQuery();
                    }

                    // Toplam tutarı güncelle
                    string updateOrderQuery = "UPDATE Orders SET TotalAmount = @TotalAmount WHERE OrderID = @OrderID";
                    MySqlCommand updateOrderCommand = new MySqlCommand(updateOrderQuery, connection, transaction);
                    updateOrderCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    updateOrderCommand.Parameters.AddWithValue("@OrderID", orderId);
                    updateOrderCommand.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Sipariş başarıyla oluşturuldu.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Sipariş oluşturulurken bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
