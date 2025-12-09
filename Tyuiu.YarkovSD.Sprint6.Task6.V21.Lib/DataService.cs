using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YarkovSD.Sprint6.Task6.V21.Lib
{
    public class DataService : ISprint6Task6V21
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Разбиваем строку на слова по стандартным разделителям
                    char[] separators = new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r' };
                    string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    // Фильтруем слова, содержащие строчную букву 'g'
                    var filteredWords = words.Where(word => word.Contains('g'));

                    // Добавляем отфильтрованные слова в результат
                    foreach (string word in filteredWords)
                    {
                        result += word + " ";
                    }
                }
            }

            return result.Trim();
        }
    }
}