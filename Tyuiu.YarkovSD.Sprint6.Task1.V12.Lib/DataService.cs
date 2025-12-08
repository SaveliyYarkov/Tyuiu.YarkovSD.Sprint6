using System.Net.Http.Headers;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YarkovSD.Sprint6.Task1.V28.Lib
{
    public class DataService : ISprint6Task1V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] a = new double[stopValue - startValue + 1];
            int s = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                a[s] = Math.Round(Math.Sin(i) + ((Math.Cos(i) + 1) / (2 - i)) + 2 * i, 2);
                s++;
            }
            return a;
        }
    }
}
