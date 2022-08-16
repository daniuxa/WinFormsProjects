
namespace BookStore
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
            this.BookListView = new System.Windows.Forms.ListView();
            this.NameBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublicationYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectButton = new System.Windows.Forms.Button();
            this.ChangeFiltersButton = new System.Windows.Forms.Button();
            this.ShowCartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookListView
            // 
            this.BookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameBook,
            this.Author,
            this.PublicationYear,
            this.Price,
            this.Genre});
            this.BookListView.FullRowSelect = true;
            this.BookListView.GridLines = true;
            this.BookListView.HideSelection = false;
            this.BookListView.Location = new System.Drawing.Point(12, 12);
            this.BookListView.Name = "BookListView";
            this.BookListView.Size = new System.Drawing.Size(776, 377);
            this.BookListView.TabIndex = 0;
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
            // Price
            // 
            this.Price.Text = "Ціна";
            this.Price.Width = 100;
            // 
            // Genre
            // 
            this.Genre.Text = "Жанр";
            this.Genre.Width = 133;
            // 
            // SelectButton
            // 
            this.SelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectButton.Location = new System.Drawing.Point(12, 398);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(206, 40);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "Додати до кошика";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ChangeFiltersButton
            // 
            this.ChangeFiltersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeFiltersButton.Location = new System.Drawing.Point(296, 398);
            this.ChangeFiltersButton.Name = "ChangeFiltersButton";
            this.ChangeFiltersButton.Size = new System.Drawing.Size(206, 40);
            this.ChangeFiltersButton.TabIndex = 3;
            this.ChangeFiltersButton.Text = "Змінити фільтри";
            this.ChangeFiltersButton.UseVisualStyleBackColor = true;
            this.ChangeFiltersButton.Click += new System.EventHandler(this.ChangeFiltersButton_Click);
            // 
            // ShowCartButton
            // 
            this.ShowCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCartButton.Location = new System.Drawing.Point(582, 398);
            this.ShowCartButton.Name = "ShowCartButton";
            this.ShowCartButton.Size = new System.Drawing.Size(206, 40);
            this.ShowCartButton.TabIndex = 4;
            this.ShowCartButton.Text = "Переглянути кошик";
            this.ShowCartButton.UseVisualStyleBackColor = true;
            this.ShowCartButton.Click += new System.EventHandler(this.ShowCartButton_Click);
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowCartButton);
            this.Controls.Add(this.ChangeFiltersButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.BookListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookList";
            this.Text = "BookList";
            this.Load += new System.EventHandler(this.BookList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView BookListView;
        private System.Windows.Forms.ColumnHeader NameBook;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader PublicationYear;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button ChangeFiltersButton;
        private System.Windows.Forms.Button ShowCartButton;
    }
}