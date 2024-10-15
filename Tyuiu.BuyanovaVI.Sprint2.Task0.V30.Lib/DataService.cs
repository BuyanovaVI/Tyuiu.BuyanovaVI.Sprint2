using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.BuyanovaVI.Sprint2.Task0.V30.Lib
{
    public class DataService : ISprint2Task0V30
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            //x = 95, y = 1735
            //(True, False, True, False, True, False)
            bool[] res = new bool[6];
            res[0] = x == y - 1640;
            res[1] = x != y - 1640;
            res[2] = x < y;
            res[3] = x > y;
            res[4] = x <= y;
            res[5] = x >= y;

            return res;
        }
    }
}
