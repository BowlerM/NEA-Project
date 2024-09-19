namespace NEA_Project
{
    partial class FmManageTransactions
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
            this.btExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.txSearchId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbToday = new System.Windows.Forms.RadioButton();
            this.rbThisWeek = new System.Windows.Forms.RadioButton();
            this.rbThisMonth = new System.Windows.Forms.RadioButton();
            this.rbThisYear = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btClearFilter = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txTransId = new System.Windows.Forms.TextBox();
            this.lbInvalidTransId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
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
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(210, 47);
            this.label2.TabIndex = 12;
            this.label2.Text = "Transactions";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 74);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(440, 364);
            this.grid.TabIndex = 13;
            // 
            // txSearchId
            // 
            this.txSearchId.Location = new System.Drawing.Point(564, 123);
            this.txSearchId.Name = "txSearchId";
            this.txSearchId.Size = new System.Drawing.Size(100, 20);
            this.txSearchId.TabIndex = 24;
            this.txSearchId.TextChanged += new System.EventHandler(this.txSearchId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(458, 122);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Customer ID:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Black;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(12, 34);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTotal.Size = new System.Drawing.Size(80, 37);
            this.lbTotal.TabIndex = 26;
            this.lbTotal.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(458, 69);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(252, 37);
            this.label3.TabIndex = 27;
            this.label3.Text = "Search by Customer";
            // 
            // rbToday
            // 
            this.rbToday.AutoSize = true;
            this.rbToday.Location = new System.Drawing.Point(460, 220);
            this.rbToday.Name = "rbToday";
            this.rbToday.Size = new System.Drawing.Size(55, 17);
            this.rbToday.TabIndex = 32;
            this.rbToday.TabStop = true;
            this.rbToday.Text = "Today";
            this.rbToday.UseVisualStyleBackColor = true;
            this.rbToday.CheckedChanged += new System.EventHandler(this.rbToday_CheckedChanged);
            // 
            // rbThisWeek
            // 
            this.rbThisWeek.AutoSize = true;
            this.rbThisWeek.Location = new System.Drawing.Point(521, 220);
            this.rbThisWeek.Name = "rbThisWeek";
            this.rbThisWeek.Size = new System.Drawing.Size(77, 17);
            this.rbThisWeek.TabIndex = 33;
            this.rbThisWeek.TabStop = true;
            this.rbThisWeek.Text = "This Week";
            this.rbThisWeek.UseVisualStyleBackColor = true;
            this.rbThisWeek.CheckedChanged += new System.EventHandler(this.rbThisWeek_CheckedChanged);
            // 
            // rbThisMonth
            // 
            this.rbThisMonth.AutoSize = true;
            this.rbThisMonth.Location = new System.Drawing.Point(604, 220);
            this.rbThisMonth.Name = "rbThisMonth";
            this.rbThisMonth.Size = new System.Drawing.Size(78, 17);
            this.rbThisMonth.TabIndex = 34;
            this.rbThisMonth.TabStop = true;
            this.rbThisMonth.Text = "This Month";
            this.rbThisMonth.UseVisualStyleBackColor = true;
            this.rbThisMonth.CheckedChanged += new System.EventHandler(this.rbThisMonth_CheckedChanged);
            // 
            // rbThisYear
            // 
            this.rbThisYear.AutoSize = true;
            this.rbThisYear.Location = new System.Drawing.Point(688, 220);
            this.rbThisYear.Name = "rbThisYear";
            this.rbThisYear.Size = new System.Drawing.Size(70, 17);
            this.rbThisYear.TabIndex = 35;
            this.rbThisYear.TabStop = true;
            this.rbThisYear.Text = "This Year";
            this.rbThisYear.UseVisualStyleBackColor = true;
            this.rbThisYear.CheckedChanged += new System.EventHandler(this.rbThisYear_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(458, 165);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(194, 37);
            this.label8.TabIndex = 41;
            this.label8.Text = "Search by Date";
            // 
            // btClearFilter
            // 
            this.btClearFilter.BackColor = System.Drawing.Color.DimGray;
            this.btClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClearFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClearFilter.Location = new System.Drawing.Point(458, 262);
            this.btClearFilter.Name = "btClearFilter";
            this.btClearFilter.Size = new System.Drawing.Size(99, 23);
            this.btClearFilter.TabIndex = 42;
            this.btClearFilter.Text = "Clear Filter";
            this.btClearFilter.UseVisualStyleBackColor = false;
            this.btClearFilter.Visible = false;
            this.btClearFilter.Click += new System.EventHandler(this.btClearFilter_Click);
            // 
            // btShow
            // 
            this.btShow.BackColor = System.Drawing.Color.LightGreen;
            this.btShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btShow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow.Location = new System.Drawing.Point(458, 262);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(99, 23);
            this.btShow.TabIndex = 43;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = false;
            this.btShow.Visible = false;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.Red;
            this.btRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRemove.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(460, 391);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(112, 34);
            this.btRemove.TabIndex = 44;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Visible = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(458, 297);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(112, 37);
            this.label4.TabIndex = 28;
            this.label4.Text = "Remove";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(461, 353);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Transaction ID:";
            // 
            // txTransId
            // 
            this.txTransId.Location = new System.Drawing.Point(578, 354);
            this.txTransId.Name = "txTransId";
            this.txTransId.Size = new System.Drawing.Size(100, 20);
            this.txTransId.TabIndex = 31;
            this.txTransId.Click += new System.EventHandler(this.txTransId_Click);
            this.txTransId.TextChanged += new System.EventHandler(this.txTransId_TextChanged);
            // 
            // lbInvalidTransId
            // 
            this.lbInvalidTransId.AutoSize = true;
            this.lbInvalidTransId.BackColor = System.Drawing.Color.Transparent;
            this.lbInvalidTransId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalidTransId.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidTransId.Location = new System.Drawing.Point(684, 354);
            this.lbInvalidTransId.Name = "lbInvalidTransId";
            this.lbInvalidTransId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInvalidTransId.Size = new System.Drawing.Size(72, 20);
            this.lbInvalidTransId.TabIndex = 56;
            this.lbInvalidTransId.Text = "‌Invalid ID";
            this.lbInvalidTransId.Visible = false;
            // 
            // FmManageTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbInvalidTransId);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.btClearFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbThisYear);
            this.Controls.Add(this.rbThisMonth);
            this.Controls.Add(this.rbThisWeek);
            this.Controls.Add(this.rbToday);
            this.Controls.Add(this.txTransId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txSearchId);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btExit);
            this.Name = "FmManageTransactions";
            this.Load += new System.EventHandler(this.FmManageTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox txSearchId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbToday;
        private System.Windows.Forms.RadioButton rbThisWeek;
        private System.Windows.Forms.RadioButton rbThisMonth;
        private System.Windows.Forms.RadioButton rbThisYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btClearFilter;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txTransId;
        private System.Windows.Forms.Label lbInvalidTransId;
    }
}