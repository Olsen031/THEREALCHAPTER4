namespace Twitter
{
    partial class formTwitter
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
            this.txtTwitterMessage = new System.Windows.Forms.TextBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.lblPostedMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTwitterMessage
            // 
            this.txtTwitterMessage.Location = new System.Drawing.Point(285, 41);
            this.txtTwitterMessage.Multiline = true;
            this.txtTwitterMessage.Name = "txtTwitterMessage";
            this.txtTwitterMessage.Size = new System.Drawing.Size(187, 90);
            this.txtTwitterMessage.TabIndex = 0;
            // 
            // lblCounter
            // 
            this.lblCounter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCounter.Location = new System.Drawing.Point(337, 167);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(100, 23);
            this.lblCounter.TabIndex = 1;
            // 
            // btnPost
            // 
            this.btnPost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPost.Location = new System.Drawing.Point(340, 243);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // lblPostedMessage
            // 
            this.lblPostedMessage.AutoSize = true;
            this.lblPostedMessage.Location = new System.Drawing.Point(337, 307);
            this.lblPostedMessage.Name = "lblPostedMessage";
            this.lblPostedMessage.Size = new System.Drawing.Size(0, 13);
            this.lblPostedMessage.TabIndex = 3;
            // 
            // formTwitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPostedMessage);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.txtTwitterMessage);
            this.Name = "formTwitter";
            this.Text = "Twitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTwitterMessage;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lblPostedMessage;
    }
}

