namespace Parfum_Magazasi
{
    partial class AddProductForm
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
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProductName.Location = new System.Drawing.Point(37, 74);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(103, 25);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Ürün Adı:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPrice.Location = new System.Drawing.Point(17, 117);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(123, 25);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Ürün Fiyatı:";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStock.Location = new System.Drawing.Point(12, 158);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(128, 25);
            this.labelStock.TabIndex = 2;
            this.labelStock.Text = "Ürün Stoğu:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(146, 74);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(163, 22);
            this.textBoxProductName.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(146, 117);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(163, 22);
            this.textBoxPrice.TabIndex = 4;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(146, 162);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(163, 22);
            this.textBoxStock.TabIndex = 5;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddProduct.Location = new System.Drawing.Point(101, 239);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(150, 50);
            this.buttonAddProduct.TabIndex = 6;
            this.buttonAddProduct.Text = "Ekle";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click_1);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 399);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelProductName);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Button buttonAddProduct;
    }
}