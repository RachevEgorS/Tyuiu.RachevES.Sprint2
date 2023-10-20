using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint2.Task7.V13.Lib;
namespace Tyuiu.RachevES.Sprint2.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.4;
            bool wait = true;

            Assert.AreEqual(wait, ds.CheckDotInShadedArea(x, y));
        }
    }
}
