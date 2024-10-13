using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SizikovSS.Sprint1.Task1.V12.Lib;

namespace Tyuiu.SizikovSS.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 4.0;
            var res = ds.Calculate();
            Assert.AreEqual(1, res);
        }
    }
}