namespace BookCrossing.Forms
{
    partial class BookList
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
            this.ChangeFiltersButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.BookListView = new System.Windows.Forms.ListView();
            this.NameBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublicationYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AvaibleQuantityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeFiltersButton
            // 
            this.ChangeFiltersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ChangeFiltersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeFiltersButton.Location = new System.Drawing.Point(582, 398);
            this.ChangeFiltersButton.Name = "ChangeFiltersButton";
            this.ChangeFiltersButton.Size = new System.Drawing.Size(206, 40);
            this.ChangeFiltersButton.TabIndex = 7;
            this.ChangeFiltersButton.Text = "Змінити фільтри";
            this.ChangeFiltersButton.UseVisualStyleBackColor = false;
            this.ChangeFiltersButton.Click += new System.EventHandler(this.ChangeFiltersButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectButton.Location = new System.Drawing.Point(12, 398);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(206, 40);
            this.SelectButton.TabIndex = 6;
            this.SelectButton.Text = "Додати до кошика";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // BookListView
            // 
            this.BookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameBook,
            this.Author,
            this.PublicationYear,
            this.Genre});
            this.BookListView.FullRowSelect = true;
            this.BookListView.GridLines = true;
            this.BookListView.HideSelection = false;
            this.BookListView.Location = new System.Drawing.Point(12, 12);
            this.BookListView.Name = "BookListView";
            this.BookListView.Size = new System.Drawing.Size(776, 339);
            this.BookListView.TabIndex = 5;
            this.BookListView.UseCompatibleStateImageBehavior = false;
            this.BookListView.View = System.Windows.Forms.View.Details;
            // 
            // NameBook
            // 
            this.NameBook.Text = "Назва";
            this.NameBook.Width = 125;
            // 
            // Author
            // 
            this.Author.Text = "Автор";
            this.Author.Width = 104;
            // 
            // PublicationYear
            // 
            this.PublicationYear.Text = "Рік публікації";
            this.PublicationYear.Width = 120;
            // 
            // Genre
            // 
            this.Genre.Text = "Жанр";
            this.Genre.Width = 133;
            // 
            // AvaibleQuantityLabel
            // 
            this.AvaibleQuantityLabel.AutoSize = true;
            this.AvaibleQuantityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AvaibleQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvaibleQuantityLabel.Location = new System.Drawing.Point(12, 364);
            this.AvaibleQuantityLabel.Name = "AvaibleQuantityLabel";
            this.AvaibleQuantityLabel.Size = new System.Drawing.Size(218, 20);
            this.AvaibleQuantityLabel.TabIndex = 9;
            this.AvaibleQuantityLabel.Text = "Доступно взяти книжок: ";
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookCrossing.Properties.Resources._1614800883_88_p_fon_dlya_prezentatsii_knigi_115;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AvaibleQuantityLabel);
            this.Controls.Add(this.ChangeFiltersButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.BookListView);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "BookList";
            this.Text = "BookList";
            this.Load += new System.EventHandler(this.BookList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChangeFiltersButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.ListView BookListView;
        private System.Windows.Forms.ColumnHeader NameBook;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader PublicationYear;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.Label AvaibleQuantityLabel;
    }
}