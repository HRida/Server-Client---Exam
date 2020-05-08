namespace Question1
{
    partial class client
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
            this.cnxPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendPort = new System.Windows.Forms.Button();
            this.portNb = new System.Windows.Forms.TextBox();
            this.serverName = new System.Windows.Forms.TextBox();
            this.userPassPanel = new System.Windows.Forms.Panel();
            this.sendPass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sendUser = new System.Windows.Forms.Button();
            this.passwrd = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.cnxPanel.SuspendLayout();
            this.userPassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cnxPanel
            // 
            this.cnxPanel.Controls.Add(this.label2);
            this.cnxPanel.Controls.Add(this.label1);
            this.cnxPanel.Controls.Add(this.sendPort);
            this.cnxPanel.Controls.Add(this.portNb);
            this.cnxPanel.Controls.Add(this.serverName);
            this.cnxPanel.Location = new System.Drawing.Point(32, 30);
            this.cnxPanel.Name = "cnxPanel";
            this.cnxPanel.Size = new System.Drawing.Size(253, 166);
            this.cnxPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port Nb";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server Name";
            // 
            // sendPort
            // 
            this.sendPort.Location = new System.Drawing.Point(85, 126);
            this.sendPort.Name = "sendPort";
            this.sendPort.Size = new System.Drawing.Size(156, 23);
            this.sendPort.TabIndex = 2;
            this.sendPort.Text = "Send Port Nb";
            this.sendPort.UseVisualStyleBackColor = true;
            this.sendPort.Click += new System.EventHandler(this.sendPort_Click);
            // 
            // portNb
            // 
            this.portNb.Location = new System.Drawing.Point(85, 87);
            this.portNb.Name = "portNb";
            this.portNb.Size = new System.Drawing.Size(156, 20);
            this.portNb.TabIndex = 1;
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(85, 26);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(156, 20);
            this.serverName.TabIndex = 0;
            // 
            // userPassPanel
            // 
            this.userPassPanel.Controls.Add(this.sendPass);
            this.userPassPanel.Controls.Add(this.label4);
            this.userPassPanel.Controls.Add(this.label3);
            this.userPassPanel.Controls.Add(this.sendUser);
            this.userPassPanel.Controls.Add(this.passwrd);
            this.userPassPanel.Controls.Add(this.userName);
            this.userPassPanel.Enabled = false;
            this.userPassPanel.Location = new System.Drawing.Point(291, 30);
            this.userPassPanel.Name = "userPassPanel";
            this.userPassPanel.Size = new System.Drawing.Size(253, 166);
            this.userPassPanel.TabIndex = 3;
            // 
            // sendPass
            // 
            this.sendPass.Location = new System.Drawing.Point(82, 126);
            this.sendPass.Name = "sendPass";
            this.sendPass.Size = new System.Drawing.Size(156, 23);
            this.sendPass.TabIndex = 7;
            this.sendPass.Text = "SendPass";
            this.sendPass.UseVisualStyleBackColor = true;
            this.sendPass.Click += new System.EventHandler(this.sendPass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Name";
            // 
            // sendUser
            // 
            this.sendUser.Location = new System.Drawing.Point(82, 58);
            this.sendUser.Name = "sendUser";
            this.sendUser.Size = new System.Drawing.Size(156, 23);
            this.sendUser.TabIndex = 2;
            this.sendUser.Text = "SendUserName";
            this.sendUser.UseVisualStyleBackColor = true;
            this.sendUser.Click += new System.EventHandler(this.sendUser_Click);
            // 
            // passwrd
            // 
            this.passwrd.Enabled = false;
            this.passwrd.Location = new System.Drawing.Point(82, 87);
            this.passwrd.Name = "passwrd";
            this.passwrd.Size = new System.Drawing.Size(156, 20);
            this.passwrd.TabIndex = 1;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(82, 26);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(156, 20);
            this.userName.TabIndex = 0;
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 358);
            this.Controls.Add(this.userPassPanel);
            this.Controls.Add(this.cnxPanel);
            this.Name = "client";
            this.Text = "client";
            this.cnxPanel.ResumeLayout(false);
            this.cnxPanel.PerformLayout();
            this.userPassPanel.ResumeLayout(false);
            this.userPassPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cnxPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendPort;
        private System.Windows.Forms.TextBox portNb;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.Panel userPassPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendUser;
        private System.Windows.Forms.TextBox passwrd;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button sendPass;
    }
}