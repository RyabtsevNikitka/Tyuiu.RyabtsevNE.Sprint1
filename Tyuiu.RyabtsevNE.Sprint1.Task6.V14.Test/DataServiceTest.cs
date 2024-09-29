using Tyuiu.RyabtsevNE.Sprint1.Task6.V14.Lib;

namespace Tyuiu.RyabtsevNE.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            char[] russianLetters = new char[32];
            for (int i = 0; i < 32; i++)
            {
                russianLetters[i] = (char)('?' + i);
            }
            string strTest = "? ? ????? ??????? ? ????";
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckLowerCaseRusLetters(strTest));
        }
    }
}