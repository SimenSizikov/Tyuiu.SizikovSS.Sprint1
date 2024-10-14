using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SizikovSS.Sprint1.Task3.V18.Lib;

namespace Tyuiu.SizikovSS.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 4;
            double z = 3;
            var res = ds.HowManySquares(x, y, z);
            Assert.AreEqual(4, res);
        }
    }
}