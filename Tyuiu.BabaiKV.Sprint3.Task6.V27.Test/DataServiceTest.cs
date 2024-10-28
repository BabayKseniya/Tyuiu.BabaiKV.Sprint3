using Tyuiu.BabaiKV.Sprint3.Task6.V27.Lib;
namespace Tyuiu.BabaiKV.Sprint3.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            int startValue = 14;
            int stopValue = 20;
            
            double res = ds.GetSumTheDivisors( startValue, stopValue);
            double wait = 129;
            Assert.AreEqual(wait, res);
        }
    }
}