using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YarkovSD.Sprint6.Task7.V10.Lib
{
    public class DataService : ISprint6Task7V10
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            // Определяем размеры матрицы
            int rows = lines.Length;
            string[] firstLine = lines[0].Split(';');
            int cols = firstLine.Length;

            // Создаем матрицу
            int[,] matrix = new int[rows, cols];

            // Заполняем матрицу данными из файла
            for (int i = 0; i < rows; i++)
            {
                string[] values = path.Split(';');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            int[,] result = new int[rows, cols];

            // Обрабатываем матрицу
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 4)
                    {
                        int value = matrix[i, j];
                        if (value >= 5 && value <= 10)
                        {
                            result[i, j] = 0;
                        }
                        else
                        {
                            result[i, j] = matrix[i, j];
                        }
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