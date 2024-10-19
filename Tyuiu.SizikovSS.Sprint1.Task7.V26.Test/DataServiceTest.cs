using Tyuiu.SizikovSS.Sprint1.Task7.V26.Lib;

namespace Tyuiu.SizikovSS.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double wait = 0.882;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}