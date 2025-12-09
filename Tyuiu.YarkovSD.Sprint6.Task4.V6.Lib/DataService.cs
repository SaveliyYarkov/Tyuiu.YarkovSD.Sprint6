using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YarkovSD.Sprint6.Task4.V6.Lib
{
    public class DataService : ISprint6Task4V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] a = new double[stopValue - startValue + 1];
            int s = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                a[s] = Math.Round((3 * Math.Cos(i) / (4 * i - 0.5)) + Math.Sin(i) - 5 * i - 2, 2);
                s++;
            }

            return a;
        }
    }
}
