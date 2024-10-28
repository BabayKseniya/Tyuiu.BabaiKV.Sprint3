using Tyuiu.BabaiKV.Sprint3.Task2.V13.Lib;
namespace Tyuiu.BabaiKV.Sprint3.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.7;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 4.063;
            Assert.AreEqual(wait, res);
        }
    }
}