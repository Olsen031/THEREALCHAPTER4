namespace DailySpecial
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
            this.lblWhatDay = new System.Windows.Forms.Label();
            this.lblExampleDay = new System.Windows.Forms.Label();
            this.txtDayInput = new System.Windows.Forms.TextBox();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.lblSpecialOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWhatDay
            // 
            this.lblWhatDay.AutoSize = true;
            this.lblWhatDay.Location = new System.Drawing.Point(281, 77);
            this.lblWhatDay.Name = "lblWhatDay";
            this.lblWhatDay.Size = new System.Drawing.Size(185, 13);
            this.lblWhatDay.TabIndex = 0;
            this.lblWhatDay.Text = "Enter a day number to see our special";
            // 
            // lblExampleDay
            // 
            this.lblExampleDay.AutoSize = true;
            this.lblExampleDay.Location = new System.Drawing.Point(314, 124);
            this.lblExampleDay.Name = "lblExampleDay";
            this.lblExampleDay.Size = new System.Drawing.Size(121, 13);
            this.lblExampleDay.TabIndex = 1;
            this.lblExampleDay.Text = "For example Sunday = 1";
            // 
            // txtDayInput
            // 
            this.txtDayInput.Location = new System.Drawing.Point(326, 161);
            this.txtDayInput.Name = "txtDayInput";
            this.txtDayInput.Size = new System.Drawing.Size(100, 20);
            this.txtDayInput.TabIndex = 2;
            // 
            // btnSpecial
            // 
            this.btnSpecial.Location = new System.Drawing.Point(337, 207);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(75, 23);
            this.btnSpecial.TabIndex = 3;
            this.btnSpecial.Text = "Get Special";
            this.btnSpecial.UseVisualStyleBackColor = true;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // lblSpecialOutput
            // 
            this.lblSpecialOutput.AutoSize = true;
            this.lblSpecialOutput.Location = new System.Drawing.Point(323, 293);
            this.lblSpecialOutput.Name = "lblSpecialOutput";
            this.lblSpecialOutput.Size = new System.Drawing.Size(35, 13);
            this.lblSpecialOutput.TabIndex = 4;
            this.lblSpecialOutput.Text = "label1";
            this.lblSpecialOutput.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSpecialOutput);
            this.Controls.Add(this.btnSpecial);
            this.Controls.Add(this.txtDayInput);
            this.Controls.Add(this.lblExampleDay);
            this.Controls.Add(this.lblWhatDay);
            this.Name = "Form1";
            this.Text = "Chatterbox Diner Daily Specials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhatDay;
        private System.Windows.Forms.Label lblExampleDay;
        private System.Windows.Forms.TextBox txtDayInput;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.Label lblSpecialOutput;
    }
}

