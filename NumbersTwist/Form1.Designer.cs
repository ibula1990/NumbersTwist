namespace NumbersTwist
{
    partial class numberTwist
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
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.lblTwist = new System.Windows.Forms.Label();
            this.txtTwist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The first 10 natural numbers are:";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(177, 64);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(151, 20);
            this.txtnumber.TabIndex = 1;
            // 
            // lblTwist
            // 
            this.lblTwist.AutoSize = true;
            this.lblTwist.Location = new System.Drawing.Point(12, 115);
            this.lblTwist.Name = "lblTwist";
            this.lblTwist.Size = new System.Drawing.Size(129, 13);
            this.lblTwist.TabIndex = 2;
            this.lblTwist.Text = "The twisted numbers are :";
            // 
            // txtTwist
            // 
            this.txtTwist.Location = new System.Drawing.Point(177, 115);
            this.txtTwist.Name = "txtTwist";
            this.txtTwist.Size = new System.Drawing.Size(151, 20);
            this.txtTwist.TabIndex = 3;
            // 
            // numberTwist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(362, 222);
            this.Controls.Add(this.txtTwist);
            this.Controls.Add(this.lblTwist);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label1);
            this.Name = "numberTwist";
            this.Text = "Number Twist";
            this.Load += new System.EventHandler(this.numberTwist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label lblTwist;
        private System.Windows.Forms.TextBox txtTwist;
    }
}

