namespace Parfum_Magazasi
{
    partial class MainForm
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(617, 326);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProduct.Location = new System.Drawing.Point(12, 371);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(150, 50);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Ürün Ekle";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(168, 371);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Ürün Sil";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click_1);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(324, 371);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(150, 50);
            this.btnUpdateProduct.TabIndex = 3;
            this.btnUpdateProduct.Text = "Ürün Güncelle";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click_1);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateOrder.Location = new System.Drawing.Point(479, 371);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(150, 50);
            this.btnCreateOrder.TabIndex = 4;
            this.btnCreateOrder.Text = "Sipariş Oluştur";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnCreateOrder;
    }
}