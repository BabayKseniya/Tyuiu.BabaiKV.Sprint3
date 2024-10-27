using Tyuiu.BabaiKV.Sprint3.Task0.V4.Lib;
namespace Tyuiu.BabaiKV.Sprint3.Task0.V4.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            int startValue = 0;
            int endValue = 5;
            double res = ds.GetMultiplySeries(startValue, endValue);
            double wait = 14.943;
            Assert.AreEqual(wait, res);
        }
    }
}