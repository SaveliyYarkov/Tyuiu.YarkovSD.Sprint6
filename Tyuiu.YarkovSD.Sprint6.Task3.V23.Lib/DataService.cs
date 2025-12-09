using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YarkovSD.Sprint6.Task3.V23.Lib
{
    public class DataService : ISprint6Task3V23
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Создаем массив строк для удобства сортировки
            int[][] rowsArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                rowsArray[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    rowsArray[i][j] = matrix[i, j];
                }
            }

            // Сортируем массив строк по второму элементу (столбцу с индексом 1)
            Array.Sort(rowsArray, (row1, row2) => row1[1].CompareTo(row2[1]));

            // Преобразуем обратно в двумерный массив
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = rowsArray[i][j];
                }
            }

            return result;
        }
    }
}
