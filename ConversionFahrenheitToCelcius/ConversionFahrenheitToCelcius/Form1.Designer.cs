namespace ConversionFahrenheitToCelcius
{
    partial class FahrenheitToCelsiusForm
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
            this.lblTemp1 = new System.Windows.Forms.Label();
            this.lblTemp2 = new System.Windows.Forms.Label();
            this.lblTemp3 = new System.Windows.Forms.Label();
            this.txtTemp1Input = new System.Windows.Forms.TextBox();
            this.txtTemp2Input = new System.Windows.Forms.TextBox();
            this.txtTemp3Input = new System.Windows.Forms.TextBox();
            this.btnTempConversion = new System.Windows.Forms.Button();
            this.lblTemp1Output = new System.Windows.Forms.Label();
            this.lblTemp2Output = new System.Windows.Forms.Label();
            this.lblTemp3Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTemp1
            // 
            this.lblTemp1.AutoSize = true;
            this.lblTemp1.Location = new System.Drawing.Point(99, 63);
            this.lblTemp1.Name = "lblTemp1";
            this.lblTemp1.Size = new System.Drawing.Size(165, 13);
            this.lblTemp1.TabIndex = 0;
            this.lblTemp1.Text = "Enter the temperature at 8:00 am ";
            // 
            // lblTemp2
            // 
            this.lblTemp2.AutoSize = true;
            this.lblTemp2.Location = new System.Drawing.Point(99, 133);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(166, 13);
            this.lblTemp2.TabIndex = 1;
            this.lblTemp2.Text = "Enter the temperature at 12:00 pn";
            // 
            // lblTemp3
            // 
            this.lblTemp3.AutoSize = true;
            this.lblTemp3.Location = new System.Drawing.Point(99, 200);
            this.lblTemp3.Name = "lblTemp3";
            this.lblTemp3.Size = new System.Drawing.Size(162, 13);
            this.lblTemp3.TabIndex = 2;
            this.lblTemp3.Text = "Enter the temperature at 5:00 pm";
            // 
            // txtTemp1Input
            // 
            this.txtTemp1Input.Location = new System.Drawing.Point(319, 63);
            this.txtTemp1Input.Name = "txtTemp1Input";
            this.txtTemp1Input.Size = new System.Drawing.Size(100, 20);
            this.txtTemp1Input.TabIndex = 3;
            // 
            // txtTemp2Input
            // 
            this.txtTemp2Input.Location = new System.Drawing.Point(319, 133);
            this.txtTemp2Input.Name = "txtTemp2Input";
            this.txtTemp2Input.Size = new System.Drawing.Size(100, 20);
            this.txtTemp2Input.TabIndex = 4;
            // 
            // txtTemp3Input
            // 
            this.txtTemp3Input.Location = new System.Drawing.Point(319, 200);
            this.txtTemp3Input.Name = "txtTemp3Input";
            this.txtTemp3Input.Size = new System.Drawing.Size(100, 20);
            this.txtTemp3Input.TabIndex = 5;
            // 
            // btnTempConversion
            // 
            this.btnTempConversion.Location = new System.Drawing.Point(319, 248);
            this.btnTempConversion.Name = "btnTempConversion";
            this.btnTempConversion.Size = new System.Drawing.Size(100, 83);
            this.btnTempConversion.TabIndex = 6;
            this.btnTempConversion.Text = "Click to convert the temperatures";
            this.btnTempConversion.UseVisualStyleBackColor = true;
            this.btnTempConversion.Click += new System.EventHandler(this.btnTempConversion_Click);
            // 
            // lblTemp1Output
            // 
            this.lblTemp1Output.AutoSize = true;
            this.lblTemp1Output.Location = new System.Drawing.Point(506, 63);
            this.lblTemp1Output.Name = "lblTemp1Output";
            this.lblTemp1Output.Size = new System.Drawing.Size(35, 13);
            this.lblTemp1Output.TabIndex = 7;
            this.lblTemp1Output.Text = "label1";
            this.lblTemp1Output.Visible = false;
            // 
            // lblTemp2Output
            // 
            this.lblTemp2Output.AutoSize = true;
            this.lblTemp2Output.Location = new System.Drawing.Point(506, 136);
            this.lblTemp2Output.Name = "lblTemp2Output";
            this.lblTemp2Output.Size = new System.Drawing.Size(35, 13);
            this.lblTemp2Output.TabIndex = 8;
            this.lblTemp2Output.Text = "label2";
            this.lblTemp2Output.Visible = false;
            // 
            // lblTemp3Output
            // 
            this.lblTemp3Output.AutoSize = true;
            this.lblTemp3Output.Location = new System.Drawing.Point(506, 200);
            this.lblTemp3Output.Name = "lblTemp3Output";
            this.lblTemp3Output.Size = new System.Drawing.Size(35, 13);
            this.lblTemp3Output.TabIndex = 9;
            this.lblTemp3Output.Text = "label3";
            this.lblTemp3Output.Visible = false;
            // 
            // FahrenheitToCelsiusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTemp3Output);
            this.Controls.Add(this.lblTemp2Output);
            this.Controls.Add(this.lblTemp1Output);
            this.Controls.Add(this.btnTempConversion);
            this.Controls.Add(this.txtTemp3Input);
            this.Controls.Add(this.txtTemp2Input);
            this.Controls.Add(this.txtTemp1Input);
            this.Controls.Add(this.lblTemp3);
            this.Controls.Add(this.lblTemp2);
            this.Controls.Add(this.lblTemp1);
            this.Name = "FahrenheitToCelsiusForm";
            this.Text = "Fahrenheit to Celcius";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemp1;
        private System.Windows.Forms.Label lblTemp2;
        private System.Windows.Forms.Label lblTemp3;
        private System.Windows.Forms.TextBox txtTemp1Input;
        private System.Windows.Forms.TextBox txtTemp2Input;
        private System.Windows.Forms.TextBox txtTemp3Input;
        private System.Windows.Forms.Button btnTempConversion;
        private System.Windows.Forms.Label lblTemp1Output;
        private System.Windows.Forms.Label lblTemp2Output;
        private System.Windows.Forms.Label lblTemp3Output;
    }
}

