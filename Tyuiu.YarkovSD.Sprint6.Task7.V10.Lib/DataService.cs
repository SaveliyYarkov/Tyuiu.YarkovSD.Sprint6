using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
using System.Linq;

namespace Tyuiu.YarkovSD.Sprint6.Task7.V10.Lib
{
    public class DataService : ISprint6Task7V10
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path)
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .ToArray();

            if (lines.Length < 5)
                throw new ArgumentException($"Требуется минимум 5 строк. Найдено: {lines.Length}");

            int rows = lines.Length;
            string[] firstLine = lines[0].Split(';');
            int cols = firstLine.Length;

            int[,] matrix = new int[rows, cols];
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    if (int.TryParse(values[j]?.Trim() ?? "0", out int value))
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            // Обрабатываем пятую строку
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 4 && matrix[i, j] >= 5 && matrix[i, j] <= 10)
                    {
                        result[i, j] = 0;
                    }
                    else
                    {
                        result[i, j] = matrix[i, j];
                    }
                }
            }

            return result;
        }
    }
}