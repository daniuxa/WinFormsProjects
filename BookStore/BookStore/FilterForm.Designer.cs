
namespace BookStore
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceTo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(331, 343);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(104, 44);
            this.Search.TabIndex = 17;
            this.Search.Text = "Пошук";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // YearText
            // 
            this.YearText.Location = new System.Drawing.Point(365, 232);
            this.YearText.Name = "YearText";
            this.YearText.Size = new System.Drawing.Size(195, 22);
            this.YearText.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Рік видавництва:";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(365, 167);
            this.NameText.Name = "NameText";
            this.NameText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NameText.Size = new System.Drawing.Size(195, 22);
            this.NameText.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(64, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 13;
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
            this.GenreText.Location = new System.Drawing.Point(365, 50);
            this.GenreText.Name = "GenreText";
            this.GenreText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GenreText.Size = new System.Drawing.Size(195, 22);
            this.GenreText.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(64, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 11;
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
            this.AuthorText.Location = new System.Drawing.Point(365, 102);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuthorText.Size = new System.Drawing.Size(195, 22);
            this.AuthorText.TabIndex = 10;
            this.AuthorText.TextChanged += new System.EventHandler(this.AuthorText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введіть автора:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(64, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Виберіть діапазон ціни:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(313, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Від:";
            // 
            // PriceFrom
            // 
            this.PriceFrom.Location = new System.Drawing.Point(365, 291);
            this.PriceFrom.Name = "PriceFrom";
            this.PriceFrom.Size = new System.Drawing.Size(100, 22);
            this.PriceFrom.TabIndex = 20;
            this.PriceFrom.TextChanged += new System.EventHandler(this.PriceFrom_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(480, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "До:";
            // 
            // PriceTo
            // 
            this.PriceTo.Location = new System.Drawing.Point(532, 295);
            this.PriceTo.Name = "PriceTo";
            this.PriceTo.Size = new System.Drawing.Size(100, 22);
            this.PriceTo.TabIndex = 22;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(762, 412);
            this.Controls.Add(this.PriceTo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PriceFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.YearText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenreText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PriceFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PriceTo;
    }
}