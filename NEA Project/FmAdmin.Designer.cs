namespace NEA_Project
{
    partial class FmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btOrder = new System.Windows.Forms.Button();
            this.BtSeating = new System.Windows.Forms.Button();
            this.BtTrans = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btAccounts = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btStatistics = new System.Windows.Forms.Button();
            this.lbLoginAttempts = new System.Windows.Forms.Label();
            this.lbLoginAttemptsText = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbLoginFailed = new System.Windows.Forms.Label();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCountdown = new System.Windows.Forms.Label();
            this.gbLockedLogin = new System.Windows.Forms.GroupBox();
            this.gbLogin.SuspendLayout();
            this.gbLockedLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "Options:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(270, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(293, 65);
            this.label2.TabIndex = 6;
            this.label2.Text = "Admin Panel";
            // 
            // btOrder
            // 
            this.btOrder.BackColor = System.Drawing.Color.LightGray;
            this.btOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOrder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrder.Location = new System.Drawing.Point(12, 143);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(129, 40);
            this.btOrder.TabIndex = 7;
            this.btOrder.Text = "Orders";
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // BtSeating
            // 
            this.BtSeating.BackColor = System.Drawing.Color.LightGray;
            this.BtSeating.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSeating.Location = new System.Drawing.Point(12, 204);
            this.BtSeating.Name = "BtSeating";
            this.BtSeating.Size = new System.Drawing.Size(129, 40);
            this.BtSeating.TabIndex = 8;
            this.BtSeating.Text = "Seating";
            this.BtSeating.UseVisualStyleBackColor = false;
            this.BtSeating.Click += new System.EventHandler(this.BtSeating_Click);
            // 
            // BtTrans
            // 
            this.BtTrans.BackColor = System.Drawing.Color.LightGray;
            this.BtTrans.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtTrans.Location = new System.Drawing.Point(12, 267);
            this.BtTrans.Name = "BtTrans";
            this.BtTrans.Size = new System.Drawing.Size(129, 40);
            this.BtTrans.TabIndex = 9;
            this.BtTrans.Text = "Transactions";
            this.BtTrans.UseVisualStyleBackColor = false;
            this.BtTrans.Click += new System.EventHandler(this.BtTrans_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(718, 391);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(70, 47);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btAccounts
            // 
            this.btAccounts.BackColor = System.Drawing.Color.LightGray;
            this.btAccounts.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccounts.Location = new System.Drawing.Point(12, 328);
            this.btAccounts.Name = "btAccounts";
            this.btAccounts.Size = new System.Drawing.Size(129, 40);
            this.btAccounts.TabIndex = 11;
            this.btAccounts.Text = "Accounts";
            this.btAccounts.UseVisualStyleBackColor = false;
            this.btAccounts.Click += new System.EventHandler(this.btAccounts_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btStatistics
            // 
            this.btStatistics.BackColor = System.Drawing.Color.LightGray;
            this.btStatistics.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStatistics.Location = new System.Drawing.Point(12, 391);
            this.btStatistics.Name = "btStatistics";
            this.btStatistics.Size = new System.Drawing.Size(129, 40);
            this.btStatistics.TabIndex = 29;
            this.btStatistics.Text = "Statistics/Offers";
            this.btStatistics.UseVisualStyleBackColor = false;
            this.btStatistics.Click += new System.EventHandler(this.btStatistics_Click);
            // 
            // lbLoginAttempts
            // 
            this.lbLoginAttempts.AutoSize = true;
            this.lbLoginAttempts.BackColor = System.Drawing.Color.Transparent;
            this.lbLoginAttempts.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginAttempts.ForeColor = System.Drawing.Color.Red;
            this.lbLoginAttempts.Location = new System.Drawing.Point(60, 35);
            this.lbLoginAttempts.Name = "lbLoginAttempts";
            this.lbLoginAttempts.Size = new System.Drawing.Size(33, 40);
            this.lbLoginAttempts.TabIndex = 30;
            this.lbLoginAttempts.Text = "0";
            this.lbLoginAttempts.Visible = false;
            // 
            // lbLoginAttemptsText
            // 
            this.lbLoginAttemptsText.AutoSize = true;
            this.lbLoginAttemptsText.BackColor = System.Drawing.Color.Black;
            this.lbLoginAttemptsText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginAttemptsText.ForeColor = System.Drawing.Color.Red;
            this.lbLoginAttemptsText.Location = new System.Drawing.Point(6, 15);
            this.lbLoginAttemptsText.Name = "lbLoginAttemptsText";
            this.lbLoginAttemptsText.Size = new System.Drawing.Size(148, 20);
            this.lbLoginAttemptsText.TabIndex = 29;
            this.lbLoginAttemptsText.Text = "Attempts Remaining:";
            this.lbLoginAttemptsText.Visible = false;
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(320, 55);
            this.txId.Name = "txId";
            this.txId.PasswordChar = '*';
            this.txId.Size = new System.Drawing.Size(74, 20);
            this.txId.TabIndex = 21;
            this.txId.Click += new System.EventHandler(this.txId_Click);
            // 
            // txUsername
            // 
            this.txUsername.Location = new System.Drawing.Point(273, 140);
            this.txUsername.Name = "txUsername";
            this.txUsername.PasswordChar = '*';
            this.txUsername.Size = new System.Drawing.Size(169, 20);
            this.txUsername.TabIndex = 22;
            this.txUsername.Click += new System.EventHandler(this.txUsername_Click);
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(273, 217);
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.Size = new System.Drawing.Size(169, 20);
            this.txPassword.TabIndex = 23;
            this.txPassword.Click += new System.EventHandler(this.txPassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(286, 54);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(316, 105);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(321, 183);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Password:";
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.LightGray;
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(556, 288);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(129, 40);
            this.btLogin.TabIndex = 26;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbLoginFailed
            // 
            this.lbLoginFailed.AutoSize = true;
            this.lbLoginFailed.BackColor = System.Drawing.Color.Black;
            this.lbLoginFailed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginFailed.ForeColor = System.Drawing.Color.Red;
            this.lbLoginFailed.Location = new System.Drawing.Point(245, 272);
            this.lbLoginFailed.Name = "lbLoginFailed";
            this.lbLoginFailed.Size = new System.Drawing.Size(249, 20);
            this.lbLoginFailed.TabIndex = 27;
            this.lbLoginFailed.Text = "Some details weren\'t right. Try again";
            this.lbLoginFailed.Visible = false;
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.Gray;
            this.gbLogin.Controls.Add(this.lbLoginFailed);
            this.gbLogin.Controls.Add(this.btLogin);
            this.gbLogin.Controls.Add(this.label5);
            this.gbLogin.Controls.Add(this.label4);
            this.gbLogin.Controls.Add(this.label3);
            this.gbLogin.Controls.Add(this.txPassword);
            this.gbLogin.Controls.Add(this.txUsername);
            this.gbLogin.Controls.Add(this.txId);
            this.gbLogin.Controls.Add(this.lbLoginAttemptsText);
            this.gbLogin.Controls.Add(this.lbLoginAttempts);
            this.gbLogin.Location = new System.Drawing.Point(3, 71);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(709, 361);
            this.gbLogin.TabIndex = 12;
            this.gbLogin.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(123, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(479, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "Too many failed login attempts try again in:";
            // 
            // lbCountdown
            // 
            this.lbCountdown.AutoSize = true;
            this.lbCountdown.BackColor = System.Drawing.Color.Black;
            this.lbCountdown.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountdown.ForeColor = System.Drawing.Color.Red;
            this.lbCountdown.Location = new System.Drawing.Point(314, 105);
            this.lbCountdown.Name = "lbCountdown";
            this.lbCountdown.Size = new System.Drawing.Size(102, 32);
            this.lbCountdown.TabIndex = 29;
            this.lbCountdown.Text = "00:00:00";
            // 
            // gbLockedLogin
            // 
            this.gbLockedLogin.BackColor = System.Drawing.SystemColors.ControlText;
            this.gbLockedLogin.Controls.Add(this.lbCountdown);
            this.gbLockedLogin.Controls.Add(this.label6);
            this.gbLockedLogin.Location = new System.Drawing.Point(3, 70);
            this.gbLockedLogin.Name = "gbLockedLogin";
            this.gbLockedLogin.Size = new System.Drawing.Size(709, 361);
            this.gbLockedLogin.TabIndex = 28;
            this.gbLockedLogin.TabStop = false;
            this.gbLockedLogin.Visible = false;
            // 
            // FmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbLockedLogin);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.btAccounts);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.BtTrans);
            this.Controls.Add(this.BtSeating);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStatistics);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FmAdmin";
            this.Text = "FmAdmin";
            this.Load += new System.EventHandler(this.FmAdmin_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbLockedLogin.ResumeLayout(false);
            this.gbLockedLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button BtSeating;
        private System.Windows.Forms.Button BtTrans;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btAccounts;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btStatistics;
        private System.Windows.Forms.Label lbLoginAttempts;
        private System.Windows.Forms.Label lbLoginAttemptsText;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbLoginFailed;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCountdown;
        private System.Windows.Forms.GroupBox gbLockedLogin;
    }
}