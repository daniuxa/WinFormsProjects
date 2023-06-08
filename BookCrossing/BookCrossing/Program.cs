using BookCrossing.Entities;
using BookCrossing.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCrossing
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); //Робота програми починається з форми MainForm
/*
            List<Client> clients = new List<Client>();
            clients.Add(new Client("1", "2", "1234567890", new ClientAccount("123", "12345")));
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Files/Clients.bin");
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, clients);
            }*/

            /*List<Book> books = new List<Book>()
            {
                new Book("Сяйво", new Person("Стівен", "Кінг"), 1977, "Роман"),
                new Book("Доктор Сон", new Person("Стівен", "Кінг"), 2012, "Роман"),
                new Book("Ідіот", new Person("Федор", "Достоєвський"), 1868, "Роман"),
                new Book("Брати Карамазові", new Person("Федор", "Достоєвський"), 1880, "Роман"),
                new Book("Собаче серце", new Person("Михайло", "Булгаков"), 1968, "Фантастика"),
                new Book("Мастер і Маргарита", new Person("Михайло", "Булгаков"), 1966, "Роман"),
                new Book("Гаррі Поттер і філософський камінь", new Person("Джоан", "Роалінґ"), 1997, "Фантастика"),
                new Book("Зникнення президента", new Person("Джеймс", "Паттерсон"), 2009, "Детектив"),
                new Book("Гра престолів", new Person("Джордж", "Мартін"), 1996, "Роман"),
                new Book("Кораліна", new Person("Ніл", "Ґейман"), 2002, "Повість"),
                new Book("Острів проклятих", new Person("Денніс", "Ліхейн"), 2003, "Роман"),
                new Book("Загублена", new Person("Гілліан", "Флінн"), 2012, "Роман"),
                new Book("Оповідь служниці", new Person("Маргарет", "Етвуд"), 2012, "Роман"),
                new Book("Дев'ять незнайомців", new Person("Ліана", "Моріарті"), 2018, "Повість"),
                new Book("Дівчина у потягу", new Person("Пола", "Гоукінз"), 2015, "Трилер"),
                new Book("Поклик монстра", new Person("Патрік", "Несс"), 2011, "Роман"),
                new Book("Тарас Бульба", new Person("Микола", "Гоголь"), 1835, "Повість"),
                new Book("Ляльковий дім", new Person("Генрік", "Ібсен"), 1879, "Роман"),
                new Book("Війна і мир", new Person("Лев", "Толстий"), 1873, "Роман")
            };
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Files/Books.bin");
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, books);
            }*/
        }
    }
}
