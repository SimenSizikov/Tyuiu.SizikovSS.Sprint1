using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SizikovSS.Sprint1.Task6.V1.Lib;

namespace Tyuiu.SizikovSS.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "1";
            DataService ds = new DataService();
            string res = ds.SymbolCode(strTest);
            string wait = "49";
            Assert.AreEqual(wait, res);
        }
    }
}