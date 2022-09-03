namespace EventsExercises
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
            this.btnConcat = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTrafficLight = new System.Windows.Forms.Button();
            this.btnKingOfTheWorld = new System.Windows.Forms.Button();
            this.btnSwapText = new System.Windows.Forms.Button();
            this.btnFaces = new System.Windows.Forms.Button();
            this.btnNameAndNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConcat
            // 
            this.btnConcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcat.Location = new System.Drawing.Point(153, 186);
            this.btnConcat.Name = "btnConcat";
            this.btnConcat.Size = new System.Drawing.Size(90, 66);
            this.btnConcat.TabIndex = 20;
            this.btnConcat.Text = "Concat";
            this.btnConcat.UseVisualStyleBackColor = true;
            this.btnConcat.Click += new System.EventHandler(this.btnConcat_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(93, 267);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 66);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTrafficLight
            // 
            this.btnTrafficLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrafficLight.Location = new System.Drawing.Point(42, 186);
            this.btnTrafficLight.Name = "btnTrafficLight";
            this.btnTrafficLight.Size = new System.Drawing.Size(90, 66);
            this.btnTrafficLight.TabIndex = 18;
            this.btnTrafficLight.Text = "Traffic Light";
            this.btnTrafficLight.UseVisualStyleBackColor = true;
            this.btnTrafficLight.Click += new System.EventHandler(this.btnTrafficLight_Click);
            // 
            // btnKingOfTheWorld
            // 
            this.btnKingOfTheWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKingOfTheWorld.Location = new System.Drawing.Point(153, 109);
            this.btnKingOfTheWorld.Name = "btnKingOfTheWorld";
            this.btnKingOfTheWorld.Size = new System.Drawing.Size(90, 66);
            this.btnKingOfTheWorld.TabIndex = 17;
            this.btnKingOfTheWorld.Text = "King of the World";
            this.btnKingOfTheWorld.UseVisualStyleBackColor = true;
            this.btnKingOfTheWorld.Click += new System.EventHandler(this.btnKingOfTheWorld_Click);
            // 
            // btnSwapText
            // 
            this.btnSwapText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwapText.Location = new System.Drawing.Point(42, 109);
            this.btnSwapText.Name = "btnSwapText";
            this.btnSwapText.Size = new System.Drawing.Size(90, 66);
            this.btnSwapText.TabIndex = 16;
            this.btnSwapText.Text = "Swap Text";
            this.btnSwapText.UseVisualStyleBackColor = true;
            this.btnSwapText.Click += new System.EventHandler(this.btnSwapText_Click);
            // 
            // btnFaces
            // 
            this.btnFaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaces.Location = new System.Drawing.Point(153, 37);
            this.btnFaces.Name = "btnFaces";
            this.btnFaces.Size = new System.Drawing.Size(90, 66);
            this.btnFaces.TabIndex = 15;
            this.btnFaces.Text = "Faces :) :(";
            this.btnFaces.UseVisualStyleBackColor = true;
            this.btnFaces.Click += new System.EventHandler(this.btnFaces_Click);
            // 
            // btnNameAndNumber
            // 
            this.btnNameAndNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameAndNumber.Location = new System.Drawing.Point(42, 37);
            this.btnNameAndNumber.Name = "btnNameAndNumber";
            this.btnNameAndNumber.Size = new System.Drawing.Size(90, 66);
            this.btnNameAndNumber.TabIndex = 14;
            this.btnNameAndNumber.Text = "Name and Number";
            this.btnNameAndNumber.UseVisualStyleBackColor = true;
            this.btnNameAndNumber.Click += new System.EventHandler(this.btnNameAndNumber_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.btnConcat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTrafficLight);
            this.Controls.Add(this.btnKingOfTheWorld);
            this.Controls.Add(this.btnSwapText);
            this.Controls.Add(this.btnFaces);
            this.Controls.Add(this.btnNameAndNumber);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConcat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTrafficLight;
        private System.Windows.Forms.Button btnKingOfTheWorld;
        private System.Windows.Forms.Button btnSwapText;
        private System.Windows.Forms.Button btnFaces;
        private System.Windows.Forms.Button btnNameAndNumber;
    }
}

