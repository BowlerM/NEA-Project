namespace NEA_Project
{
    partial class FmCustomerOffers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmCustomerOffers));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btExit = new System.Windows.Forms.Button();
            this.gbNotEligible = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalSpent = new System.Windows.Forms.Label();
            this.lbItems = new System.Windows.Forms.Label();
            this.lbEligible = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbNotEligibleByTime = new System.Windows.Forms.GroupBox();
            this.lbDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbNotEligible.SuspendLayout();
            this.gbNotEligibleByTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            this.btExit.TabIndex = 29;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // gbNotEligible
            // 
            this.gbNotEligible.BackColor = System.Drawing.Color.Transparent;
            this.gbNotEligible.Controls.Add(this.label2);
            this.gbNotEligible.Controls.Add(this.label5);
            this.gbNotEligible.Controls.Add(this.lbTotalSpent);
            this.gbNotEligible.Controls.Add(this.lbItems);
            this.gbNotEligible.Location = new System.Drawing.Point(12, 205);
            this.gbNotEligible.Name = "gbNotEligible";
            this.gbNotEligible.Size = new System.Drawing.Size(776, 180);
            this.gbNotEligible.TabIndex = 53;
            this.gbNotEligible.TabStop = false;
            this.gbNotEligible.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "To be eligible for an offer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 25);
            this.label5.TabIndex = 57;
            this.label5.Text = "Or";
            // 
            // lbTotalSpent
            // 
            this.lbTotalSpent.AutoSize = true;
            this.lbTotalSpent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbTotalSpent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalSpent.Location = new System.Drawing.Point(209, 102);
            this.lbTotalSpent.Name = "lbTotalSpent";
            this.lbTotalSpent.Size = new System.Drawing.Size(149, 25);
            this.lbTotalSpent.TabIndex = 56;
            this.lbTotalSpent.Text = "Total spent label";
            // 
            // lbItems
            // 
            this.lbItems.AutoSize = true;
            this.lbItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbItems.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItems.Location = new System.Drawing.Point(239, 16);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(103, 25);
            this.lbItems.TabIndex = 55;
            this.lbItems.Text = "Items label";
            // 
            // lbEligible
            // 
            this.lbEligible.AutoSize = true;
            this.lbEligible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbEligible.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEligible.Location = new System.Drawing.Point(6, 100);
            this.lbEligible.Name = "lbEligible";
            this.lbEligible.Size = new System.Drawing.Size(477, 32);
            this.lbEligible.TabIndex = 54;
            this.lbEligible.Text = "You are eligible for 25% off your next order";
            this.lbEligible.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 65);
            this.label1.TabIndex = 7;
            this.label1.Text = "Offers";
            // 
            // gbNotEligibleByTime
            // 
            this.gbNotEligibleByTime.BackColor = System.Drawing.Color.Transparent;
            this.gbNotEligibleByTime.Controls.Add(this.lbDateLabel);
            this.gbNotEligibleByTime.Location = new System.Drawing.Point(12, 135);
            this.gbNotEligibleByTime.Name = "gbNotEligibleByTime";
            this.gbNotEligibleByTime.Size = new System.Drawing.Size(776, 64);
            this.gbNotEligibleByTime.TabIndex = 59;
            this.gbNotEligibleByTime.TabStop = false;
            this.gbNotEligibleByTime.Visible = false;
            // 
            // lbDateLabel
            // 
            this.lbDateLabel.AutoSize = true;
            this.lbDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbDateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateLabel.Location = new System.Drawing.Point(239, 16);
            this.lbDateLabel.Name = "lbDateLabel";
            this.lbDateLabel.Size = new System.Drawing.Size(97, 25);
            this.lbDateLabel.TabIndex = 55;
            this.lbDateLabel.Text = "Date label";
            // 
            // FmCustomerOffers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbNotEligibleByTime);
            this.Controls.Add(this.lbEligible);
            this.Controls.Add(this.gbNotEligible);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FmCustomerOffers";
            this.Text = "FmCustomerOffers";
            this.Load += new System.EventHandler(this.FmCustomerOffers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbNotEligible.ResumeLayout(false);
            this.gbNotEligible.PerformLayout();
            this.gbNotEligibleByTime.ResumeLayout(false);
            this.gbNotEligibleByTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.GroupBox gbNotEligible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotalSpent;
        private System.Windows.Forms.Label lbItems;
        private System.Windows.Forms.Label lbEligible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbNotEligibleByTime;
        private System.Windows.Forms.Label lbDateLabel;
    }
}