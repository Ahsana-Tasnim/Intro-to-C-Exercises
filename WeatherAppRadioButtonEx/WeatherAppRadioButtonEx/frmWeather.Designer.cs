namespace WeatherAppRadioButtonEx
{
    partial class frmWeather
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSnowy = new System.Windows.Forms.RadioButton();
            this.rdoRainy = new System.Windows.Forms.RadioButton();
            this.rdoCloudy = new System.Windows.Forms.RadioButton();
            this.rdoSunny = new System.Windows.Forms.RadioButton();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.btnWhatToDo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Temperature:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSnowy);
            this.groupBox1.Controls.Add(this.rdoRainy);
            this.groupBox1.Controls.Add(this.rdoCloudy);
            this.groupBox1.Controls.Add(this.rdoSunny);
            this.groupBox1.Location = new System.Drawing.Point(73, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(293, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weather Condition";
            // 
            // rdoSnowy
            // 
            this.rdoSnowy.AutoSize = true;
            this.rdoSnowy.Location = new System.Drawing.Point(180, 101);
            this.rdoSnowy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoSnowy.Name = "rdoSnowy";
            this.rdoSnowy.Size = new System.Drawing.Size(70, 21);
            this.rdoSnowy.TabIndex = 3;
            this.rdoSnowy.TabStop = true;
            this.rdoSnowy.Text = "Snowy";
            this.rdoSnowy.UseVisualStyleBackColor = true;
            // 
            // rdoRainy
            // 
            this.rdoRainy.AutoSize = true;
            this.rdoRainy.Location = new System.Drawing.Point(180, 49);
            this.rdoRainy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoRainy.Name = "rdoRainy";
            this.rdoRainy.Size = new System.Drawing.Size(65, 21);
            this.rdoRainy.TabIndex = 2;
            this.rdoRainy.TabStop = true;
            this.rdoRainy.Text = "Rainy";
            this.rdoRainy.UseVisualStyleBackColor = true;
            // 
            // rdoCloudy
            // 
            this.rdoCloudy.AutoSize = true;
            this.rdoCloudy.Location = new System.Drawing.Point(41, 101);
            this.rdoCloudy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoCloudy.Name = "rdoCloudy";
            this.rdoCloudy.Size = new System.Drawing.Size(72, 21);
            this.rdoCloudy.TabIndex = 1;
            this.rdoCloudy.TabStop = true;
            this.rdoCloudy.Text = "Cloudy";
            this.rdoCloudy.UseVisualStyleBackColor = true;
            // 
            // rdoSunny
            // 
            this.rdoSunny.AutoSize = true;
            this.rdoSunny.Location = new System.Drawing.Point(41, 49);
            this.rdoSunny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoSunny.Name = "rdoSunny";
            this.rdoSunny.Size = new System.Drawing.Size(69, 21);
            this.rdoSunny.TabIndex = 0;
            this.rdoSunny.TabStop = true;
            this.rdoSunny.Text = "Sunny";
            this.rdoSunny.UseVisualStyleBackColor = true;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(220, 39);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(144, 22);
            this.txtTemperature.TabIndex = 2;
            this.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnWhatToDo
            // 
            this.btnWhatToDo.Location = new System.Drawing.Point(73, 255);
            this.btnWhatToDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWhatToDo.Name = "btnWhatToDo";
            this.btnWhatToDo.Size = new System.Drawing.Size(293, 78);
            this.btnWhatToDo.TabIndex = 3;
            this.btnWhatToDo.Text = "What should I do?";
            this.btnWhatToDo.UseVisualStyleBackColor = true;
            this.btnWhatToDo.Click += new System.EventHandler(this.btnWhatToDo_Click);
            // 
            // frmWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 395);
            this.Controls.Add(this.btnWhatToDo);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmWeather";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSnowy;
        private System.Windows.Forms.RadioButton rdoRainy;
        private System.Windows.Forms.RadioButton rdoCloudy;
        private System.Windows.Forms.RadioButton rdoSunny;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Button btnWhatToDo;
    }
}

