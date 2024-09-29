using Tyuiu.RyabtsevNE.Sprint1.Task2.V11.Lib;

namespace Tyuiu.RyabtsevNE.Sprint1.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            int valu1 = 1;
            int valu2 = 20;
            int res = ds.ConvertHoursMinutesToSeconds(valu1, valu2);
            Assert.AreEqual(4800, res);
        }
    }
}