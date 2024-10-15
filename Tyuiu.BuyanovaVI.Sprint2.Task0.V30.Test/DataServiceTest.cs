using Tyuiu.BuyanovaVI.Sprint2.Task0.V30.Lib;

namespace Tyuiu.BuyanovaVI.Sprint2.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int x = 95;
            int y = 1735;
            var res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}