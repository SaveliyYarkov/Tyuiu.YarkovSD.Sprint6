using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YarkovSD.Sprint6.Task5.V7.Lib
{
    public class DataService : ISprint6Task5V7
    {
        public double[] LoadFromDataFile(string path)
        {
            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(path);

            // Преобразуем строки в числа
            double[] numbers = new double[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                numbers[i] = Convert.ToDouble(lines[i]);
            }

            // Фильтруем: оставляем только числа > 5
            double[] result = numbers.Where(val => val > 5).ToArray();

            return result;
        }
    }
}