using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    delegate void ErrorMsg();
    public partial class FilterForm : Form
    {
        public Cart cart = null;
        private Book bookTo;
        private Book bookFrom;
        private List<Person> Authors;
        private List<string> Genres;
        public FilterForm(Cart cart)
        {
            InitializeComponent();
            this.cart = cart;
        }

        private void YearError()
        {
            MessageBox.Show("Неправильно введено рік", "Помилка вводу року", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void PriceError()
        {
            MessageBox.Show("Неправильно введено ціну", "Помилка вводу року", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private ErrorMsg CheckError()
        {
            ErrorMsg msg = null;
            int FromPrice = 0;
            int ToPrice = 0;
            bool check = int.TryParse(YearText.Text, out int Year);
            string genre;
            Person author = null;
            string Author = "";
            string[] AuthorArr;
            string NameAuthor = "";
            string SurnameAuthor = "";
            if (AuthorText.Text != "")
            {
                Author = String.Join(" ", AuthorText.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));
                AuthorArr = Author.Split(' ');
                if (AuthorArr.Length == 2)
                {
                    NameAuthor = AuthorArr[0];
                    SurnameAuthor = AuthorArr[1];
                }
                else
                {
                    NameAuthor = Author;
                }
                author = new Person(NameAuthor, SurnameAuthor);
            }
            if (YearText.Text == "")
            {
                Year = 0;
            }
            if (GenreText.Text == "")
                genre = "По замовченню";
            else
                genre = GenreText.Text;
            if (Int32.TryParse(PriceFrom.Text, out int result01) == true && Int32.TryParse(PriceTo.Text, out int result02) == true)
            {
                if (result01 == 0 || result02 == 0)
                {
                    /*MessageBox.Show("Неправильно введено рік");*/
                    msg = YearError;
                    return msg;
                }
            }

            if (PriceFrom.Text == "" && PriceTo.Text == "")
            {
                FromPrice = 0;
                ToPrice = 0;
            }
            else if (PriceFrom.Text == "" && PriceTo.Text != "" && Int32.TryParse(PriceTo.Text, out int result1) == true)
            {
                FromPrice = 0;
                ToPrice = result1;
            }
            else if (PriceFrom.Text != "" && PriceTo.Text == "" && Int32.TryParse(PriceFrom.Text, out int result2) == true)
            {
                FromPrice = result2;
                ToPrice = 0;
            }
            else if (PriceFrom.Text != "" && PriceTo.Text != "" && Int32.TryParse(PriceFrom.Text, out int result3) == true && Int32.TryParse(PriceTo.Text, out int result4) == true && result3 <= result4)
            {
                FromPrice = result3;
                ToPrice = result4;
            }
            else
            {
                /*MessageBox.Show("Неправильно введена ціна");*/
                msg = PriceError;
                return msg;
            }

            if (YearText.Text != "" && (!check || Year > DateTime.Now.Year || Year < 1))
            {
                msg = YearError;
                return msg;
            }
            else
            {
                try
                {
                    bookTo = new Book(NameText.Text, author, Year, ToPrice, genre);
                }
                catch (GenreException ex)
                {
                    msg = () =>
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення:{ex.Value}"); //лямбда вираз
                    return msg;
                }
                catch (PublicationYearException ex)
                {
                    msg = () =>
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення:{ex.Value}");
                    return msg;
                }
                try
                {
                    bookFrom = new Book(NameText.Text, author, Year, FromPrice, genre);
                }
                catch (GenreException ex)
                {
                    msg = () =>
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення:{ex.Value}");
                    return msg;
                }
                catch (PublicationYearException ex)
                {
                    msg = () =>
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення:{ex.Value}");
                    return msg;
                }
            }
            return msg;
        }

        private void Search_Click(object sender, EventArgs e)
        {

            ErrorMsg msg;                   //Обьект делегаты
            msg = CheckError();             //присваиваем функцию
            if (msg != null) //msg?.Invoke();//Проверка на то присвоилась функция делегате
            {
                msg();                       //Вызов делегаты
            }
            else
            {
                this.Visible = false;
                BookList form = new BookList(bookTo, bookFrom, cart);
                form.ShowDialog();
            }
            
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = GenreText;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\BookStore\BookStore\Lists\Author.bin", FileMode.OpenOrCreate))
            {
                Authors = (List<Person>)formatter.Deserialize(fs);
            }
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\BookStore\BookStore\Lists\Genre.bin", FileMode.OpenOrCreate))
            {
                Genres = (List<string>)formatter.Deserialize(fs);
            }
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            foreach (var author in Authors)
            {
                    source.Add(author.Name + " " + author.Surname);
            }
            AuthorText.AutoCompleteCustomSource = source;
            AutoCompleteStringCollection source1 = new AutoCompleteStringCollection();
            foreach (var genre in Genres)
            {
                source1.Add(genre);
            }
            GenreText.AutoCompleteCustomSource = source1;
            /*List<Person> Author = new List<Person>();
            Author.Add(new Person("Стівен", "Кінг"));
            Author.Add(new Person("Федор", "Достоєвський"));
            Author.Add(new Person("Михайло", "Булгаков"));
            Author.Add(new Person("Джоан", "Ролінґ"));
            Author.Add(new Person("Джеймс", "Паттерсон"));
            Author.Add(new Person("Джордж", "Мартін"));
            Author.Add(new Person("Майкл", "Льюїс"));
            Author.Add(new Person("Метью", "Квік"));
            Author.Add(new Person("Джон", "Ґрін"));
            Author.Add(new Person("Ніл", "Ґейман"));
            Author.Add(new Person("Денніс", "Ліхейн"));
            Author.Add(new Person("Гілліан", "Флінн"));
            Author.Add(new Person("Ернест", "Клайн"));
            Author.Add(new Person("Діана", "Геблдон"));
            Author.Add(new Person("Девід", "Гранн"));
            Author.Add(new Person("Ю", "Несбе"));
            Author.Add(new Person("Маргарет", "Етвуд"));
            Author.Add(new Person("Бен", "Мезріч"));
            Author.Add(new Person("Ліана", "Моріарті"));
            Author.Add(new Person("Пола", "Гоукінз"));
            Author.Add(new Person("Джеффрі", "Тубін"));
            Author.Add(new Person("Грем", "Мур"));
            Author.Add(new Person("Емма", "Доног’ю"));
            Author.Add(new Person("Лорен", "Олівер"));
            Author.Add(new Person("Патрік", "Несс"));
            Author.Add(new Person("Марія", "Семпл"));
            Author.Add(new Person("Микола", "Гоголь"));
            Author.Add(new Person("Генрік", "Ібсен"));
            Author.Add(new Person("Франц", "Кафка"));
            Author.Add(new Person("Лев", "Толстий"));
            Author.Add(new Person("Вільям", "Шекспір"));
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\BookStore\BookStore\Lists\Author.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Author);
            }
            List<string> Genre = new List<string>();
            Genre.Add("Технічна література");
            Genre.Add("Бізнес");
            Genre.Add("Біографії");
            Genre.Add("Детектив");
            Genre.Add("Драма");
            Genre.Add("Історичний роман");
            Genre.Add("Класика");
            Genre.Add("Мелодрама");
            Genre.Add("Науково - популярна");
            Genre.Add("Поезія");
            Genre.Add("Пригодницький роман");
            Genre.Add("Психологія");
            Genre.Add("Сучасна проза");
            Genre.Add("Трилер");
            Genre.Add("Фантастика");
            Genre.Add("Роман");
            using (FileStream fs = new FileStream(@"C:\Users\saliv\source\repos\BookStore\BookStore\Lists\Genre.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Genre);
            }*/
        }

        private void PriceFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void AuthorText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
