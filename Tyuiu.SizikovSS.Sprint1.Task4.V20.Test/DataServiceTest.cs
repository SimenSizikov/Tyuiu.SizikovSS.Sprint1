using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SizikovSS.Sprint1.Task4.V20.Lib;


namespace Tyuiu.SizikovSS.Sprint1.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 8;
            double y = 7;
            double wait = 1.8;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}