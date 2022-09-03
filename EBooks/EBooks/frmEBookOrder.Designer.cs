namespace EBooks
{
    partial class frmEBookOrder
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
            this.grpChooseBooks = new System.Windows.Forms.GroupBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.grpQuantity = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.grpAvailableBooks = new System.Windows.Forms.GroupBox();
            this.cboAvailableBooks = new System.Windows.Forms.ComboBox();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.grpOrderConfirmation = new System.Windows.Forms.GroupBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.txtMemberNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpOrderDetails = new System.Windows.Forms.GroupBox();
            this.btnCalculateOrder = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpShipping = new System.Windows.Forms.GroupBox();
            this.chkExpedited = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpChooseBooks.SuspendLayout();
            this.grpCart.SuspendLayout();
            this.grpQuantity.SuspendLayout();
            this.grpAvailableBooks.SuspendLayout();
            this.grpOrderInfo.SuspendLayout();
            this.grpOrderConfirmation.SuspendLayout();
            this.grpOrderDetails.SuspendLayout();
            this.grpShipping.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChooseBooks
            // 
            this.grpChooseBooks.Controls.Add(this.btnCheckout);
            this.grpChooseBooks.Controls.Add(this.grpCart);
            this.grpChooseBooks.Controls.Add(this.btnAddBook);
            this.grpChooseBooks.Controls.Add(this.grpQuantity);
            this.grpChooseBooks.Controls.Add(this.grpAvailableBooks);
            this.grpChooseBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChooseBooks.Location = new System.Drawing.Point(40, 32);
            this.grpChooseBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpChooseBooks.Name = "grpChooseBooks";
            this.grpChooseBooks.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpChooseBooks.Size = new System.Drawing.Size(1109, 204);
            this.grpChooseBooks.TabIndex = 0;
            this.grpChooseBooks.TabStop = false;
            this.grpChooseBooks.Text = "Choose Your Books";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(444, 124);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(221, 54);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.lstCart);
            this.grpCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCart.Location = new System.Drawing.Point(673, 33);
            this.grpCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCart.Name = "grpCart";
            this.grpCart.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCart.Size = new System.Drawing.Size(404, 145);
            this.grpCart.TabIndex = 1;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Cart";
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 17;
            this.lstCart.Location = new System.Drawing.Point(31, 34);
            this.lstCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(343, 72);
            this.lstCart.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(565, 33);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 82);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "+";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // grpQuantity
            // 
            this.grpQuantity.Controls.Add(this.txtQuantity);
            this.grpQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuantity.Location = new System.Drawing.Point(444, 33);
            this.grpQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpQuantity.Name = "grpQuantity";
            this.grpQuantity.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpQuantity.Size = new System.Drawing.Size(113, 82);
            this.grpQuantity.TabIndex = 1;
            this.grpQuantity.TabStop = false;
            this.grpQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(31, 36);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(59, 23);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpAvailableBooks
            // 
            this.grpAvailableBooks.Controls.Add(this.cboAvailableBooks);
            this.grpAvailableBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAvailableBooks.Location = new System.Drawing.Point(29, 33);
            this.grpAvailableBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAvailableBooks.Name = "grpAvailableBooks";
            this.grpAvailableBooks.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAvailableBooks.Size = new System.Drawing.Size(404, 82);
            this.grpAvailableBooks.TabIndex = 0;
            this.grpAvailableBooks.TabStop = false;
            this.grpAvailableBooks.Text = "Available E-books";
            // 
            // cboAvailableBooks
            // 
            this.cboAvailableBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAvailableBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAvailableBooks.FormattingEnabled = true;
            this.cboAvailableBooks.Location = new System.Drawing.Point(39, 34);
            this.cboAvailableBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAvailableBooks.Name = "cboAvailableBooks";
            this.cboAvailableBooks.Size = new System.Drawing.Size(327, 25);
            this.cboAvailableBooks.Sorted = true;
            this.cboAvailableBooks.TabIndex = 0;
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.grpOrderConfirmation);
            this.grpOrderInfo.Controls.Add(this.grpOrderDetails);
            this.grpOrderInfo.Controls.Add(this.grpShipping);
            this.grpOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderInfo.Location = new System.Drawing.Point(40, 261);
            this.grpOrderInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrderInfo.Size = new System.Drawing.Size(1109, 254);
            this.grpOrderInfo.TabIndex = 4;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Order Information";
            // 
            // grpOrderConfirmation
            // 
            this.grpOrderConfirmation.Controls.Add(this.btnPlaceOrder);
            this.grpOrderConfirmation.Controls.Add(this.txtMemberNumber);
            this.grpOrderConfirmation.Controls.Add(this.label2);
            this.grpOrderConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderConfirmation.Location = new System.Drawing.Point(755, 49);
            this.grpOrderConfirmation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrderConfirmation.Name = "grpOrderConfirmation";
            this.grpOrderConfirmation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrderConfirmation.Size = new System.Drawing.Size(323, 170);
            this.grpOrderConfirmation.TabIndex = 2;
            this.grpOrderConfirmation.TabStop = false;
            this.grpOrderConfirmation.Text = "Order Information";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(45, 110);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(248, 36);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // txtMemberNumber
            // 
            this.txtMemberNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberNumber.Location = new System.Drawing.Point(45, 78);
            this.txtMemberNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberNumber.Name = "txtMemberNumber";
            this.txtMemberNumber.Size = new System.Drawing.Size(247, 23);
            this.txtMemberNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter your member number to confirm your order";
            // 
            // grpOrderDetails
            // 
            this.grpOrderDetails.Controls.Add(this.btnCalculateOrder);
            this.grpOrderDetails.Controls.Add(this.lblTotal);
            this.grpOrderDetails.Controls.Add(this.label4);
            this.grpOrderDetails.Controls.Add(this.lblShipping);
            this.grpOrderDetails.Controls.Add(this.label3);
            this.grpOrderDetails.Controls.Add(this.lblSubtotal);
            this.grpOrderDetails.Controls.Add(this.label1);
            this.grpOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderDetails.Location = new System.Drawing.Point(221, 39);
            this.grpOrderDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrderDetails.Name = "grpOrderDetails";
            this.grpOrderDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrderDetails.Size = new System.Drawing.Size(508, 180);
            this.grpOrderDetails.TabIndex = 3;
            this.grpOrderDetails.TabStop = false;
            this.grpOrderDetails.Text = "Order Details";
            // 
            // btnCalculateOrder
            // 
            this.btnCalculateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateOrder.Location = new System.Drawing.Point(301, 39);
            this.btnCalculateOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculateOrder.Name = "btnCalculateOrder";
            this.btnCalculateOrder.Size = new System.Drawing.Size(179, 82);
            this.btnCalculateOrder.TabIndex = 4;
            this.btnCalculateOrder.Text = "Calculate Order";
            this.btnCalculateOrder.UseVisualStyleBackColor = true;
            this.btnCalculateOrder.Click += new System.EventHandler(this.btnCalculateOrder_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(107, 118);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(165, 28);
            this.lblTotal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total:";
            // 
            // lblShipping
            // 
            this.lblShipping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipping.Location = new System.Drawing.Point(107, 79);
            this.lblShipping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(165, 28);
            this.lblShipping.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shipping:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(107, 39);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(165, 28);
            this.lblSubtotal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // grpShipping
            // 
            this.grpShipping.Controls.Add(this.chkExpedited);
            this.grpShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpShipping.Location = new System.Drawing.Point(29, 39);
            this.grpShipping.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpShipping.Name = "grpShipping";
            this.grpShipping.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpShipping.Size = new System.Drawing.Size(172, 82);
            this.grpShipping.TabIndex = 2;
            this.grpShipping.TabStop = false;
            this.grpShipping.Text = "Quantity";
            // 
            // chkExpedited
            // 
            this.chkExpedited.AutoSize = true;
            this.chkExpedited.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExpedited.Location = new System.Drawing.Point(40, 38);
            this.chkExpedited.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkExpedited.Name = "chkExpedited";
            this.chkExpedited.Size = new System.Drawing.Size(100, 21);
            this.chkExpedited.TabIndex = 0;
            this.chkExpedited.Text = "Expedited?";
            this.chkExpedited.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(484, 542);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 30);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(605, 542);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEBookOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 608);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpOrderInfo);
            this.Controls.Add(this.grpChooseBooks);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEBookOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Book Order Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEBookOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmEBookOrder_Load);
            this.grpChooseBooks.ResumeLayout(false);
            this.grpCart.ResumeLayout(false);
            this.grpQuantity.ResumeLayout(false);
            this.grpQuantity.PerformLayout();
            this.grpAvailableBooks.ResumeLayout(false);
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderConfirmation.ResumeLayout(false);
            this.grpOrderConfirmation.PerformLayout();
            this.grpOrderDetails.ResumeLayout(false);
            this.grpOrderDetails.PerformLayout();
            this.grpShipping.ResumeLayout(false);
            this.grpShipping.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChooseBooks;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.GroupBox grpQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.GroupBox grpAvailableBooks;
        private System.Windows.Forms.ComboBox cboAvailableBooks;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.GroupBox grpOrderConfirmation;
        private System.Windows.Forms.TextBox txtMemberNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpOrderDetails;
        private System.Windows.Forms.Button btnCalculateOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpShipping;
        private System.Windows.Forms.CheckBox chkExpedited;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}

