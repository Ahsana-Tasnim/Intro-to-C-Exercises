namespace Decisions
{
    partial class MenuForm
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
            this.btnIfStatement = new System.Windows.Forms.Button();
            this.btnIfElseStatement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIfStatement
            // 
            this.btnIfStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIfStatement.Location = new System.Drawing.Point(74, 33);
            this.btnIfStatement.Name = "btnIfStatement";
            this.btnIfStatement.Size = new System.Drawing.Size(219, 51);
            this.btnIfStatement.TabIndex = 0;
            this.btnIfStatement.Text = "if Statement";
            this.btnIfStatement.UseVisualStyleBackColor = true;
            this.btnIfStatement.Click += new System.EventHandler(this.btnIfStatement_Click);
            // 
            // btnIfElseStatement
            // 
            this.btnIfElseStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIfElseStatement.Location = new System.Drawing.Point(74, 90);
            this.btnIfElseStatement.Name = "btnIfElseStatement";
            this.btnIfElseStatement.Size = new System.Drawing.Size(219, 51);
            this.btnIfElseStatement.TabIndex = 1;
            this.btnIfElseStatement.Text = "if/else Statement";
            this.btnIfElseStatement.UseVisualStyleBackColor = true;
            this.btnIfElseStatement.Click += new System.EventHandler(this.btnIfElseStatement_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "if/elseIf/else Statement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(74, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "if/lse Statement String";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 297);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIfElseStatement);
            this.Controls.Add(this.btnIfStatement);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIfStatement;
        private System.Windows.Forms.Button btnIfElseStatement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}