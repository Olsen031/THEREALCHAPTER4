namespace RockPaperScissors
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
            this.lblDirectionsPlayer1 = new System.Windows.Forms.Label();
            this.lblDirectionsPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer1Input = new System.Windows.Forms.TextBox();
            this.txtPlayer2Input = new System.Windows.Forms.TextBox();
            this.btnCalculateWinner = new System.Windows.Forms.Button();
            this.lblErrorPlayer1 = new System.Windows.Forms.Label();
            this.lblErrorPlayer2 = new System.Windows.Forms.Label();
            this.picVs = new System.Windows.Forms.PictureBox();
            this.picPaper2 = new System.Windows.Forms.PictureBox();
            this.picScissors2 = new System.Windows.Forms.PictureBox();
            this.picRock2 = new System.Windows.Forms.PictureBox();
            this.picScissors1 = new System.Windows.Forms.PictureBox();
            this.picPaper1 = new System.Windows.Forms.PictureBox();
            this.picRock1 = new System.Windows.Forms.PictureBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picVs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDirectionsPlayer1
            // 
            this.lblDirectionsPlayer1.AutoSize = true;
            this.lblDirectionsPlayer1.Location = new System.Drawing.Point(40, 9);
            this.lblDirectionsPlayer1.Name = "lblDirectionsPlayer1";
            this.lblDirectionsPlayer1.Size = new System.Drawing.Size(328, 13);
            this.lblDirectionsPlayer1.TabIndex = 0;
            this.lblDirectionsPlayer1.Text = "Player 1: Enter a r for rock, a s for scissors, or a p for paper here ---->";
            // 
            // lblDirectionsPlayer2
            // 
            this.lblDirectionsPlayer2.AutoSize = true;
            this.lblDirectionsPlayer2.Location = new System.Drawing.Point(40, 61);
            this.lblDirectionsPlayer2.Name = "lblDirectionsPlayer2";
            this.lblDirectionsPlayer2.Size = new System.Drawing.Size(328, 13);
            this.lblDirectionsPlayer2.TabIndex = 1;
            this.lblDirectionsPlayer2.Text = "Player 2: Enter a r for rock, a s for scissors, or a p for paper here ---->";
            // 
            // txtPlayer1Input
            // 
            this.txtPlayer1Input.Location = new System.Drawing.Point(424, 6);
            this.txtPlayer1Input.Name = "txtPlayer1Input";
            this.txtPlayer1Input.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer1Input.TabIndex = 2;
            // 
            // txtPlayer2Input
            // 
            this.txtPlayer2Input.Location = new System.Drawing.Point(424, 58);
            this.txtPlayer2Input.Name = "txtPlayer2Input";
            this.txtPlayer2Input.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer2Input.TabIndex = 3;
            // 
            // btnCalculateWinner
            // 
            this.btnCalculateWinner.Location = new System.Drawing.Point(588, 9);
            this.btnCalculateWinner.Name = "btnCalculateWinner";
            this.btnCalculateWinner.Size = new System.Drawing.Size(84, 68);
            this.btnCalculateWinner.TabIndex = 4;
            this.btnCalculateWinner.Text = "Click to calculate the winner";
            this.btnCalculateWinner.UseVisualStyleBackColor = true;
            this.btnCalculateWinner.Click += new System.EventHandler(this.btnCalculateWinner_Click);
            // 
            // lblErrorPlayer1
            // 
            this.lblErrorPlayer1.AutoSize = true;
            this.lblErrorPlayer1.Location = new System.Drawing.Point(40, 165);
            this.lblErrorPlayer1.Name = "lblErrorPlayer1";
            this.lblErrorPlayer1.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPlayer1.TabIndex = 5;
            // 
            // lblErrorPlayer2
            // 
            this.lblErrorPlayer2.AutoSize = true;
            this.lblErrorPlayer2.Location = new System.Drawing.Point(40, 120);
            this.lblErrorPlayer2.Name = "lblErrorPlayer2";
            this.lblErrorPlayer2.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPlayer2.TabIndex = 6;
            // 
            // picVs
            // 
            this.picVs.Image = global::RockPaperScissors.Properties.Resources.vs;
            this.picVs.Location = new System.Drawing.Point(290, 260);
            this.picVs.Name = "picVs";
            this.picVs.Size = new System.Drawing.Size(111, 138);
            this.picVs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVs.TabIndex = 13;
            this.picVs.TabStop = false;
            this.picVs.Visible = false;
            // 
            // picPaper2
            // 
            this.picPaper2.Image = global::RockPaperScissors.Properties.Resources.Paper;
            this.picPaper2.Location = new System.Drawing.Point(450, 212);
            this.picPaper2.Name = "picPaper2";
            this.picPaper2.Size = new System.Drawing.Size(222, 235);
            this.picPaper2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaper2.TabIndex = 12;
            this.picPaper2.TabStop = false;
            this.picPaper2.Visible = false;
            // 
            // picScissors2
            // 
            this.picScissors2.Image = global::RockPaperScissors.Properties.Resources.Scissors;
            this.picScissors2.Location = new System.Drawing.Point(450, 212);
            this.picScissors2.Name = "picScissors2";
            this.picScissors2.Size = new System.Drawing.Size(222, 235);
            this.picScissors2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScissors2.TabIndex = 11;
            this.picScissors2.TabStop = false;
            this.picScissors2.Visible = false;
            // 
            // picRock2
            // 
            this.picRock2.Image = global::RockPaperScissors.Properties.Resources.Rock;
            this.picRock2.Location = new System.Drawing.Point(450, 212);
            this.picRock2.Name = "picRock2";
            this.picRock2.Size = new System.Drawing.Size(222, 235);
            this.picRock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRock2.TabIndex = 10;
            this.picRock2.TabStop = false;
            this.picRock2.Visible = false;
            // 
            // picScissors1
            // 
            this.picScissors1.Image = global::RockPaperScissors.Properties.Resources.Scissors;
            this.picScissors1.Location = new System.Drawing.Point(8, 212);
            this.picScissors1.Name = "picScissors1";
            this.picScissors1.Size = new System.Drawing.Size(222, 235);
            this.picScissors1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScissors1.TabIndex = 9;
            this.picScissors1.TabStop = false;
            this.picScissors1.Visible = false;
            // 
            // picPaper1
            // 
            this.picPaper1.Image = global::RockPaperScissors.Properties.Resources.Paper;
            this.picPaper1.Location = new System.Drawing.Point(8, 212);
            this.picPaper1.Name = "picPaper1";
            this.picPaper1.Size = new System.Drawing.Size(222, 235);
            this.picPaper1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaper1.TabIndex = 8;
            this.picPaper1.TabStop = false;
            this.picPaper1.Visible = false;
            // 
            // picRock1
            // 
            this.picRock1.Image = global::RockPaperScissors.Properties.Resources.Rock;
            this.picRock1.Location = new System.Drawing.Point(8, 212);
            this.picRock1.Name = "picRock1";
            this.picRock1.Size = new System.Drawing.Size(222, 235);
            this.picRock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRock1.TabIndex = 7;
            this.picRock1.TabStop = false;
            this.picRock1.Visible = false;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(319, 557);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 13);
            this.lblWinner.TabIndex = 14;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(290, 494);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 41);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Click to reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 698);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.picVs);
            this.Controls.Add(this.picPaper2);
            this.Controls.Add(this.picScissors2);
            this.Controls.Add(this.picRock2);
            this.Controls.Add(this.picScissors1);
            this.Controls.Add(this.picPaper1);
            this.Controls.Add(this.picRock1);
            this.Controls.Add(this.lblErrorPlayer2);
            this.Controls.Add(this.lblErrorPlayer1);
            this.Controls.Add(this.btnCalculateWinner);
            this.Controls.Add(this.txtPlayer2Input);
            this.Controls.Add(this.txtPlayer1Input);
            this.Controls.Add(this.lblDirectionsPlayer2);
            this.Controls.Add(this.lblDirectionsPlayer1);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.picVs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirectionsPlayer1;
        private System.Windows.Forms.Label lblDirectionsPlayer2;
        private System.Windows.Forms.TextBox txtPlayer1Input;
        private System.Windows.Forms.TextBox txtPlayer2Input;
        private System.Windows.Forms.Button btnCalculateWinner;
        private System.Windows.Forms.Label lblErrorPlayer1;
        private System.Windows.Forms.Label lblErrorPlayer2;
        private System.Windows.Forms.PictureBox picRock1;
        private System.Windows.Forms.PictureBox picPaper1;
        private System.Windows.Forms.PictureBox picScissors1;
        private System.Windows.Forms.PictureBox picRock2;
        private System.Windows.Forms.PictureBox picScissors2;
        private System.Windows.Forms.PictureBox picPaper2;
        private System.Windows.Forms.PictureBox picVs;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnReset;
    }
}

