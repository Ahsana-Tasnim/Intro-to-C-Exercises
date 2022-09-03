namespace GroceryStore
{
    partial class frmGroceryStore
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboProductType = new System.Windows.Forms.ComboBox();
            this.txtNewProduct = new System.Windows.Forms.TextBox();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstActiveProducts = new System.Windows.Forms.ListBox();
            this.lstDiscontinuedProducts = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumActive = new System.Windows.Forms.Label();
            this.lblNumDiscontinued = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Type";
            // 
            // cboProductType
            // 
            this.cboProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductType.FormattingEnabled = true;
            this.cboProductType.Location = new System.Drawing.Point(83, 79);
            this.cboProductType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Size = new System.Drawing.Size(199, 24);
            this.cboProductType.TabIndex = 1;
            // 
            // txtNewProduct
            // 
            this.txtNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewProduct.Location = new System.Drawing.Point(83, 172);
            this.txtNewProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewProduct.Name = "txtNewProduct";
            this.txtNewProduct.Size = new System.Drawing.Size(199, 26);
            this.txtNewProduct.TabIndex = 2;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProduct.Location = new System.Drawing.Point(83, 209);
            this.btnAddNewProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(200, 39);
            this.btnAddNewProduct.TabIndex = 3;
            this.btnAddNewProduct.Text = "Add Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Type";
            // 
            // lstActiveProducts
            // 
            this.lstActiveProducts.FormattingEnabled = true;
            this.lstActiveProducts.ItemHeight = 16;
            this.lstActiveProducts.Location = new System.Drawing.Point(371, 79);
            this.lstActiveProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstActiveProducts.Name = "lstActiveProducts";
            this.lstActiveProducts.Size = new System.Drawing.Size(256, 180);
            this.lstActiveProducts.TabIndex = 5;
            // 
            // lstDiscontinuedProducts
            // 
            this.lstDiscontinuedProducts.FormattingEnabled = true;
            this.lstDiscontinuedProducts.ItemHeight = 16;
            this.lstDiscontinuedProducts.Location = new System.Drawing.Point(708, 78);
            this.lstDiscontinuedProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDiscontinuedProducts.Name = "lstDiscontinuedProducts";
            this.lstDiscontinuedProducts.Size = new System.Drawing.Size(256, 180);
            this.lstDiscontinuedProducts.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(684, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Discontinued Products";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(636, 132);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(636, 178);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(64, 39);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "# Active:";
            // 
            // lblNumActive
            // 
            this.lblNumActive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumActive.Location = new System.Drawing.Point(569, 268);
            this.lblNumActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumActive.Name = "lblNumActive";
            this.lblNumActive.Size = new System.Drawing.Size(59, 44);
            this.lblNumActive.TabIndex = 11;
            this.lblNumActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumDiscontinued
            // 
            this.lblNumDiscontinued.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumDiscontinued.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDiscontinued.Location = new System.Drawing.Point(904, 268);
            this.lblNumDiscontinued.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumDiscontinued.Name = "lblNumDiscontinued";
            this.lblNumDiscontinued.Size = new System.Drawing.Size(59, 44);
            this.lblNumDiscontinued.TabIndex = 13;
            this.lblNumDiscontinued.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(735, 281);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "# Discontinued:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(864, 364);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 28);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmGroceryStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 416);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblNumDiscontinued);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNumActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstDiscontinuedProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstActiveProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.txtNewProduct);
            this.Controls.Add(this.cboProductType);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGroceryStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grocery Store";
            this.Load += new System.EventHandler(this.frmGroceryStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProductType;
        private System.Windows.Forms.TextBox txtNewProduct;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstActiveProducts;
        private System.Windows.Forms.ListBox lstDiscontinuedProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumActive;
        private System.Windows.Forms.Label lblNumDiscontinued;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
    }
}

