using Tyuiu.RyabtsevNE.Sprint1.Task3.V4.Lib;

namespace Tyuiu.RyabtsevNE.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2.75;
            double y = 0.5;
            int z = 7;
            double wait = 22.75;
            var res = ds.PurchaseAmount(x, y, z);
            Assert.AreEqual(wait, res);
        }
    }
}