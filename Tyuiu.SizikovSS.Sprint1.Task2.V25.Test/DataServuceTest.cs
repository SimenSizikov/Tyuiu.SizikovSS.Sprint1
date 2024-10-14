using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SizikovSS.Sprint1.Task2.V25.Lib;

namespace Tyuiu.SizikovSS.Sprint1.Task2.V25.Test
{
    [TestClass]
    public class DataServuceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertRadsToDegrees(x);
            Assert.AreEqual(114.592, res);
        }
    }
}