using Tyuiu.RyabtsevNE.Sprint1.Task1.V5.Lib;

namespace Tyuiu.RyabtsevNE.Sprint1.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5.66666666666667, res);
        }
    }
}