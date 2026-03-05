namespace AllTheProjects.All_Projects.Product_Management
{
    partial class frmProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.gbListOfProducts = new System.Windows.Forms.GroupBox();
            this.gbDetailsInfo = new System.Windows.Forms.GroupBox();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtdMadeIn = new System.Windows.Forms.TextBox();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtCodeProduct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListOfProducts = new System.Windows.Forms.ListBox();
            this.gbListOfProducts.SuspendLayout();
            this.gbDetailsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Management Of Products";
            // 
            // gbListOfProducts
            // 
            this.gbListOfProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbListOfProducts.Controls.Add(this.ListOfProducts);
            this.gbListOfProducts.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListOfProducts.Location = new System.Drawing.Point(12, 85);
            this.gbListOfProducts.Name = "gbListOfProducts";
            this.gbListOfProducts.Size = new System.Drawing.Size(348, 527);
            this.gbListOfProducts.TabIndex = 1;
            this.gbListOfProducts.TabStop = false;
            this.gbListOfProducts.Text = "List of products";
            // 
            // gbDetailsInfo
            // 
            this.gbDetailsInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDetailsInfo.Controls.Add(this.dtpExpiryDate);
            this.gbDetailsInfo.Controls.Add(this.btnSave);
            this.gbDetailsInfo.Controls.Add(this.btnDelete);
            this.gbDetailsInfo.Controls.Add(this.btnClose);
            this.gbDetailsInfo.Controls.Add(this.btnAddCategory);
            this.gbDetailsInfo.Controls.Add(this.txtdMadeIn);
            this.gbDetailsInfo.Controls.Add(this.txtPriceProduct);
            this.gbDetailsInfo.Controls.Add(this.txtNameProduct);
            this.gbDetailsInfo.Controls.Add(this.txtCodeProduct);
            this.gbDetailsInfo.Controls.Add(this.label7);
            this.gbDetailsInfo.Controls.Add(this.label6);
            this.gbDetailsInfo.Controls.Add(this.label5);
            this.gbDetailsInfo.Controls.Add(this.label4);
            this.gbDetailsInfo.Controls.Add(this.label3);
            this.gbDetailsInfo.Controls.Add(this.cbCategory);
            this.gbDetailsInfo.Controls.Add(this.label2);
            this.gbDetailsInfo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetailsInfo.Location = new System.Drawing.Point(366, 95);
            this.gbDetailsInfo.Name = "gbDetailsInfo";
            this.gbDetailsInfo.Size = new System.Drawing.Size(774, 527);
            this.gbDetailsInfo.TabIndex = 2;
            this.gbDetailsInfo.TabStop = false;
            this.gbDetailsInfo.Text = "Details Info";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiryDate.Location = new System.Drawing.Point(210, 385);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(535, 36);
            this.dtpExpiryDate.TabIndex = 11;
            this.dtpExpiryDate.Value = new System.DateTime(2025, 10, 14, 16, 38, 19, 0);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Bisque;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(78, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 55);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Bisque;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(325, 451);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 55);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Bisque;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(572, 451);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(195, 55);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Bisque;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCategory.Location = new System.Drawing.Point(550, 45);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(195, 55);
            this.btnAddCategory.TabIndex = 15;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // txtdMadeIn
            // 
            this.txtdMadeIn.Location = new System.Drawing.Point(210, 316);
            this.txtdMadeIn.Name = "txtdMadeIn";
            this.txtdMadeIn.Size = new System.Drawing.Size(535, 36);
            this.txtdMadeIn.TabIndex = 9;
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Location = new System.Drawing.Point(210, 250);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(535, 36);
            this.txtPriceProduct.TabIndex = 7;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(210, 184);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(535, 36);
            this.txtNameProduct.TabIndex = 5;
            // 
            // txtCodeProduct
            // 
            this.txtCodeProduct.Location = new System.Drawing.Point(210, 118);
            this.txtCodeProduct.Name = "txtCodeProduct";
            this.txtCodeProduct.Size = new System.Drawing.Size(535, 36);
            this.txtCodeProduct.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Code Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Made in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Expiry Date ";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(210, 55);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(307, 36);
            this.cbCategory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // ListOfProducts
            // 
            this.ListOfProducts.FormattingEnabled = true;
            this.ListOfProducts.ItemHeight = 28;
            this.ListOfProducts.Location = new System.Drawing.Point(6, 52);
            this.ListOfProducts.Name = "ListOfProducts";
            this.ListOfProducts.Size = new System.Drawing.Size(336, 452);
            this.ListOfProducts.TabIndex = 0;
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1178, 645);
            this.Controls.Add(this.gbDetailsInfo);
            this.Controls.Add(this.gbListOfProducts);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductManagement";
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.gbListOfProducts.ResumeLayout(false);
            this.gbDetailsInfo.ResumeLayout(false);
            this.gbDetailsInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbListOfProducts;
        private System.Windows.Forms.GroupBox gbDetailsInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodeProduct;
        private System.Windows.Forms.TextBox txtdMadeIn;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.ListBox ListOfProducts;
    }
}