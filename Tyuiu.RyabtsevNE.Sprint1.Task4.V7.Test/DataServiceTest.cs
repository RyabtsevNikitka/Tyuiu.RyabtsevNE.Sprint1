using Tyuiu.RyabtsevNE.Sprint1.Task4.V7.Lib;

namespace Tyuiu.RyabtsevNE.Sprint1.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 2.0;
            double wait = 1.188;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}