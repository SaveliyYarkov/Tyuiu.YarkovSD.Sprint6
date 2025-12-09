using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YarkovSD.Sprint6.Task6.V21.Lib
{
    public class DataService : ISprint6Task6V21
    {
        public string CollectTextFromFile(string str)
        {
            // Используем str как разделитель для слов
            char separator = ' ';
            if (!string.IsNullOrEmpty(str) && str.Length > 0)
            {
                separator = str[0];
            }

            string result = "";

            using (StreamReader sr = new StreamReader(str))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Разбиваем строку на слова по заданному разделителю
                    string[] words = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    // Фильтруем слова, содержащие букву 'g' 
                    var filteredWords = words.Where(word =>
                        word.IndexOf('g', StringComparison.OrdinalIgnoreCase) >= 0);

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