using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SizikovSS.Sprint1.Task0.V6.Lib;

namespace Tyuiu.SizikovSS.Sprint1.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(15, res);
        }
    }
}