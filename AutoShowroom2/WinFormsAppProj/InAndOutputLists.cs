﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    class InAndOutputLists<T>
    {
        private string FilePath;
        public void ChangeFilePath(string FilePath)
        {
            this.FilePath = FilePath;
        }
        public InAndOutputLists()
        {
            FilePath = "";
        }

        public InAndOutputLists(string FilePath)
        {
            this.FilePath = FilePath;
        }

        public T ReadingFromFile()
        {
            if (FilePath == "")
            {
                /*return null;*/
                throw new FileException("Шлях до файлу пустий", FilePath);
            }                

            var file = new FileInfo(FilePath);
            if (file.Exists == false)
            {
                /*return null;*/
                throw new FileException("Файл не існує", FilePath);
            }
            if (file.Length == 0)
            {
                /*return null;*/
                throw new FileException("Файл пустий", FilePath);
            }

            T list;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                list = (T)formatter.Deserialize(fs);
            }
            return list;
        }
        public /*bool*/void WritingToFile(T list)
        {
            if (FilePath == "")
            {
                /*return false;*/
                throw new FileException("Шлях до файлу пустий", FilePath);
            }

            /*if (list == null || list.Count == 0)
            {
                return false;
            }*/

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
            /*return true;*/
        }

        public T ReadingFromDB()
        {
            return default(T);
        }
        public bool WritingToDB(T list)
        {
            return false;
        }
    }
}
