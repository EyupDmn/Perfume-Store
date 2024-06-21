namespace Parfum_Magazasi
{
    partial class UpdateProductForm
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
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdateProduct.Location = new System.Drawing.Point(91, 226);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(126, 49);
            this.buttonUpdateProduct.TabIndex = 13;
            this.buttonUpdateProduct.Text = "Güncelle";
            this.buttonUpdateProduct.UseVisualStyleBackColor = true;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click_1);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(131, 168);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(158, 22);
            this.textBoxStock.TabIndex = 12;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(133, 112);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(156, 22);
            this.textBoxPrice.TabIndex = 11;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(133, 64);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(156, 22);
            this.textBoxProductName.TabIndex = 10;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStock.Location = new System.Drawing.Point(4, 165);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(121, 25);
            this.labelStock.TabIndex = 9;
            this.labelStock.Text = "Ürün Stoğu";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPrice.Location = new System.Drawing.Point(9, 108);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(116, 25);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Ürün Fiyatı";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProductName.Location = new System.Drawing.Point(29, 60);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(96, 25);
            this.labelProductName.TabIndex = 7;
            this.labelProductName.Text = "Ürün Adı";
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 345);
            this.Controls.Add(this.buttonUpdateProduct);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelProductName);
            this.Name = "UpdateProductForm";
            this.Text = "UpdateProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateProduct;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelProductName;
    }
}