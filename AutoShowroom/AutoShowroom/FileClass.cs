using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AutoShowroom
{
    class FileClass<T>
    {
        public T ReadingFromFile(string FilePath)
        {
            if (FilePath == "")
            {
                throw new FileException("Шлях до файлу пустий", FilePath);
            }

            var file = new FileInfo(FilePath);
            if (file.Exists == false)
            {
                throw new FileException("Файл не існує", FilePath);
            }
            if (file.Length == 0)
            {
                throw new FileException("Файл пустий", FilePath);
            }

            T array;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                array = (T)formatter.Deserialize(fs);
            }
            return array;
        }
        public void WritingToFile(T array, string FilePath)
        {
            if (FilePath == "")
            {
                throw new FileException("Шлях до файлу пустий", FilePath);
            }

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, array);
            }
        }
    }
}
