using Tyuiu.BabaiKV.Sprint3.Task1.V6.Lib;
namespace Tyuiu.BabaiKV.Sprint3.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 4;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(value,startValue, stopValue);
            double wait = -389102.250;
            Assert.AreEqual(wait, res);
        }
    }
}