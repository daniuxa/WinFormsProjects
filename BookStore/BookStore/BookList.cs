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
    public partial class BookList : Form
    {
        /*public List<Book> cart = null;*/
        public Cart cart = null;
        List<Book> booksFiltred = new List<Book>();
        private List<Book> Books;
        private Book BookTo;
        private Book BookFrom;

        public BookList(Book BookTo, Book BookFrom, Cart cart)
        {
            InitializeComponent();
            this.BookTo = BookTo;
            this.BookFrom = BookFrom;
            this.cart = cart;
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            
            /*List<Book> books = new List<Book>()
            {
                new Book("Сяйво", new Person("Стівен", "Кінг"), 1977, 135, "Роман"),
                new Book("Доктор Сон", new Person("Стівен", "Кінг"), 2012, 230, "Роман"),
                new Book("Ідіот", new Person("Федор", "Достоєвський"), 1868, 80, "Роман"),
                new Book("Брати Карамазові", new Person("Федор", "Достоєвський"), 1880, 80, "Роман"),
                new Book("Собаче серце", new Person("Михайло", "Булгаков"), 1968, 60, "Фантастика"),
                new Book("Мастер і Маргарита", new Person("Михайло", "Булгаков"), 1966, 135, "Роман"),
                new Book("Гаррі Поттер і філософський камінь", new Person("Джоан", "Роалінґ"), 1997, 190, "Фантастика"),
                new Book("Зникнення президента", new Person("Джеймс", "Паттерсон"), 2009, 126, "Детектив"),
                new Book("Гра престолів", new Person("Джордж", "Мартін"), 1996, 300, "Роман"),
                new Book("Кораліна", new Person("Ніл", "Ґейман"), 2002, 145, "Повість"),
                new Book("Острів проклятих", new Person("Денніс", "Ліхейн"), 2003, 200, "Роман"),
                new Book("Загублена", new Person("Гілліан", "Флінн"), 2012, 75, "Роман"),
                new Book("Оповідь служниці", new Person("Маргарет", "Етвуд"), 2012, 165, "Роман"),
                new Book("Дев'ять незнайомців", new Person("Ліана", "Моріарті"), 2018, 180, "Повість"),
                new Book("Дівчина у потягу", new Person("Пола", "Гоукінз"), 2015, 215, "Трилер"),
                new Book("Поклик монстра", new Person("Патрік", "Несс"), 2011, 165, "Роман"),
                new Book("Тарас Бульба", new Person("Микола", "Гоголь"), 1835, 80, "Повість"),
                new Book("Ляльковий дім", new Person("Генрік", "Ібсен"), 1879, 85, "Роман"),
                new Book("Війна і мир", new Person("Лев", "Толстий"), 1873, 128, "Роман")
            };
*/

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\BookStore\\BookStore\\Lists\\Books.bin", FileMode.OpenOrCreate))
            {
                Books = (List<Book>)formatter.Deserialize(fs);
            }

            bool checkName = true;
            bool checkAuthor = true;
            bool checkGenre = true;
            bool checkPublicationYear = true;
            foreach (var book in Books)
            {
                if (BookFrom.Name != "")
                {
                    if (BookFrom.Name == book.Name)
                    {
                        checkName = true;
                    }
                    else
                    {
                        checkName = false;
                    }
                }
                if (BookFrom.Author != null)
                {
                    if (BookFrom.Author.Name == book.Author.Name && BookFrom.Author.Surname == book.Author.Surname)
                    {
                        checkAuthor = true;
                    }
                    else
                    {
                        checkAuthor = false;
                    }
                }
                if (BookFrom.Genre != "По замовченню")
                {
                    if (BookFrom.Genre == book.Genre)
                    {
                        checkGenre = true;
                    }
                    else
                    {
                        checkGenre = false;
                    }
                }
                if (BookFrom.PublicationYear != 0)
                {
                    if (BookFrom.PublicationYear == book.PublicationYear)
                    {
                        checkPublicationYear = true;
                    }
                    else
                    {
                        checkPublicationYear = false;
                    }
                }
                if (checkName == true && checkAuthor == true && checkGenre == true && checkPublicationYear == true)
                {
                    if (BookFrom.Price != 0 && BookTo.Price != 0)
                    {
                        if (BookFrom.Price <= book.Price && BookTo.Price >= book.Price)
                        {
                            booksFiltred.Add(book);
                        }
                    }
                    else if (BookFrom.Price != 0 && BookTo.Price == 0)
                    {
                        if (BookFrom.Price <= book.Price)
                        {
                            booksFiltred.Add(book);
                        }
                    }
                    else if (BookFrom.Price == 0 && BookTo.Price != 0)
                    {
                        if (BookTo.Price >= book.Price)
                        {
                            booksFiltred.Add(book);
                        }
                    }
                    else
                    {
                        booksFiltred.Add(book);
                    }
                    checkName = true;
                    checkAuthor = true;
                    checkGenre = true;
                    checkPublicationYear = true;
                }
            }
            if (booksFiltred.Count == 0)
            {
                MessageBox.Show("Список пустий");
                this.Close();
                return;
            }
            else
            {
                ListViewItem item = null;
                foreach (var book in booksFiltred)
                {
                    item = new ListViewItem(new string[] { book.Name, book.Author.Name + " " + book.Author.Surname, Convert.ToString(book.PublicationYear), Convert.ToString(book.Price), book.Genre});
                    BookListView.Items.Add(item);
                }
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (BookListView.SelectedItems.Count != 0)
            {
                if (cart == null)
                    cart = new Cart();
                for (int i = 0; i < BookListView.SelectedItems.Count; i++)
                {
                    cart.Add(booksFiltred[BookListView.SelectedItems[i].Index]);
                }
            }
            else
            {
                MessageBox.Show("Виберіть хоча б одну книгу");
            }
        }

        private void ChangeFiltersButton_Click(object sender, EventArgs e)
        {
            FilterForm form = new FilterForm(cart);
            form.ShowDialog();
        }

        private void ShowCartButton_Click(object sender, EventArgs e)
        {
            if (cart != null)
            {
                if (cart.Count() != 0)
                {
                    CartForm form = new CartForm(ref cart);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Корзина пуста");
                }
            }
            else
            {
                MessageBox.Show("Корзина пуста");
            }
            

        }
    }
}
