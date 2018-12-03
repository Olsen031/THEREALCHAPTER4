namespace NewDegreesConverter
{
    partial class Form1
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
            this.lbl8InTheMorning = new System.Windows.Forms.Label();
            this.lblNoon = new System.Windows.Forms.Label();
            this.lbl5AtNight = new System.Windows.Forms.Label();
            this.txt8InMorning = new System.Windows.Forms.TextBox();
            this.txtNoon = new System.Windows.Forms.TextBox();
            this.txt5AtNight = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnConvertToCelsius = new System.Windows.Forms.Button();
            this.btnConvertToFahrenheit = new System.Windows.Forms.Button();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblCelsius1 = new System.Windows.Forms.Label();
            this.lblFahrenheit1 = new System.Windows.Forms.Label();
            this.lblTempAt8 = new System.Windows.Forms.Label();
            this.lblTempAt12 = new System.Windows.Forms.Label();
            this.lblTempAt5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl8InTheMorning
            // 
            this.lbl8InTheMorning.AutoSize = true;
            this.lbl8InTheMorning.Location = new System.Drawing.Point(13, 36);
            this.lbl8InTheMorning.Name = "lbl8InTheMorning";
            this.lbl8InTheMorning.Size = new System.Drawing.Size(162, 13);
            this.lbl8InTheMorning.TabIndex = 0;
            this.lbl8InTheMorning.Text = "Enter the temperature at 8:00 am";
            // 
            // lblNoon
            // 
            this.lblNoon.AutoSize = true;
            this.lblNoon.Location = new System.Drawing.Point(13, 88);
            this.lblNoon.Name = "lblNoon";
            this.lblNoon.Size = new System.Drawing.Size(168, 13);
            this.lblNoon.TabIndex = 1;
            this.lblNoon.Text = "Enter the temperature at 12:00 pm";
            // 
            // lbl5AtNight
            // 
            this.lbl5AtNight.AutoSize = true;
            this.lbl5AtNight.Location = new System.Drawing.Point(13, 142);
            this.lbl5AtNight.Name = "lbl5AtNight";
            this.lbl5AtNight.Size = new System.Drawing.Size(162, 13);
            this.lbl5AtNight.TabIndex = 2;
            this.lbl5AtNight.Text = "Enter the temperature at 5:00 pm";
            // 
            // txt8InMorning
            // 
            this.txt8InMorning.Location = new System.Drawing.Point(185, 36);
            this.txt8InMorning.Name = "txt8InMorning";
            this.txt8InMorning.Size = new System.Drawing.Size(100, 20);
            this.txt8InMorning.TabIndex = 3;
            // 
            // txtNoon
            // 
            this.txtNoon.Location = new System.Drawing.Point(185, 88);
            this.txtNoon.Name = "txtNoon";
            this.txtNoon.Size = new System.Drawing.Size(100, 20);
            this.txtNoon.TabIndex = 4;
            // 
            // txt5AtNight
            // 
            this.txt5AtNight.Location = new System.Drawing.Point(185, 142);
            this.txt5AtNight.Name = "txt5AtNight";
            this.txt5AtNight.Size = new System.Drawing.Size(100, 20);
            this.txt5AtNight.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(344, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(344, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnConvertToCelsius
            // 
            this.btnConvertToCelsius.Location = new System.Drawing.Point(294, 238);
            this.btnConvertToCelsius.Name = "btnConvertToCelsius";
            this.btnConvertToCelsius.Size = new System.Drawing.Size(83, 85);
            this.btnConvertToCelsius.TabIndex = 8;
            this.btnConvertToCelsius.Text = "Celsius";
            this.btnConvertToCelsius.UseVisualStyleBackColor = true;
            this.btnConvertToCelsius.Click += new System.EventHandler(this.btnConvertToCelsius_Click);
            // 
            // btnConvertToFahrenheit
            // 
            this.btnConvertToFahrenheit.Location = new System.Drawing.Point(414, 238);
            this.btnConvertToFahrenheit.Name = "btnConvertToFahrenheit";
            this.btnConvertToFahrenheit.Size = new System.Drawing.Size(89, 85);
            this.btnConvertToFahrenheit.TabIndex = 9;
            this.btnConvertToFahrenheit.Text = "Fahrenheit";
            this.btnConvertToFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertToFahrenheit.Click += new System.EventHandler(this.btnConvertToFahrenheit_Click);
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(544, 9);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(57, 13);
            this.lblFahrenheit.TabIndex = 10;
            this.lblFahrenheit.Text = "Fahrenheit";
            this.lblFahrenheit.Visible = false;
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(561, 9);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(40, 13);
            this.lblCelsius.TabIndex = 11;
            this.lblCelsius.Text = "Celsius";
            this.lblCelsius.Visible = false;
            // 
            // lblCelsius1
            // 
            this.lblCelsius1.AutoSize = true;
            this.lblCelsius1.Location = new System.Drawing.Point(210, 9);
            this.lblCelsius1.Name = "lblCelsius1";
            this.lblCelsius1.Size = new System.Drawing.Size(40, 13);
            this.lblCelsius1.TabIndex = 12;
            this.lblCelsius1.Text = "Celsius";
            this.lblCelsius1.Visible = false;
            // 
            // lblFahrenheit1
            // 
            this.lblFahrenheit1.AutoSize = true;
            this.lblFahrenheit1.Location = new System.Drawing.Point(228, 9);
            this.lblFahrenheit1.Name = "lblFahrenheit1";
            this.lblFahrenheit1.Size = new System.Drawing.Size(57, 13);
            this.lblFahrenheit1.TabIndex = 13;
            this.lblFahrenheit1.Text = "Fahrenheit";
            this.lblFahrenheit1.Visible = false;
            // 
            // lblTempAt8
            // 
            this.lblTempAt8.AutoSize = true;
            this.lblTempAt8.Location = new System.Drawing.Point(533, 39);
            this.lblTempAt8.Name = "lblTempAt8";
            this.lblTempAt8.Size = new System.Drawing.Size(35, 13);
            this.lblTempAt8.TabIndex = 14;
            this.lblTempAt8.Text = "label1";
            this.lblTempAt8.Visible = false;
            // 
            // lblTempAt12
            // 
            this.lblTempAt12.AutoSize = true;
            this.lblTempAt12.Location = new System.Drawing.Point(533, 88);
            this.lblTempAt12.Name = "lblTempAt12";
            this.lblTempAt12.Size = new System.Drawing.Size(35, 13);
            this.lblTempAt12.TabIndex = 15;
            this.lblTempAt12.Text = "label2";
            this.lblTempAt12.Visible = false;
            // 
            // lblTempAt5
            // 
            this.lblTempAt5.AutoSize = true;
            this.lblTempAt5.Location = new System.Drawing.Point(533, 142);
            this.lblTempAt5.Name = "lblTempAt5";
            this.lblTempAt5.Size = new System.Drawing.Size(35, 13);
            this.lblTempAt5.TabIndex = 16;
            this.lblTempAt5.Text = "label3";
            this.lblTempAt5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTempAt5);
            this.Controls.Add(this.lblTempAt12);
            this.Controls.Add(this.lblTempAt8);
            this.Controls.Add(this.lblFahrenheit1);
            this.Controls.Add(this.lblCelsius1);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.btnConvertToFahrenheit);
            this.Controls.Add(this.btnConvertToCelsius);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt5AtNight);
            this.Controls.Add(this.txtNoon);
            this.Controls.Add(this.txt8InMorning);
            this.Controls.Add(this.lbl5AtNight);
            this.Controls.Add(this.lblNoon);
            this.Controls.Add(this.lbl8InTheMorning);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl8InTheMorning;
        private System.Windows.Forms.Label lblNoon;
        private System.Windows.Forms.Label lbl5AtNight;
        private System.Windows.Forms.TextBox txt8InMorning;
        private System.Windows.Forms.TextBox txtNoon;
        private System.Windows.Forms.TextBox txt5AtNight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConvertToCelsius;
        private System.Windows.Forms.Button btnConvertToFahrenheit;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblCelsius1;
        private System.Windows.Forms.Label lblFahrenheit1;
        private System.Windows.Forms.Label lblTempAt8;
        private System.Windows.Forms.Label lblTempAt12;
        private System.Windows.Forms.Label lblTempAt5;
    }
}

