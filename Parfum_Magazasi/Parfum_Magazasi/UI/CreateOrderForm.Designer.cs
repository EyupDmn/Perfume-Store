namespace Parfum_Magazasi
{
    partial class CreateOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelProducts = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelOrderDetails = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.listBoxOrderDetails = new System.Windows.Forms.ListBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCustomer.Location = new System.Drawing.Point(12, 25);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(114, 25);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "Müşteriler:";
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProducts.Location = new System.Drawing.Point(310, 25);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(89, 25);
            this.labelProducts.TabIndex = 1;
            this.labelProducts.Text = "Ürünler:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelQuantity.Location = new System.Drawing.Point(48, 84);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(78, 25);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "Miktar:";
            // 
            // labelOrderDetails
            // 
            this.labelOrderDetails.AutoSize = true;
            this.labelOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderDetails.Location = new System.Drawing.Point(12, 169);
            this.labelOrderDetails.Name = "labelOrderDetails";
            this.labelOrderDetails.Size = new System.Drawing.Size(177, 25);
            this.labelOrderDetails.TabIndex = 3;
            this.labelOrderDetails.Text = "Sipariş Detayları:";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(132, 25);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(142, 24);
            this.comboBoxCustomer.TabIndex = 4;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(415, 25);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(166, 84);
            this.listBoxProducts.TabIndex = 5;
            // 
            // listBoxOrderDetails
            // 
            this.listBoxOrderDetails.FormattingEnabled = true;
            this.listBoxOrderDetails.ItemHeight = 16;
            this.listBoxOrderDetails.Location = new System.Drawing.Point(12, 197);
            this.listBoxOrderDetails.Name = "listBoxOrderDetails";
            this.listBoxOrderDetails.Size = new System.Drawing.Size(569, 100);
            this.listBoxOrderDetails.TabIndex = 6;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(132, 84);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(141, 22);
            this.numericUpDownQuantity.TabIndex = 7;
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddToOrder.Location = new System.Drawing.Point(299, 79);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(100, 40);
            this.buttonAddToOrder.TabIndex = 8;
            this.buttonAddToOrder.Text = "Sepete Ekle";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click_1);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCreateOrder.Location = new System.Drawing.Point(228, 320);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(121, 40);
            this.buttonCreateOrder.TabIndex = 9;
            this.buttonCreateOrder.Text = "Sipariş Oluştur";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click_1);
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 383);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.buttonAddToOrder);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.listBoxOrderDetails);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.labelOrderDetails);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.labelCustomer);
            this.Name = "CreateOrderForm";
            this.Text = "CreateOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelOrderDetails;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.ListBox listBoxOrderDetails;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Button buttonCreateOrder;
    }
}