
namespace BookStore
{
    partial class SuccessfulOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.CartListView = new System.Windows.Forms.ListView();
            this.NameBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublicationYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SumLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дякуємо за покупку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(298, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ваше замовлення";
            // 
            // CartListView
            // 
            this.CartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameBook,
            this.Author,
            this.PublicationYear,
            this.Price,
            this.Genre});
            this.CartListView.FullRowSelect = true;
            this.CartListView.GridLines = true;
            this.CartListView.HideSelection = false;
            this.CartListView.Location = new System.Drawing.Point(12, 89);
            this.CartListView.Name = "CartListView";
            this.CartListView.Size = new System.Drawing.Size(776, 184);
            this.CartListView.TabIndex = 2;
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
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLabel.Location = new System.Drawing.Point(12, 285);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(121, 20);
            this.SumLabel.TabIndex = 6;
            this.SumLabel.Text = "Сума заказу: ";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(336, 337);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(88, 38);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SuccessfulOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.CartListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuccessfulOrder";
            this.Text = "SuccessfulOrder";
            this.Load += new System.EventHandler(this.SuccessfulOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView CartListView;
        private System.Windows.Forms.ColumnHeader NameBook;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader PublicationYear;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Button OkButton;
    }
}