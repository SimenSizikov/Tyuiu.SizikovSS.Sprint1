using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SizikovSS.Sprint1.Task5.V4.Lib;

namespace Tyuiu.SizikovSS.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 13257;
            int wait = 3;
            var res = ds.SecondsToHours(k);
            Assert.AreEqual(wait, res);
        }
    }
}