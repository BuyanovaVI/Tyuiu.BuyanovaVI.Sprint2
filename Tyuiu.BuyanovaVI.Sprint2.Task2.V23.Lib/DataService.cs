using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BuyanovaVI.Sprint2.Task2.V23.Lib
{
    public class DataService : ISprint2Task2V23
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x > 2) && (x <= 5) && (y > 2) && (y <= 5))
            {
                res = true;
            }
            else if ((x > 2) && (x < 6) && (y > 10) && (y < 12))
            {
                res = true;
            }
            else if ((x > 5) && (x < 7) && (y > 4) && (y < 6))
            {
                res = true;
            }
            else if ((x > 5) && (x < 7) && (y > 8) && (y < 12))
            {
                res = true;
            }
            else if ((x > 6) && (x < 9) && (y > 4) && (y < 13))
            {
                res = true;
            }
            else if ((x > 8) && (x < 11) && (y > 2) && (y < 13))
            {
                res = true;
            }
            else if ((x > 10) && (x < 12) && (y > 2) && (y < 12))
            {
                res = true;
            }
            else if ((x > 11) && (x < 13) && (y > 2) && (y < 13))
            {
                res = true;
            }
            else if ((x > 12) && (x < 14) && (y > 5) && (y < 9))
            {
                res = true;
            }
            else if ((x > 12) && (x < 14) && (y > 10) && (y < 13))
            {
                res = true;
            }
            else
            {
                res = false;

            }

            return res;
        }
    }
}