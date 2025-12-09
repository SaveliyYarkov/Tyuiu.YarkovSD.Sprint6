using System;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YarkovSD.Sprint6.Task3.V23.Lib
{
    public class DataService : ISprint6Task3V23
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0); // 5
            int cols = matrix.GetLength(1); // 5

            // Копируем исходную матрицу
            int[,] resultMatrix = new int[rows, cols];
            Array.Copy(matrix, resultMatrix, matrix.Length);

            // Получаем значения из второго столбца (индекс 1)
            List<int> secondColumnValues = new List<int>();
            for (int i = 0; i < rows; i++)
            {
                secondColumnValues.Add(resultMatrix[i, 1]);
            }

            // Сортируем значения
            secondColumnValues.Sort();

            // Вставляем отсортированные значения обратно во второй столбец
            for (int i = 0; i < rows; i++)
            {
                resultMatrix[i, 1] = secondColumnValues[i];
            }

            return resultMatrix;
        }
    }
}
