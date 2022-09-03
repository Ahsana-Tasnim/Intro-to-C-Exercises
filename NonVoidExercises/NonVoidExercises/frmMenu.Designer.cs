namespace NonVoidExercises
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
            this.btnValidateInput = new System.Windows.Forms.Button();
            this.frmMPG = new System.Windows.Forms.Button();
            this.btnFullName = new System.Windows.Forms.Button();
            this.btnAddNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValidateInput
            // 
            this.btnValidateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateInput.Location = new System.Drawing.Point(47, 239);
            this.btnValidateInput.Name = "btnValidateInput";
            this.btnValidateInput.Size = new System.Drawing.Size(253, 60);
            this.btnValidateInput.TabIndex = 7;
            this.btnValidateInput.Text = "Validate Input";
            this.btnValidateInput.UseVisualStyleBackColor = true;
            this.btnValidateInput.Click += new System.EventHandler(this.btnValidateInput_Click);
            // 
            // frmMPG
            // 
            this.frmMPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmMPG.Location = new System.Drawing.Point(47, 173);
            this.frmMPG.Name = "frmMPG";
            this.frmMPG.Size = new System.Drawing.Size(253, 60);
            this.frmMPG.TabIndex = 6;
            this.frmMPG.Text = "MPG";
            this.frmMPG.UseVisualStyleBackColor = true;
            this.frmMPG.Click += new System.EventHandler(this.frmMPG_Click);
            // 
            // btnFullName
            // 
            this.btnFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullName.Location = new System.Drawing.Point(47, 107);
            this.btnFullName.Name = "btnFullName";
            this.btnFullName.Size = new System.Drawing.Size(253, 60);
            this.btnFullName.TabIndex = 5;
            this.btnFullName.Text = "Full Name";
            this.btnFullName.UseVisualStyleBackColor = true;
            this.btnFullName.Click += new System.EventHandler(this.btnFullName_Click);
            // 
            // btnAddNumbers
            // 
            this.btnAddNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNumbers.Location = new System.Drawing.Point(47, 41);
            this.btnAddNumbers.Name = "btnAddNumbers";
            this.btnAddNumbers.Size = new System.Drawing.Size(253, 60);
            this.btnAddNumbers.TabIndex = 4;
            this.btnAddNumbers.Text = "Add Numbers";
            this.btnAddNumbers.UseVisualStyleBackColor = true;
            this.btnAddNumbers.Click += new System.EventHandler(this.btnAddNumbers_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 358);
            this.Controls.Add(this.btnValidateInput);
            this.Controls.Add(this.frmMPG);
            this.Controls.Add(this.btnFullName);
            this.Controls.Add(this.btnAddNumbers);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValidateInput;
        private System.Windows.Forms.Button frmMPG;
        private System.Windows.Forms.Button btnFullName;
        private System.Windows.Forms.Button btnAddNumbers;
    }
}

