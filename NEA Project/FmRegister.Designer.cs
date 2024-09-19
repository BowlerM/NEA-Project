namespace NEA_Project
{
    partial class FmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmRegister));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.BtSave = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbInvalidUsername = new System.Windows.Forms.Label();
            this.btShow = new System.Windows.Forms.Button();
            this.btHide = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.lbIsNull = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbAccountCreated = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.btNext = new System.Windows.Forms.Button();
            this.lbEmailTaken = new System.Windows.Forms.Label();
            this.lbInvalidEmail = new System.Windows.Forms.Label();
            this.lbEnterConfirmationCode = new System.Windows.Forms.Label();
            this.txConfirmationCode = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.lbIncorrectCode = new System.Windows.Forms.Label();
            this.lbCorrectCode = new System.Windows.Forms.Label();
            this.lbInvalidName = new System.Windows.Forms.Label();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAccountCreated.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Customer?";
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbRegister.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.Location = new System.Drawing.Point(5, 143);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(172, 37);
            this.lbRegister.TabIndex = 6;
            this.lbRegister.Text = "Enter Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(19, 387);
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.Size = new System.Drawing.Size(185, 20);
            this.txPassword.TabIndex = 10;
            this.txPassword.Click += new System.EventHandler(this.txPassword_Click);
            // 
            // txUsername
            // 
            this.txUsername.Location = new System.Drawing.Point(19, 261);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(185, 20);
            this.txUsername.TabIndex = 11;
            this.txUsername.Click += new System.EventHandler(this.txUsername_Click);
            // 
            // BtSave
            // 
            this.BtSave.BackColor = System.Drawing.Color.LightSalmon;
            this.BtSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSave.Location = new System.Drawing.Point(226, 398);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(81, 32);
            this.BtSave.TabIndex = 13;
            this.BtSave.Text = "Save";
            this.BtSave.UseVisualStyleBackColor = false;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(718, 396);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(70, 47);
            this.btExit.TabIndex = 14;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbInvalidUsername
            // 
            this.lbInvalidUsername.AutoSize = true;
            this.lbInvalidUsername.BackColor = System.Drawing.Color.Wheat;
            this.lbInvalidUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalidUsername.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidUsername.Location = new System.Drawing.Point(210, 256);
            this.lbInvalidUsername.Name = "lbInvalidUsername";
            this.lbInvalidUsername.Size = new System.Drawing.Size(150, 25);
            this.lbInvalidUsername.TabIndex = 15;
            this.lbInvalidUsername.Text = "Username Taken";
            this.lbInvalidUsername.Visible = false;
            // 
            // btShow
            // 
            this.btShow.BackColor = System.Drawing.Color.LightSalmon;
            this.btShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow.Location = new System.Drawing.Point(19, 413);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(67, 30);
            this.btShow.TabIndex = 16;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = false;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btHide
            // 
            this.btHide.BackColor = System.Drawing.Color.LightSalmon;
            this.btHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHide.Location = new System.Drawing.Point(19, 413);
            this.btHide.Name = "btHide";
            this.btHide.Size = new System.Drawing.Size(67, 30);
            this.btHide.TabIndex = 17;
            this.btHide.Text = "Hide";
            this.btHide.UseVisualStyleBackColor = false;
            this.btHide.Visible = false;
            this.btHide.Click += new System.EventHandler(this.btHide_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.LightSalmon;
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Location = new System.Drawing.Point(574, 391);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(84, 34);
            this.btBack.TabIndex = 28;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbIsNull
            // 
            this.lbIsNull.AutoSize = true;
            this.lbIsNull.BackColor = System.Drawing.Color.Wheat;
            this.lbIsNull.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsNull.ForeColor = System.Drawing.Color.Red;
            this.lbIsNull.Location = new System.Drawing.Point(313, 401);
            this.lbIsNull.Name = "lbIsNull";
            this.lbIsNull.Size = new System.Drawing.Size(156, 25);
            this.lbIsNull.TabIndex = 30;
            this.lbIsNull.Text = "Cannot be empty";
            this.lbIsNull.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Chocolate;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(643, 65);
            this.label8.TabIndex = 0;
            this.label8.Text = "Account Successfully Created";
            // 
            // gbAccountCreated
            // 
            this.gbAccountCreated.BackColor = System.Drawing.Color.Chocolate;
            this.gbAccountCreated.Controls.Add(this.label8);
            this.gbAccountCreated.Location = new System.Drawing.Point(2, 132);
            this.gbAccountCreated.Name = "gbAccountCreated";
            this.gbAccountCreated.Size = new System.Drawing.Size(710, 311);
            this.gbAccountCreated.TabIndex = 29;
            this.gbAccountCreated.TabStop = false;
            this.gbAccountCreated.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "First Name* :";
            // 
            // txFirstName
            // 
            this.txFirstName.Location = new System.Drawing.Point(134, 19);
            this.txFirstName.Name = "txFirstName";
            this.txFirstName.Size = new System.Drawing.Size(185, 20);
            this.txFirstName.TabIndex = 20;
            this.txFirstName.Click += new System.EventHandler(this.txFirstName_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(325, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Surname* :";
            // 
            // txSurname
            // 
            this.txSurname.Location = new System.Drawing.Point(435, 19);
            this.txSurname.Name = "txSurname";
            this.txSurname.Size = new System.Drawing.Size(185, 20);
            this.txSurname.TabIndex = 22;
            this.txSurname.Click += new System.EventHandler(this.txSurname_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Email* :";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(93, 86);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(503, 20);
            this.txEmail.TabIndex = 24;
            this.txEmail.Click += new System.EventHandler(this.txEmail_Click);
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.Wheat;
            this.btNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Location = new System.Drawing.Point(569, 198);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(84, 34);
            this.btNext.TabIndex = 27;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // lbEmailTaken
            // 
            this.lbEmailTaken.AutoSize = true;
            this.lbEmailTaken.BackColor = System.Drawing.Color.Wheat;
            this.lbEmailTaken.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailTaken.ForeColor = System.Drawing.Color.Red;
            this.lbEmailTaken.Location = new System.Drawing.Point(340, 109);
            this.lbEmailTaken.Name = "lbEmailTaken";
            this.lbEmailTaken.Size = new System.Drawing.Size(256, 20);
            this.lbEmailTaken.TabIndex = 28;
            this.lbEmailTaken.Text = "Account with this email already exists";
            this.lbEmailTaken.Visible = false;
            // 
            // lbInvalidEmail
            // 
            this.lbInvalidEmail.AutoSize = true;
            this.lbInvalidEmail.BackColor = System.Drawing.Color.Wheat;
            this.lbInvalidEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalidEmail.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidEmail.Location = new System.Drawing.Point(98, 109);
            this.lbInvalidEmail.Name = "lbInvalidEmail";
            this.lbInvalidEmail.Size = new System.Drawing.Size(94, 20);
            this.lbInvalidEmail.TabIndex = 30;
            this.lbInvalidEmail.Text = "Invalid Email";
            this.lbInvalidEmail.Visible = false;
            // 
            // lbEnterConfirmationCode
            // 
            this.lbEnterConfirmationCode.AutoSize = true;
            this.lbEnterConfirmationCode.BackColor = System.Drawing.Color.Black;
            this.lbEnterConfirmationCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterConfirmationCode.ForeColor = System.Drawing.Color.White;
            this.lbEnterConfirmationCode.Location = new System.Drawing.Point(6, 205);
            this.lbEnterConfirmationCode.Name = "lbEnterConfirmationCode";
            this.lbEnterConfirmationCode.Size = new System.Drawing.Size(225, 25);
            this.lbEnterConfirmationCode.TabIndex = 31;
            this.lbEnterConfirmationCode.Text = "Enter Confirmation Code:";
            this.lbEnterConfirmationCode.Visible = false;
            // 
            // txConfirmationCode
            // 
            this.txConfirmationCode.Location = new System.Drawing.Point(237, 208);
            this.txConfirmationCode.Name = "txConfirmationCode";
            this.txConfirmationCode.Size = new System.Drawing.Size(77, 20);
            this.txConfirmationCode.TabIndex = 32;
            this.txConfirmationCode.Visible = false;
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.Color.Wheat;
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(319, 208);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(63, 22);
            this.btConfirm.TabIndex = 33;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Visible = false;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // lbIncorrectCode
            // 
            this.lbIncorrectCode.AutoSize = true;
            this.lbIncorrectCode.BackColor = System.Drawing.Color.Wheat;
            this.lbIncorrectCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIncorrectCode.ForeColor = System.Drawing.Color.Red;
            this.lbIncorrectCode.Location = new System.Drawing.Point(401, 208);
            this.lbIncorrectCode.Name = "lbIncorrectCode";
            this.lbIncorrectCode.Size = new System.Drawing.Size(135, 20);
            this.lbIncorrectCode.TabIndex = 34;
            this.lbIncorrectCode.Text = "Code was incorrect";
            this.lbIncorrectCode.Visible = false;
            // 
            // lbCorrectCode
            // 
            this.lbCorrectCode.AutoSize = true;
            this.lbCorrectCode.BackColor = System.Drawing.Color.Wheat;
            this.lbCorrectCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorrectCode.ForeColor = System.Drawing.Color.LightGreen;
            this.lbCorrectCode.Location = new System.Drawing.Point(401, 208);
            this.lbCorrectCode.Name = "lbCorrectCode";
            this.lbCorrectCode.Size = new System.Drawing.Size(123, 20);
            this.lbCorrectCode.TabIndex = 35;
            this.lbCorrectCode.Text = "Code was correct";
            this.lbCorrectCode.Visible = false;
            // 
            // lbInvalidName
            // 
            this.lbInvalidName.AutoSize = true;
            this.lbInvalidName.BackColor = System.Drawing.Color.Wheat;
            this.lbInvalidName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalidName.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidName.Location = new System.Drawing.Point(263, 52);
            this.lbInvalidName.Name = "lbInvalidName";
            this.lbInvalidName.Size = new System.Drawing.Size(204, 20);
            this.lbInvalidName.TabIndex = 36;
            this.lbInvalidName.Text = "Name is not in correct format";
            this.lbInvalidName.Visible = false;
            // 
            // gbRegister
            // 
            this.gbRegister.BackColor = System.Drawing.Color.Chocolate;
            this.gbRegister.Controls.Add(this.lbInvalidName);
            this.gbRegister.Controls.Add(this.lbCorrectCode);
            this.gbRegister.Controls.Add(this.lbIncorrectCode);
            this.gbRegister.Controls.Add(this.btConfirm);
            this.gbRegister.Controls.Add(this.txConfirmationCode);
            this.gbRegister.Controls.Add(this.lbEnterConfirmationCode);
            this.gbRegister.Controls.Add(this.lbInvalidEmail);
            this.gbRegister.Controls.Add(this.lbEmailTaken);
            this.gbRegister.Controls.Add(this.btNext);
            this.gbRegister.Controls.Add(this.txEmail);
            this.gbRegister.Controls.Add(this.label6);
            this.gbRegister.Controls.Add(this.txSurname);
            this.gbRegister.Controls.Add(this.label5);
            this.gbRegister.Controls.Add(this.txFirstName);
            this.gbRegister.Controls.Add(this.label2);
            this.gbRegister.Location = new System.Drawing.Point(2, 193);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(676, 250);
            this.gbRegister.TabIndex = 18;
            this.gbRegister.TabStop = false;
            // 
            // FmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAccountCreated);
            this.Controls.Add(this.gbRegister);
            this.Controls.Add(this.btHide);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.lbInvalidUsername);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbIsNull);
            this.Name = "FmRegister";
            this.Text = "FmRegister";
            this.Load += new System.EventHandler(this.FmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAccountCreated.ResumeLayout(false);
            this.gbAccountCreated.PerformLayout();
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbInvalidUsername;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btHide;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label lbIsNull;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbAccountCreated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label lbEmailTaken;
        private System.Windows.Forms.Label lbInvalidEmail;
        private System.Windows.Forms.Label lbEnterConfirmationCode;
        private System.Windows.Forms.TextBox txConfirmationCode;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbIncorrectCode;
        private System.Windows.Forms.Label lbCorrectCode;
        private System.Windows.Forms.Label lbInvalidName;
        private System.Windows.Forms.GroupBox gbRegister;
    }
}