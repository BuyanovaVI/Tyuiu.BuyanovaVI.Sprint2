using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BuyanovaVI.Sprint2.Task3.V3.Lib
{
    public class DataService : ISprint2Task3V3
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return Math.Round(x * Math.Pow((x + 1) / (x - 1), x), 3);
            }
            if (x == 0)
            {
                return Math.Round((x * x * x * x - Math.Cos(x * x * x * x * x) + 3) / (x * x - Math.Sin(x * x) + 12), 3);
            }
            if (x < -7)
            {
                return Math.Round(x * x + 10 * x - (1 / x), 3);
            }
            else
            {
                return Math.Round(Math.Pow(1 + ((Math.Sqrt(x + 3)) / (x * x)), x), 3);
            }
        }

    }
}
