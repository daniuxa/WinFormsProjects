namespace BookCrossing.Forms
{
    partial class GiveBookForm
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
            this.CountGivenBooksLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AuthorNameTextBox = new System.Windows.Forms.TextBox();
            this.YearPublTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.GiveBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CountGivenBooksLabel
            // 
            this.CountGivenBooksLabel.AutoSize = true;
            this.CountGivenBooksLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CountGivenBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountGivenBooksLabel.Location = new System.Drawing.Point(28, 66);
            this.CountGivenBooksLabel.Name = "CountGivenBooksLabel";
            this.CountGivenBooksLabel.Size = new System.Drawing.Size(157, 29);
            this.CountGivenBooksLabel.TabIndex = 46;
            this.CountGivenBooksLabel.Text = "Назва книги:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "Автор:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ім\'я:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(408, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 49;
            this.label3.Text = "Прізвище:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 29);
            this.label4.TabIndex = 50;
            this.label4.Text = "Рік публікації:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 51;
            this.label5.Text = "Жанр:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NameTextBox.Location = new System.Drawing.Point(222, 73);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(157, 22);
            this.NameTextBox.TabIndex = 52;
            // 
            // AuthorNameTextBox
            // 
            this.AuthorNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AuthorNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AuthorNameTextBox.Location = new System.Drawing.Point(222, 167);
            this.AuthorNameTextBox.Name = "AuthorNameTextBox";
            this.AuthorNameTextBox.Size = new System.Drawing.Size(157, 22);
            this.AuthorNameTextBox.TabIndex = 54;
            // 
            // YearPublTextBox
            // 
            this.YearPublTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.YearPublTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.YearPublTextBox.Location = new System.Drawing.Point(222, 218);
            this.YearPublTextBox.Name = "YearPublTextBox";
            this.YearPublTextBox.Size = new System.Drawing.Size(157, 22);
            this.YearPublTextBox.TabIndex = 55;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GenreTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.GenreTextBox.Location = new System.Drawing.Point(222, 269);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(157, 22);
            this.GenreTextBox.TabIndex = 56;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SurnameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SurnameTextBox.Location = new System.Drawing.Point(560, 167);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(157, 22);
            this.SurnameTextBox.TabIndex = 57;
            // 
            // GiveBookButton
            // 
            this.GiveBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GiveBookButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GiveBookButton.Location = new System.Drawing.Point(303, 330);
            this.GiveBookButton.Name = "GiveBookButton";
            this.GiveBookButton.Size = new System.Drawing.Size(200, 75);
            this.GiveBookButton.TabIndex = 58;
            this.GiveBookButton.Text = "Віддати книгу";
            this.GiveBookButton.UseVisualStyleBackColor = false;
            this.GiveBookButton.Click += new System.EventHandler(this.GiveBookButton_Click);
            // 
            // GiveBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookCrossing.Properties.Resources._1614800883_88_p_fon_dlya_prezentatsii_knigi_115;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GiveBookButton);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.YearPublTextBox);
            this.Controls.Add(this.AuthorNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountGivenBooksLabel);
            this.Name = "GiveBookForm";
            this.Text = "GiveBookForm";
            this.Load += new System.EventHandler(this.GiveBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CountGivenBooksLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AuthorNameTextBox;
        private System.Windows.Forms.TextBox YearPublTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Button GiveBookButton;
    }
}