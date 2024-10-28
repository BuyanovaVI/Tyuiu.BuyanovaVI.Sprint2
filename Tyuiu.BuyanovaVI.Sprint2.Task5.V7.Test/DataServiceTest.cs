using Tyuiu.BuyanovaVI.Sprint2.Task5.V7.Lib;

namespace Tyuiu.BuyanovaVI.Sprint2.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService service1 = new DataService();
            int year = 1990;
            int n = 5;
            string q = service1.FindMonthName(year, n);
            Assert.AreEqual("Май", q);
        }
    }
}