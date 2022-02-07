namespace CST_Project_1
{
    partial class Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            this.AddItem_btn = new System.Windows.Forms.Button();
            this.RestockItem_btn = new System.Windows.Forms.Button();
            this.RemoveItem_btn = new System.Windows.Forms.Button();
            this.NameItem_lbl = new System.Windows.Forms.Label();
            this.Quantity_lbl = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exitApp_lbl = new System.Windows.Forms.Label();
            this.ProductName_txt = new System.Windows.Forms.TextBox();
            this.ProductPrice_txt = new System.Windows.Forms.TextBox();
            this.ProductQuantity_txt = new System.Windows.Forms.TextBox();
            this.ProductBrand_lbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProductBrand_txt = new System.Windows.Forms.TextBox();
            this.Manage_Products = new System.Windows.Forms.Label();
            this.Category_lbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ItemDisplay_gridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDisplay_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // AddItem_btn
            // 
            this.AddItem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem_btn.Location = new System.Drawing.Point(70, 608);
            this.AddItem_btn.Margin = new System.Windows.Forms.Padding(2);
            this.AddItem_btn.Name = "AddItem_btn";
            this.AddItem_btn.Size = new System.Drawing.Size(214, 34);
            this.AddItem_btn.TabIndex = 1;
            this.AddItem_btn.Text = "Add ";
            this.AddItem_btn.UseVisualStyleBackColor = true;
            this.AddItem_btn.Click += new System.EventHandler(this.AddItem_btn_Click);
            // 
            // RestockItem_btn
            // 
            this.RestockItem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestockItem_btn.Location = new System.Drawing.Point(70, 777);
            this.RestockItem_btn.Margin = new System.Windows.Forms.Padding(2);
            this.RestockItem_btn.Name = "RestockItem_btn";
            this.RestockItem_btn.Size = new System.Drawing.Size(214, 34);
            this.RestockItem_btn.TabIndex = 1;
            this.RestockItem_btn.Text = "Edit";
            this.RestockItem_btn.UseVisualStyleBackColor = true;
            // 
            // RemoveItem_btn
            // 
            this.RemoveItem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItem_btn.Location = new System.Drawing.Point(70, 715);
            this.RemoveItem_btn.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveItem_btn.Name = "RemoveItem_btn";
            this.RemoveItem_btn.Size = new System.Drawing.Size(214, 34);
            this.RemoveItem_btn.TabIndex = 1;
            this.RemoveItem_btn.Text = "Remove";
            this.RemoveItem_btn.UseVisualStyleBackColor = true;
            this.RemoveItem_btn.Click += new System.EventHandler(this.RemoveItem_btn_Click);
            // 
            // NameItem_lbl
            // 
            this.NameItem_lbl.AutoSize = true;
            this.NameItem_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameItem_lbl.Location = new System.Drawing.Point(11, 275);
            this.NameItem_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameItem_lbl.Name = "NameItem_lbl";
            this.NameItem_lbl.Size = new System.Drawing.Size(76, 20);
            this.NameItem_lbl.TabIndex = 2;
            this.NameItem_lbl.Text = "Product:";
            // 
            // Quantity_lbl
            // 
            this.Quantity_lbl.AutoSize = true;
            this.Quantity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_lbl.Location = new System.Drawing.Point(11, 391);
            this.Quantity_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quantity_lbl.Name = "Quantity_lbl";
            this.Quantity_lbl.Size = new System.Drawing.Size(81, 20);
            this.Quantity_lbl.TabIndex = 2;
            this.Quantity_lbl.Text = "Quantity:";
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_lbl.Location = new System.Drawing.Point(19, 453);
            this.Price_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(54, 20);
            this.Price_lbl.TabIndex = 2;
            this.Price_lbl.Text = "Price:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(126, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(126, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(126, 551);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 6;
            // 
            // exitApp_lbl
            // 
            this.exitApp_lbl.AutoSize = true;
            this.exitApp_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApp_lbl.Location = new System.Drawing.Point(1414, 9);
            this.exitApp_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exitApp_lbl.Name = "exitApp_lbl";
            this.exitApp_lbl.Size = new System.Drawing.Size(21, 20);
            this.exitApp_lbl.TabIndex = 2;
            this.exitApp_lbl.Text = "X";
            this.exitApp_lbl.Click += new System.EventHandler(this.exitApp_lbl_Click);
            // 
            // ProductName_txt
            // 
            this.ProductName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName_txt.Location = new System.Drawing.Point(126, 261);
            this.ProductName_txt.Name = "ProductName_txt";
            this.ProductName_txt.Size = new System.Drawing.Size(200, 26);
            this.ProductName_txt.TabIndex = 7;
            // 
            // ProductPrice_txt
            // 
            this.ProductPrice_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPrice_txt.Location = new System.Drawing.Point(126, 439);
            this.ProductPrice_txt.Name = "ProductPrice_txt";
            this.ProductPrice_txt.Size = new System.Drawing.Size(200, 26);
            this.ProductPrice_txt.TabIndex = 7;
            // 
            // ProductQuantity_txt
            // 
            this.ProductQuantity_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantity_txt.Location = new System.Drawing.Point(126, 382);
            this.ProductQuantity_txt.Name = "ProductQuantity_txt";
            this.ProductQuantity_txt.Size = new System.Drawing.Size(200, 26);
            this.ProductQuantity_txt.TabIndex = 7;
            // 
            // ProductBrand_lbl
            // 
            this.ProductBrand_lbl.AutoSize = true;
            this.ProductBrand_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBrand_lbl.Location = new System.Drawing.Point(11, 340);
            this.ProductBrand_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductBrand_lbl.Name = "ProductBrand_lbl";
            this.ProductBrand_lbl.Size = new System.Drawing.Size(62, 20);
            this.ProductBrand_lbl.TabIndex = 2;
            this.ProductBrand_lbl.Text = "Brand:";
            this.ProductBrand_lbl.Click += new System.EventHandler(this.ProductBrand_lbl_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(126, 367);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 2);
            this.panel4.TabIndex = 6;
            // 
            // ProductBrand_txt
            // 
            this.ProductBrand_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBrand_txt.Location = new System.Drawing.Point(126, 326);
            this.ProductBrand_txt.Name = "ProductBrand_txt";
            this.ProductBrand_txt.Size = new System.Drawing.Size(200, 26);
            this.ProductBrand_txt.TabIndex = 7;
            // 
            // Manage_Products
            // 
            this.Manage_Products.AutoSize = true;
            this.Manage_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_Products.Location = new System.Drawing.Point(586, 9);
            this.Manage_Products.Name = "Manage_Products";
            this.Manage_Products.Size = new System.Drawing.Size(316, 44);
            this.Manage_Products.TabIndex = 8;
            this.Manage_Products.Text = "Manage Products";
            // 
            // Category_lbl
            // 
            this.Category_lbl.AutoSize = true;
            this.Category_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_lbl.Location = new System.Drawing.Point(11, 512);
            this.Category_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Category_lbl.Name = "Category_lbl";
            this.Category_lbl.Size = new System.Drawing.Size(86, 20);
            this.Category_lbl.TabIndex = 2;
            this.Category_lbl.Text = "Category:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 512);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Select Category";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Hygene",
            "Supplements",
            "Gear",
            "Snacks"});
            this.comboBox2.Location = new System.Drawing.Point(1027, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 24);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "Select Category";
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.Location = new System.Drawing.Point(1242, 104);
            this.Refresh_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(146, 34);
            this.Refresh_btn.TabIndex = 1;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(126, 302);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 2);
            this.panel5.TabIndex = 6;
            // 
            // ItemDisplay_gridview
            // 
            this.ItemDisplay_gridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemDisplay_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDisplay_gridview.Location = new System.Drawing.Point(332, 143);
            this.ItemDisplay_gridview.Name = "ItemDisplay_gridview";
            this.ItemDisplay_gridview.Size = new System.Drawing.Size(1103, 668);
            this.ItemDisplay_gridview.TabIndex = 11;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1456, 871);
            this.Controls.Add(this.ItemDisplay_gridview);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Manage_Products);
            this.Controls.Add(this.ProductQuantity_txt);
            this.Controls.Add(this.ProductBrand_txt);
            this.Controls.Add(this.ProductPrice_txt);
            this.Controls.Add(this.ProductName_txt);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ProductBrand_lbl);
            this.Controls.Add(this.exitApp_lbl);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.Quantity_lbl);
            this.Controls.Add(this.Category_lbl);
            this.Controls.Add(this.NameItem_lbl);
            this.Controls.Add(this.RemoveItem_btn);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.RestockItem_btn);
            this.Controls.Add(this.AddItem_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemDisplay_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddItem_btn;
        private System.Windows.Forms.Button RestockItem_btn;
        private System.Windows.Forms.Button RemoveItem_btn;
        private System.Windows.Forms.Label NameItem_lbl;
        private System.Windows.Forms.Label Quantity_lbl;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label exitApp_lbl;
        private System.Windows.Forms.TextBox ProductName_txt;
        private System.Windows.Forms.TextBox ProductPrice_txt;
        private System.Windows.Forms.TextBox ProductQuantity_txt;
        private System.Windows.Forms.Label ProductBrand_lbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ProductBrand_txt;
        private System.Windows.Forms.Label Manage_Products;
        private System.Windows.Forms.Label Category_lbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView ItemDisplay_gridview;
    }
}