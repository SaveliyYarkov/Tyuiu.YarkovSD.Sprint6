using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YarkovSD.Sprint6.Task2.V24.Lib
{
    public class DataService : ISprint6Task2V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] resultArray = new double[length];

            for (int i = 0, x = startValue; x <= stopValue; i++, x++)
            {
                // Проверка деления на ноль
                if (Math.Abs(2 - x) < 0.0000001) // Учет погрешности double
                {
                    resultArray[i] = 0; // При делении на ноль возвращаем 0
                }
                else
                {
                    // Вычисляем функцию
                    double value = CalculateFunction(x);
                    resultArray[i] = Math.Round(value, 2);
                }
            }

            return resultArray;
        }

        private double CalculateFunction(double x)
        {
            // F(x) = sin(x) + (cos(x) + 1) / (2 - x) + 2x
            return Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x;
        }
    }
}
