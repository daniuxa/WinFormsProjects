namespace BookCrossing.Forms
{
    partial class FilterForm
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
            this.Search = new System.Windows.Forms.Button();
            this.YearText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenreText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(324, 318);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(135, 70);
            this.Search.TabIndex = 31;
            this.Search.Text = "Пошук";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // YearText
            // 
            this.YearText.Location = new System.Drawing.Point(417, 241);
            this.YearText.Name = "YearText";
            this.YearText.Size = new System.Drawing.Size(195, 22);
            this.YearText.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(116, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Рік видавництва:";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(417, 176);
            this.NameText.Name = "NameText";
            this.NameText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NameText.Size = new System.Drawing.Size(195, 22);
            this.NameText.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(116, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Назва книги:";
            // 
            // GenreText
            // 
            this.GenreText.AutoCompleteCustomSource.AddRange(new string[] {
            "Технічна література",
            "Бізнес",
            "Біографії",
            "Детектив",
            "Драма",
            "Історичний роман",
            "Класика",
            "Мелодрама",
            "Науково-популярна",
            "Поезія",
            "Пригодницький роман",
            "Психологія",
            "Сучасна проза",
            "Трилер",
            "Фантастика",
            "Роман"});
            this.GenreText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GenreText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.GenreText.Location = new System.Drawing.Point(417, 59);
            this.GenreText.Name = "GenreText";
            this.GenreText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GenreText.Size = new System.Drawing.Size(195, 22);
            this.GenreText.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(116, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Жанр:";
            // 
            // AuthorText
            // 
            this.AuthorText.AutoCompleteCustomSource.AddRange(new string[] {
            "Стівен Кінг",
            "Федор Достоєвський",
            "Михайло Булгаков",
            "Джоан Ролінґ",
            "Джеймс Паттерсон",
            "Джордж Мартін",
            "Еріка Леонард Джеймс",
            "Майкл Льюїс",
            "Метью Квік",
            "Джон Ґрін",
            "Ніл Ґейман",
            "Денніс Ліхейн",
            "Гілліан Флінн",
            "Ернест Клайн",
            "Девід Гранн",
            "Діана Геблдон",
            "Ю Несбе",
            "Маргарет Етвуд",
            "Бен Мезріч",
            "Ліана Моріарті",
            "Пола Гоукінз",
            "Джеффрі Тубін",
            "Грем Мур",
            "Емма Доног’ю",
            "Лорен Олівер",
            "Патрік Несс",
            "Марія Семпл",
            "Микола Гоголь",
            "Генрік Ібсен",
            "Франц Кафка",
            "Лев Толстий",
            "Вільям Шекспір"});
            this.AuthorText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AuthorText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AuthorText.Location = new System.Drawing.Point(417, 111);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuthorText.Size = new System.Drawing.Size(195, 22);
            this.AuthorText.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Введіть автора:";
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookCrossing.Properties.Resources._1614800883_88_p_fon_dlya_prezentatsii_knigi_115;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.YearText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenreText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.label1);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox YearText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GenreText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AuthorText;
        private System.Windows.Forms.Label label1;
    }
}