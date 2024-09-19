namespace NEA_Project
{
    partial class FmManageAccounts
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
            this.label2 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btExit = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbEmailSearch = new System.Windows.Forms.RadioButton();
            this.rbIdSearch = new System.Windows.Forms.RadioButton();
            this.rbNameSearch = new System.Windows.Forms.RadioButton();
            this.txId = new System.Windows.Forms.TextBox();
            this.txFirstName = new System.Windows.Forms.TextBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txSecondName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.lbInvalidId = new System.Windows.Forms.Label();
            this.lbInvalidName = new System.Windows.Forms.Label();
            this.lbInvalidEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbDeleteAccount = new System.Windows.Forms.RadioButton();
            this.txIdDelete = new System.Windows.Forms.TextBox();
            this.lbIdDelete = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.lbInvalidIdDelete = new System.Windows.Forms.Label();
            this.rbChangeDetails = new System.Windows.Forms.RadioButton();
            this.lbIdEdit = new System.Windows.Forms.Label();
            this.txIdEdit = new System.Windows.Forms.TextBox();
            this.btChange = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.rbChangeFirstName = new System.Windows.Forms.RadioButton();
            this.rbChangeSecondName = new System.Windows.Forms.RadioButton();
            this.rbChangePassword = new System.Windows.Forms.RadioButton();
            this.txChangeFirstName = new System.Windows.Forms.TextBox();
            this.txChangePassword = new System.Windows.Forms.TextBox();
            this.txChangeSecondName = new System.Windows.Forms.TextBox();
            this.lbInvalidIdEdit = new System.Windows.Forms.Label();
            this.lbSuccessfullyChanged = new System.Windows.Forms.Label();
            this.lbSuccessfullyDeleted = new System.Windows.Forms.Label();
            this.lbIsNull = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(313, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(163, 47);
            this.label2.TabIndex = 8;
            this.label2.Text = "Accounts";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 243);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(695, 195);
            this.grid.TabIndex = 9;
            this.grid.Visible = false;
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
            this.btExit.TabIndex = 12;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btShow
            // 
            this.btShow.BackColor = System.Drawing.Color.LightGray;
            this.btShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btShow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow.Location = new System.Drawing.Point(12, 187);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(117, 32);
            this.btShow.TabIndex = 14;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = false;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Location = new System.Drawing.Point(15, 83);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(114, 17);
            this.rbShowAll.TabIndex = 15;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "Show All Accounts";
            this.rbShowAll.UseVisualStyleBackColor = true;
            this.rbShowAll.CheckedChanged += new System.EventHandler(this.rbShowAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search By:";
            // 
            // rbEmailSearch
            // 
            this.rbEmailSearch.AutoSize = true;
            this.rbEmailSearch.Location = new System.Drawing.Point(15, 164);
            this.rbEmailSearch.Name = "rbEmailSearch";
            this.rbEmailSearch.Size = new System.Drawing.Size(50, 17);
            this.rbEmailSearch.TabIndex = 20;
            this.rbEmailSearch.TabStop = true;
            this.rbEmailSearch.Text = "Email";
            this.rbEmailSearch.UseVisualStyleBackColor = true;
            this.rbEmailSearch.CheckedChanged += new System.EventHandler(this.rbEmailSearch_CheckedChanged);
            // 
            // rbIdSearch
            // 
            this.rbIdSearch.AutoSize = true;
            this.rbIdSearch.Location = new System.Drawing.Point(15, 121);
            this.rbIdSearch.Name = "rbIdSearch";
            this.rbIdSearch.Size = new System.Drawing.Size(36, 17);
            this.rbIdSearch.TabIndex = 21;
            this.rbIdSearch.TabStop = true;
            this.rbIdSearch.Text = "ID";
            this.rbIdSearch.UseVisualStyleBackColor = true;
            this.rbIdSearch.CheckedChanged += new System.EventHandler(this.rbIdSearch_CheckedChanged);
            // 
            // rbNameSearch
            // 
            this.rbNameSearch.AutoSize = true;
            this.rbNameSearch.Location = new System.Drawing.Point(15, 141);
            this.rbNameSearch.Name = "rbNameSearch";
            this.rbNameSearch.Size = new System.Drawing.Size(53, 17);
            this.rbNameSearch.TabIndex = 22;
            this.rbNameSearch.TabStop = true;
            this.rbNameSearch.Text = "Name";
            this.rbNameSearch.UseVisualStyleBackColor = true;
            this.rbNameSearch.CheckedChanged += new System.EventHandler(this.rbNameSearch_CheckedChanged);
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(89, 123);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(100, 20);
            this.txId.TabIndex = 23;
            this.txId.Visible = false;
            this.txId.Click += new System.EventHandler(this.txId_Click);
            // 
            // txFirstName
            // 
            this.txFirstName.Location = new System.Drawing.Point(89, 141);
            this.txFirstName.Name = "txFirstName";
            this.txFirstName.Size = new System.Drawing.Size(100, 20);
            this.txFirstName.TabIndex = 24;
            this.txFirstName.Visible = false;
            this.txFirstName.Click += new System.EventHandler(this.txFirstName_Click);
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(89, 161);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(100, 20);
            this.txEmail.TabIndex = 25;
            this.txEmail.Visible = false;
            this.txEmail.Click += new System.EventHandler(this.txEmail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(195, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Display Accounts";
            // 
            // txSecondName
            // 
            this.txSecondName.Location = new System.Drawing.Point(195, 141);
            this.txSecondName.Name = "txSecondName";
            this.txSecondName.Size = new System.Drawing.Size(100, 20);
            this.txSecondName.TabIndex = 27;
            this.txSecondName.Visible = false;
            this.txSecondName.Click += new System.EventHandler(this.txSecondName_Click);
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.BackColor = System.Drawing.Color.Black;
            this.lbFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.ForeColor = System.Drawing.Color.White;
            this.lbFirstName.Location = new System.Drawing.Point(104, 123);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFirstName.Size = new System.Drawing.Size(64, 15);
            this.lbFirstName.TabIndex = 28;
            this.lbFirstName.Text = "First Name";
            this.lbFirstName.Visible = false;
            // 
            // lbSecondName
            // 
            this.lbSecondName.AutoSize = true;
            this.lbSecondName.BackColor = System.Drawing.Color.Black;
            this.lbSecondName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecondName.ForeColor = System.Drawing.Color.White;
            this.lbSecondName.Location = new System.Drawing.Point(204, 122);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbSecondName.Size = new System.Drawing.Size(81, 15);
            this.lbSecondName.TabIndex = 29;
            this.lbSecondName.Text = "Second Name";
            this.lbSecondName.Visible = false;
            // 
            // lbInvalidId
            // 
            this.lbInvalidId.AutoSize = true;
            this.lbInvalidId.BackColor = System.Drawing.Color.Transparent;
            this.lbInvalidId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalidId.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidId.Location = new System.Drawing.Point(195, 121);
            this.lbInvalidId.Name = "lbInvalidId";
            this.lbInvalidId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInvalidId.Size = new System.Drawing.Size(72, 20);
            this.lbInvalidId.TabIndex = 30;
            this.lbInvalidId.Text = "‌Invalid ID";
            this.lbInvalidId.Visible = false;
            // 
            // lbInvalidName
            // 
            this.lbInvalidName.AutoSize = true;
            this.lbInvalidName.BackColor = System.Drawing.Color.Transparent;
            this.lbInvalidName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalidName.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidName.Location = new System.Drawing.Point(301, 141);
            this.lbInvalidName.Name = "lbInvalidName";
            this.lbInvalidName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInvalidName.Size = new System.Drawing.Size(97, 20);
            this.lbInvalidName.TabIndex = 31;
            this.lbInvalidName.Text = "Invalid Name";
            this.lbInvalidName.Visible = false;
            // 
            // lbInvalidEmail
            // 
            this.lbInvalidEmail.AutoSize = true;
            this.lbInvalidEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbInvalidEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalidEmail.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidEmail.Location = new System.Drawing.Point(195, 164);
            this.lbInvalidEmail.Name = "lbInvalidEmail";
            this.lbInvalidEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInvalidEmail.Size = new System.Drawing.Size(94, 20);
            this.lbInvalidEmail.TabIndex = 32;
            this.lbInvalidEmail.Text = "Invalid Email";
            this.lbInvalidEmail.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(482, 38);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 33;
            this.label4.Text = "Edit Accounts";
            // 
            // rbDeleteAccount
            // 
            this.rbDeleteAccount.AutoSize = true;
            this.rbDeleteAccount.Location = new System.Drawing.Point(479, 83);
            this.rbDeleteAccount.Name = "rbDeleteAccount";
            this.rbDeleteAccount.Size = new System.Drawing.Size(99, 17);
            this.rbDeleteAccount.TabIndex = 34;
            this.rbDeleteAccount.TabStop = true;
            this.rbDeleteAccount.Text = "Delete Account";
            this.rbDeleteAccount.UseVisualStyleBackColor = true;
            this.rbDeleteAccount.CheckedChanged += new System.EventHandler(this.rbDeleteAccount_CheckedChanged);
            // 
            // txIdDelete
            // 
            this.txIdDelete.Location = new System.Drawing.Point(625, 83);
            this.txIdDelete.Name = "txIdDelete";
            this.txIdDelete.Size = new System.Drawing.Size(100, 20);
            this.txIdDelete.TabIndex = 35;
            this.txIdDelete.Visible = false;
            this.txIdDelete.Click += new System.EventHandler(this.txIdDelete_Click);
            // 
            // lbIdDelete
            // 
            this.lbIdDelete.AutoSize = true;
            this.lbIdDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdDelete.Location = new System.Drawing.Point(594, 85);
            this.lbIdDelete.Name = "lbIdDelete";
            this.lbIdDelete.Size = new System.Drawing.Size(25, 13);
            this.lbIdDelete.TabIndex = 36;
            this.lbIdDelete.Text = "ID -";
            this.lbIdDelete.Visible = false;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Red;
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(731, 78);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(57, 28);
            this.btDelete.TabIndex = 37;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lbInvalidIdDelete
            // 
            this.lbInvalidIdDelete.AutoSize = true;
            this.lbInvalidIdDelete.BackColor = System.Drawing.Color.Transparent;
            this.lbInvalidIdDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalidIdDelete.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidIdDelete.Location = new System.Drawing.Point(653, 60);
            this.lbInvalidIdDelete.Name = "lbInvalidIdDelete";
            this.lbInvalidIdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInvalidIdDelete.Size = new System.Drawing.Size(72, 20);
            this.lbInvalidIdDelete.TabIndex = 38;
            this.lbInvalidIdDelete.Text = "‌Invalid ID";
            this.lbInvalidIdDelete.Visible = false;
            // 
            // rbChangeDetails
            // 
            this.rbChangeDetails.AutoSize = true;
            this.rbChangeDetails.Location = new System.Drawing.Point(479, 126);
            this.rbChangeDetails.Name = "rbChangeDetails";
            this.rbChangeDetails.Size = new System.Drawing.Size(97, 17);
            this.rbChangeDetails.TabIndex = 39;
            this.rbChangeDetails.TabStop = true;
            this.rbChangeDetails.Text = "Change Details";
            this.rbChangeDetails.UseVisualStyleBackColor = true;
            this.rbChangeDetails.CheckedChanged += new System.EventHandler(this.rbChangeDetails_CheckedChanged);
            // 
            // lbIdEdit
            // 
            this.lbIdEdit.AutoSize = true;
            this.lbIdEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdEdit.Location = new System.Drawing.Point(594, 128);
            this.lbIdEdit.Name = "lbIdEdit";
            this.lbIdEdit.Size = new System.Drawing.Size(25, 13);
            this.lbIdEdit.TabIndex = 40;
            this.lbIdEdit.Text = "ID -";
            this.lbIdEdit.Visible = false;
            // 
            // txIdEdit
            // 
            this.txIdEdit.Location = new System.Drawing.Point(625, 128);
            this.txIdEdit.Name = "txIdEdit";
            this.txIdEdit.Size = new System.Drawing.Size(100, 20);
            this.txIdEdit.TabIndex = 41;
            this.txIdEdit.Visible = false;
            this.txIdEdit.Click += new System.EventHandler(this.txIdEdit_Click);
            // 
            // btChange
            // 
            this.btChange.BackColor = System.Drawing.Color.Green;
            this.btChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btChange.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChange.Location = new System.Drawing.Point(731, 215);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(57, 28);
            this.btChange.TabIndex = 42;
            this.btChange.Text = "Change";
            this.btChange.UseVisualStyleBackColor = false;
            this.btChange.Visible = false;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.Color.LightGray;
            this.btFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFind.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.Location = new System.Drawing.Point(731, 123);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(57, 30);
            this.btFind.TabIndex = 43;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Visible = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // rbChangeFirstName
            // 
            this.rbChangeFirstName.AutoSize = true;
            this.rbChangeFirstName.Location = new System.Drawing.Point(515, 167);
            this.rbChangeFirstName.Name = "rbChangeFirstName";
            this.rbChangeFirstName.Size = new System.Drawing.Size(75, 17);
            this.rbChangeFirstName.TabIndex = 46;
            this.rbChangeFirstName.TabStop = true;
            this.rbChangeFirstName.Text = "First Name";
            this.rbChangeFirstName.UseVisualStyleBackColor = true;
            this.rbChangeFirstName.Visible = false;
            this.rbChangeFirstName.CheckedChanged += new System.EventHandler(this.rbChangeFirstName_CheckedChanged);
            // 
            // rbChangeSecondName
            // 
            this.rbChangeSecondName.AutoSize = true;
            this.rbChangeSecondName.Location = new System.Drawing.Point(596, 167);
            this.rbChangeSecondName.Name = "rbChangeSecondName";
            this.rbChangeSecondName.Size = new System.Drawing.Size(93, 17);
            this.rbChangeSecondName.TabIndex = 47;
            this.rbChangeSecondName.TabStop = true;
            this.rbChangeSecondName.Text = "Second Name";
            this.rbChangeSecondName.UseVisualStyleBackColor = true;
            this.rbChangeSecondName.Visible = false;
            this.rbChangeSecondName.CheckedChanged += new System.EventHandler(this.rbChangeSecondName_CheckedChanged);
            // 
            // rbChangePassword
            // 
            this.rbChangePassword.AutoSize = true;
            this.rbChangePassword.Location = new System.Drawing.Point(695, 167);
            this.rbChangePassword.Name = "rbChangePassword";
            this.rbChangePassword.Size = new System.Drawing.Size(71, 17);
            this.rbChangePassword.TabIndex = 48;
            this.rbChangePassword.TabStop = true;
            this.rbChangePassword.Text = "Password";
            this.rbChangePassword.UseVisualStyleBackColor = true;
            this.rbChangePassword.Visible = false;
            this.rbChangePassword.CheckedChanged += new System.EventHandler(this.rbChangePassword_CheckedChanged);
            // 
            // txChangeFirstName
            // 
            this.txChangeFirstName.Location = new System.Drawing.Point(515, 190);
            this.txChangeFirstName.Name = "txChangeFirstName";
            this.txChangeFirstName.Size = new System.Drawing.Size(93, 20);
            this.txChangeFirstName.TabIndex = 51;
            this.txChangeFirstName.Visible = false;
            this.txChangeFirstName.Click += new System.EventHandler(this.txChangeFirstName_Click);
            // 
            // txChangePassword
            // 
            this.txChangePassword.Location = new System.Drawing.Point(695, 190);
            this.txChangePassword.Name = "txChangePassword";
            this.txChangePassword.Size = new System.Drawing.Size(101, 20);
            this.txChangePassword.TabIndex = 53;
            this.txChangePassword.Visible = false;
            this.txChangePassword.Click += new System.EventHandler(this.txChangePassword_Click);
            // 
            // txChangeSecondName
            // 
            this.txChangeSecondName.Location = new System.Drawing.Point(597, 190);
            this.txChangeSecondName.Name = "txChangeSecondName";
            this.txChangeSecondName.Size = new System.Drawing.Size(92, 20);
            this.txChangeSecondName.TabIndex = 54;
            this.txChangeSecondName.Visible = false;
            this.txChangeSecondName.Click += new System.EventHandler(this.txChangeSecondName_Click);
            // 
            // lbInvalidIdEdit
            // 
            this.lbInvalidIdEdit.AutoSize = true;
            this.lbInvalidIdEdit.BackColor = System.Drawing.Color.Transparent;
            this.lbInvalidIdEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalidIdEdit.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidIdEdit.Location = new System.Drawing.Point(653, 106);
            this.lbInvalidIdEdit.Name = "lbInvalidIdEdit";
            this.lbInvalidIdEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInvalidIdEdit.Size = new System.Drawing.Size(72, 20);
            this.lbInvalidIdEdit.TabIndex = 55;
            this.lbInvalidIdEdit.Text = "‌Invalid ID";
            this.lbInvalidIdEdit.Visible = false;
            // 
            // lbSuccessfullyChanged
            // 
            this.lbSuccessfullyChanged.AutoSize = true;
            this.lbSuccessfullyChanged.BackColor = System.Drawing.Color.PaleGreen;
            this.lbSuccessfullyChanged.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuccessfullyChanged.ForeColor = System.Drawing.Color.Green;
            this.lbSuccessfullyChanged.Location = new System.Drawing.Point(507, 218);
            this.lbSuccessfullyChanged.Name = "lbSuccessfullyChanged";
            this.lbSuccessfullyChanged.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbSuccessfullyChanged.Size = new System.Drawing.Size(200, 20);
            this.lbSuccessfullyChanged.TabIndex = 57;
            this.lbSuccessfullyChanged.Text = "Details Successfully Changed";
            this.lbSuccessfullyChanged.Visible = false;
            // 
            // lbSuccessfullyDeleted
            // 
            this.lbSuccessfullyDeleted.AutoSize = true;
            this.lbSuccessfullyDeleted.BackColor = System.Drawing.Color.PaleGreen;
            this.lbSuccessfullyDeleted.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuccessfullyDeleted.ForeColor = System.Drawing.Color.Green;
            this.lbSuccessfullyDeleted.Location = new System.Drawing.Point(475, 106);
            this.lbSuccessfullyDeleted.Name = "lbSuccessfullyDeleted";
            this.lbSuccessfullyDeleted.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbSuccessfullyDeleted.Size = new System.Drawing.Size(202, 20);
            this.lbSuccessfullyDeleted.TabIndex = 58;
            this.lbSuccessfullyDeleted.Text = "Account Successfully Deleted";
            this.lbSuccessfullyDeleted.Visible = false;
            // 
            // lbIsNull
            // 
            this.lbIsNull.AutoSize = true;
            this.lbIsNull.BackColor = System.Drawing.Color.Transparent;
            this.lbIsNull.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsNull.ForeColor = System.Drawing.Color.Red;
            this.lbIsNull.Location = new System.Drawing.Point(573, 218);
            this.lbIsNull.Name = "lbIsNull";
            this.lbIsNull.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbIsNull.Size = new System.Drawing.Size(134, 20);
            this.lbIsNull.TabIndex = 59;
            this.lbIsNull.Text = "Must not be empty";
            this.lbIsNull.Visible = false;
            // 
            // FmManageAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbIsNull);
            this.Controls.Add(this.lbSuccessfullyDeleted);
            this.Controls.Add(this.lbSuccessfullyChanged);
            this.Controls.Add(this.lbInvalidIdEdit);
            this.Controls.Add(this.txChangeSecondName);
            this.Controls.Add(this.txChangePassword);
            this.Controls.Add(this.txChangeFirstName);
            this.Controls.Add(this.rbChangePassword);
            this.Controls.Add(this.rbChangeSecondName);
            this.Controls.Add(this.rbChangeFirstName);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.txIdEdit);
            this.Controls.Add(this.lbIdEdit);
            this.Controls.Add(this.rbChangeDetails);
            this.Controls.Add(this.lbInvalidIdDelete);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.lbIdDelete);
            this.Controls.Add(this.txIdDelete);
            this.Controls.Add(this.rbDeleteAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbInvalidEmail);
            this.Controls.Add(this.lbInvalidName);
            this.Controls.Add(this.lbInvalidId);
            this.Controls.Add(this.txFirstName);
            this.Controls.Add(this.txSecondName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.rbNameSearch);
            this.Controls.Add(this.rbIdSearch);
            this.Controls.Add(this.rbEmailSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbShowAll);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbSecondName);
            this.Name = "FmManageAccounts";
            this.Text = "FmManageAccounts";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEmailSearch;
        private System.Windows.Forms.RadioButton rbIdSearch;
        private System.Windows.Forms.RadioButton rbNameSearch;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.TextBox txFirstName;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txSecondName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbSecondName;
        private System.Windows.Forms.Label lbInvalidId;
        private System.Windows.Forms.Label lbInvalidName;
        private System.Windows.Forms.Label lbInvalidEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbDeleteAccount;
        private System.Windows.Forms.TextBox txIdDelete;
        private System.Windows.Forms.Label lbIdDelete;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label lbInvalidIdDelete;
        private System.Windows.Forms.RadioButton rbChangeDetails;
        private System.Windows.Forms.Label lbIdEdit;
        private System.Windows.Forms.TextBox txIdEdit;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.RadioButton rbChangeFirstName;
        private System.Windows.Forms.RadioButton rbChangeSecondName;
        private System.Windows.Forms.RadioButton rbChangePassword;
        private System.Windows.Forms.TextBox txChangeFirstName;
        private System.Windows.Forms.TextBox txChangePassword;
        private System.Windows.Forms.TextBox txChangeSecondName;
        private System.Windows.Forms.Label lbInvalidIdEdit;
        private System.Windows.Forms.Label lbSuccessfullyChanged;
        private System.Windows.Forms.Label lbSuccessfullyDeleted;
        private System.Windows.Forms.Label lbIsNull;
    }
}