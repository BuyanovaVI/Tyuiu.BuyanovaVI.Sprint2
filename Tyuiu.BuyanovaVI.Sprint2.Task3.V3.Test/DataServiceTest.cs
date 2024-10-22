using Tyuiu.BuyanovaVI.Sprint2.Task3.V3.Lib;

namespace Tyuiu.BuyanovaVI.Sprint2.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0; double y = 0.167;
            Assert.AreEqual(y, ds.Calculate(x));
        }
    }
}