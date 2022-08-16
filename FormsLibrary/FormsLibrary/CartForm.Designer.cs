
namespace FormsLibrary
{
    partial class CartForm
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
            this.NameBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublicationYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CartListView = new System.Windows.Forms.ListView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ContinuePurchaseButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // CartListView
            // 
            this.CartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameBook,
            this.Author,
            this.PublicationYear,
            this.Genre});
            this.CartListView.FullRowSelect = true;
            this.CartListView.GridLines = true;
            this.CartListView.HideSelection = false;
            this.CartListView.Location = new System.Drawing.Point(12, 12);
            this.CartListView.Name = "CartListView";
            this.CartListView.Size = new System.Drawing.Size(776, 345);
            this.CartListView.TabIndex = 6;
            this.CartListView.UseCompatibleStateImageBehavior = false;
            this.CartListView.View = System.Windows.Forms.View.Details;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(12, 395);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(113, 43);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ContinuePurchaseButton
            // 
            this.ContinuePurchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContinuePurchaseButton.Location = new System.Drawing.Point(294, 395);
            this.ContinuePurchaseButton.Name = "ContinuePurchaseButton";
            this.ContinuePurchaseButton.Size = new System.Drawing.Size(215, 43);
            this.ContinuePurchaseButton.TabIndex = 8;
            this.ContinuePurchaseButton.Text = "Продовжити покупки";
            this.ContinuePurchaseButton.UseVisualStyleBackColor = true;
            this.ContinuePurchaseButton.Click += new System.EventHandler(this.ContinuePurchaseButton_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyButton.Location = new System.Drawing.Point(675, 395);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(113, 43);
            this.BuyButton.TabIndex = 9;
            this.BuyButton.Text = "Придбати";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.ContinuePurchaseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CartListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader NameBook;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader PublicationYear;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ListView CartListView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ContinuePurchaseButton;
        private System.Windows.Forms.Button BuyButton;
    }
}