
namespace FormsLibrary
{
    partial class FilterForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenreText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.YearText = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть автора:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.AuthorText.Location = new System.Drawing.Point(281, 34);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuthorText.Size = new System.Drawing.Size(195, 22);
            this.AuthorText.TabIndex = 1;
            this.AuthorText.TextChanged += new System.EventHandler(this.AuthorText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Жанр:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            "Фантастика"});
            this.GenreText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GenreText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.GenreText.Location = new System.Drawing.Point(281, 90);
            this.GenreText.Name = "GenreText";
            this.GenreText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GenreText.Size = new System.Drawing.Size(195, 22);
            this.GenreText.TabIndex = 3;
            this.GenreText.TextChanged += new System.EventHandler(this.GenreText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Назва книги:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(281, 154);
            this.NameText.Name = "NameText";
            this.NameText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NameText.Size = new System.Drawing.Size(195, 22);
            this.NameText.TabIndex = 5;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Рік видавництва:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // YearText
            // 
            this.YearText.Location = new System.Drawing.Point(281, 222);
            this.YearText.Name = "YearText";
            this.YearText.Size = new System.Drawing.Size(195, 22);
            this.YearText.TabIndex = 7;
            this.YearText.TextChanged += new System.EventHandler(this.YearText_TextChanged);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(281, 279);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(104, 44);
            this.Search.TabIndex = 8;
            this.Search.Text = "Пошук";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AuthorText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GenreText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YearText;
        private System.Windows.Forms.Button Search;
    }
}

