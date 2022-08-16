using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLibrary
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //sorted list
            SortedList<int, string> myList = new SortedList<int, string>();


            myList.Add(20, "Computer");
            myList.Add(30, "TV");
            myList.Add(5, "House");

            foreach (int key in myList.Keys)
                Console.WriteLine("Ключ=" + key + " , значение=" + myList[key]);

            myList.Remove(30);

            object Value = myList[20];


            bool isFound = myList.ContainsKey(25);




            /*List<Book> books = new List<Book>()
           {
               new Book("Сяйво", "Стівен Кінг", 1977, "Роман"), 
               new Book("Доктор Сон", "Стівен Кінг", 2012, "Роман"),
               new Book("Ідіот", "Федор Достоєвський", 1868, "Роман"),
               new Book("Брати Карамазові", "Федор Достоєвський", 1880, "Роман"),
               new Book("Собаче серце", "Михайло Булгаков", 1968, "Фантастика"),
               new Book("Мастер і Маргарита", "Михайло Булгаков", 1966, "Роман"),
               new Book("Гаррі Поттер і філософський камінь", "Джоан Роалінґ", 1997, "Фантастика"),
               new Book("Зникнення президента", "Джеймс Паттерсон", 2009, "Детектив"),
               new Book("Гра престолів", "Джордж Мартін", 1996, "Роман"),
               new Book("Кораліна", "Ніл Ґейман", 2002, "Повість"),
               new Book("Острів проклятих", "Денніс Ліхейн", 2003, "Роман"),
               new Book("Загублена", "Гілліан Флінн", 2012, "Роман"),
               new Book("Оповідь служниці", "Маргарет Етвуд", 2012, "Роман"),
               new Book("Дев'ять незнайомців", "Ліана Моріарті", 2018, "Повість"),
               new Book("Дівчина у потягу", "Пола Гоукінз", 2015, "Трилер"),
               new Book("Поклик монстра", "Патрік Несс", 2011, "Роман"),
               new Book("Тарас Бульба", "Микола Гоголь", 1835, "Повість"),
               new Book("Ляльковий дім", "Генрік Ібсен", 1879, "Роман"),
               new Book("Війна і мир", "Лев Толстий", 1873, "Роман")
           };
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Books.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, books);
            }*/
            /* List<string> Genres = new List<string>() { "По замовченню", "Технічна література", "Бізнес", "Біографії", "Детектив", "Драма", "Історичний роман", "Класика", "Мелодрама", "Науково-популярна", "Поезія", "Пригодницький роман", "Психологія", "Сучасна проза", "Трилер", "Фантастика", "Роман", "Повість" };

      WorkingWithFiles<List<string>> workingWithFiles = new WorkingWithFiles<List<string>>();
          workingWithFiles.WritingToFile(Genres, "Genre.bin");*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ClientForm());
        }
    }
}
