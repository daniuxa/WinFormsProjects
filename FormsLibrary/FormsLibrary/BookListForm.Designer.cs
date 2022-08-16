
namespace FormsLibrary
{
    partial class BookListForm
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
            this.AuthorBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublicationYearBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenreBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ViewCartButton = new System.Windows.Forms.Button();
            this.ChangeFiltreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookListView
            // 
            this.BookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameBook,
            this.AuthorBook,
            this.PublicationYearBook,
            this.GenreBook});
            this.BookListView.FullRowSelect = true;
            this.BookListView.GridLines = true;
            this.BookListView.HideSelection = false;
            this.BookListView.Location = new System.Drawing.Point(12, 12);
            this.BookListView.Name = "BookListView";
            this.BookListView.Size = new System.Drawing.Size(805, 406);
            this.BookListView.TabIndex = 0;
            this.BookListView.UseCompatibleStateImageBehavior = false;
            this.BookListView.View = System.Windows.Forms.View.Details;
            // 
            // NameBook
            // 
            this.NameBook.Text = "Назва";
            this.NameBook.Width = 116;
            // 
            // AuthorBook
            // 
            this.AuthorBook.Text = "Автор";
            this.AuthorBook.Width = 130;
            // 
            // PublicationYearBook
            // 
            this.PublicationYearBook.Text = "Рік видавництва";
            this.PublicationYearBook.Width = 168;
            // 
            // GenreBook
            // 
            this.GenreBook.Text = "Жанр";
            this.GenreBook.Width = 162;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToCartButton.Location = new System.Drawing.Point(12, 427);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(192, 36);
            this.AddToCartButton.TabIndex = 1;
            this.AddToCartButton.Text = "Додати до кошика";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // ViewCartButton
            // 
            this.ViewCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewCartButton.Location = new System.Drawing.Point(615, 427);
            this.ViewCartButton.Name = "ViewCartButton";
            this.ViewCartButton.Size = new System.Drawing.Size(202, 36);
            this.ViewCartButton.TabIndex = 2;
            this.ViewCartButton.Text = "Переглянути кошика";
            this.ViewCartButton.UseVisualStyleBackColor = true;
            this.ViewCartButton.Click += new System.EventHandler(this.ViewCartButton_Click);
            // 
            // ChangeFiltreButton
            // 
            this.ChangeFiltreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeFiltreButton.Location = new System.Drawing.Point(312, 427);
            this.ChangeFiltreButton.Name = "ChangeFiltreButton";
            this.ChangeFiltreButton.Size = new System.Drawing.Size(192, 36);
            this.ChangeFiltreButton.TabIndex = 3;
            this.ChangeFiltreButton.Text = "Змінити фільтри";
            this.ChangeFiltreButton.UseVisualStyleBackColor = true;
            this.ChangeFiltreButton.Click += new System.EventHandler(this.ChangeFiltreButton_Click);
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 475);
            this.Controls.Add(this.ChangeFiltreButton);
            this.Controls.Add(this.ViewCartButton);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.BookListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookListForm";
            this.Text = "BookListForm";
            this.Load += new System.EventHandler(this.BookListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView BookListView;
        private System.Windows.Forms.ColumnHeader NameBook;
        private System.Windows.Forms.ColumnHeader AuthorBook;
        private System.Windows.Forms.ColumnHeader PublicationYearBook;
        private System.Windows.Forms.ColumnHeader GenreBook;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Button ViewCartButton;
        private System.Windows.Forms.Button ChangeFiltreButton;
    }
}