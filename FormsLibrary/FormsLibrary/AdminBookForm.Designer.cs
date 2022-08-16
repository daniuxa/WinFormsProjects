
namespace FormsLibrary
{
    partial class AdminBookForm
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
            this.CartListView = new System.Windows.Forms.ListView();
            this.NameBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublicationYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.DateTakenBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateReutnBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CartListView
            // 
            this.CartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameBook,
            this.Author,
            this.PublicationYear,
            this.Genre,
            this.DateTakenBook,
            this.DateReutnBook});
            this.CartListView.FullRowSelect = true;
            this.CartListView.GridLines = true;
            this.CartListView.HideSelection = false;
            this.CartListView.Location = new System.Drawing.Point(12, 12);
            this.CartListView.Name = "CartListView";
            this.CartListView.Size = new System.Drawing.Size(776, 371);
            this.CartListView.TabIndex = 7;
            this.CartListView.UseCompatibleStateImageBehavior = false;
            this.CartListView.View = System.Windows.Forms.View.Details;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateTakenBook
            // 
            this.DateTakenBook.Text = "Книга взята";
            // 
            // DateReutnBook
            // 
            this.DateReutnBook.Text = "Потрібно повернути до";
            // 
            // AdminBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CartListView);
            this.Name = "AdminBookForm";
            this.Text = "AdminBookForm";
            this.Load += new System.EventHandler(this.AdminBookForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CartListView;
        private System.Windows.Forms.ColumnHeader NameBook;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader PublicationYear;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader DateTakenBook;
        private System.Windows.Forms.ColumnHeader DateReutnBook;
    }
}