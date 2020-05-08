namespace Question1
{
    partial class server
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
            this.portNum = new System.Windows.Forms.TextBox();
            this.sendPortNb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // portNum
            // 
            this.portNum.Location = new System.Drawing.Point(37, 35);
            this.portNum.Name = "portNum";
            this.portNum.Size = new System.Drawing.Size(127, 20);
            this.portNum.TabIndex = 0;
            // 
            // sendPortNb
            // 
            this.sendPortNb.Location = new System.Drawing.Point(37, 98);
            this.sendPortNb.Name = "sendPortNb";
            this.sendPortNb.Size = new System.Drawing.Size(127, 23);
            this.sendPortNb.TabIndex = 1;
            this.sendPortNb.Text = "Send PortNb";
            this.sendPortNb.UseVisualStyleBackColor = true;
            this.sendPortNb.Click += new System.EventHandler(this.sendPortNb_Click);
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 370);
            this.Controls.Add(this.sendPortNb);
            this.Controls.Add(this.portNum);
            this.Name = "server";
            this.Text = "Sserver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox portNum;
        private System.Windows.Forms.Button sendPortNb;
    }
}

