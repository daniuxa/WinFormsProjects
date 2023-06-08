namespace BookCrossing.Forms
{
    partial class AccountForm
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
            this.AccountLabel = new System.Windows.Forms.Label();
            this.CountGivenBooksLabel = new System.Windows.Forms.Label();
            this.CountTakenBooksLabel = new System.Windows.Forms.Label();
            this.TakeBooksButton = new System.Windows.Forms.Button();
            this.GiveBooksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.BackColor = System.Drawing.Color.DarkKhaki;
            this.AccountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountLabel.Location = new System.Drawing.Point(304, 14);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(126, 36);
            this.AccountLabel.TabIndex = 3;
            this.AccountLabel.Text = "Акаунт: ";
            // 
            // CountGivenBooksLabel
            // 
            this.CountGivenBooksLabel.AutoSize = true;
            this.CountGivenBooksLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CountGivenBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountGivenBooksLabel.Location = new System.Drawing.Point(78, 109);
            this.CountGivenBooksLabel.Name = "CountGivenBooksLabel";
            this.CountGivenBooksLabel.Size = new System.Drawing.Size(286, 29);
            this.CountGivenBooksLabel.TabIndex = 45;
            this.CountGivenBooksLabel.Text = "Кількість відданих книг: ";
            // 
            // CountTakenBooksLabel
            // 
            this.CountTakenBooksLabel.AutoSize = true;
            this.CountTakenBooksLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CountTakenBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountTakenBooksLabel.Location = new System.Drawing.Point(78, 174);
            this.CountTakenBooksLabel.Name = "CountTakenBooksLabel";
            this.CountTakenBooksLabel.Size = new System.Drawing.Size(263, 29);
            this.CountTakenBooksLabel.TabIndex = 46;
            this.CountTakenBooksLabel.Text = "Кількість взятих книг: ";
            // 
            // TakeBooksButton
            // 
            this.TakeBooksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TakeBooksButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeBooksButton.Location = new System.Drawing.Point(135, 299);
            this.TakeBooksButton.Name = "TakeBooksButton";
            this.TakeBooksButton.Size = new System.Drawing.Size(200, 75);
            this.TakeBooksButton.TabIndex = 47;
            this.TakeBooksButton.Text = "Взяти книги";
            this.TakeBooksButton.UseVisualStyleBackColor = false;
            this.TakeBooksButton.Click += new System.EventHandler(this.TakeBooksButton_Click);
            // 
            // GiveBooksButton
            // 
            this.GiveBooksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GiveBooksButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GiveBooksButton.Location = new System.Drawing.Point(471, 299);
            this.GiveBooksButton.Name = "GiveBooksButton";
            this.GiveBooksButton.Size = new System.Drawing.Size(200, 75);
            this.GiveBooksButton.TabIndex = 48;
            this.GiveBooksButton.Text = "Віддати книги";
            this.GiveBooksButton.UseVisualStyleBackColor = false;
            this.GiveBooksButton.Click += new System.EventHandler(this.GiveBooksButton_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookCrossing.Properties.Resources._1614800883_88_p_fon_dlya_prezentatsii_knigi_115;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 484);
            this.Controls.Add(this.GiveBooksButton);
            this.Controls.Add(this.TakeBooksButton);
            this.Controls.Add(this.CountTakenBooksLabel);
            this.Controls.Add(this.CountGivenBooksLabel);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.label1);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.Label CountGivenBooksLabel;
        private System.Windows.Forms.Label CountTakenBooksLabel;
        private System.Windows.Forms.Button TakeBooksButton;
        private System.Windows.Forms.Button GiveBooksButton;
    }
}