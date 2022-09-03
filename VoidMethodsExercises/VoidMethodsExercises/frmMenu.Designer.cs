namespace VoidMethodsExercises
{
    partial class frmMenu
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
            this.btnAddNumbers = new System.Windows.Forms.Button();
            this.btnLargestNumber = new System.Windows.Forms.Button();
            this.btnMPG = new System.Windows.Forms.Button();
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNumbers
            // 
            this.btnAddNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNumbers.Location = new System.Drawing.Point(46, 27);
            this.btnAddNumbers.Name = "btnAddNumbers";
            this.btnAddNumbers.Size = new System.Drawing.Size(253, 60);
            this.btnAddNumbers.TabIndex = 0;
            this.btnAddNumbers.Text = "Add Numbers";
            this.btnAddNumbers.UseVisualStyleBackColor = true;
            this.btnAddNumbers.Click += new System.EventHandler(this.btnDisplayMsg_Click);
            // 
            // btnLargestNumber
            // 
            this.btnLargestNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLargestNumber.Location = new System.Drawing.Point(46, 93);
            this.btnLargestNumber.Name = "btnLargestNumber";
            this.btnLargestNumber.Size = new System.Drawing.Size(253, 60);
            this.btnLargestNumber.TabIndex = 1;
            this.btnLargestNumber.Text = "Largest Number";
            this.btnLargestNumber.UseVisualStyleBackColor = true;
            this.btnLargestNumber.Click += new System.EventHandler(this.btnLargestNumber_Click);
            // 
            // btnMPG
            // 
            this.btnMPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMPG.Location = new System.Drawing.Point(46, 159);
            this.btnMPG.Name = "btnMPG";
            this.btnMPG.Size = new System.Drawing.Size(253, 60);
            this.btnMPG.TabIndex = 2;
            this.btnMPG.Text = "MPG";
            this.btnMPG.UseVisualStyleBackColor = true;
            this.btnMPG.Click += new System.EventHandler(this.btnMPG_Click);
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerimeter.Location = new System.Drawing.Point(46, 225);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Size = new System.Drawing.Size(253, 60);
            this.btnPerimeter.TabIndex = 3;
            this.btnPerimeter.Text = "Perimeter";
            this.btnPerimeter.UseVisualStyleBackColor = true;
            this.btnPerimeter.Click += new System.EventHandler(this.btnPerimeter_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 324);
            this.Controls.Add(this.btnPerimeter);
            this.Controls.Add(this.btnMPG);
            this.Controls.Add(this.btnLargestNumber);
            this.Controls.Add(this.btnAddNumbers);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNumbers;
        private System.Windows.Forms.Button btnLargestNumber;
        private System.Windows.Forms.Button btnMPG;
        private System.Windows.Forms.Button btnPerimeter;
    }
}

