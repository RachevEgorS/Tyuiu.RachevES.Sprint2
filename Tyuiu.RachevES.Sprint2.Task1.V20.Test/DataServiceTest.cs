using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint2.Task1.V20.Lib;

namespace Tyuiu.RachevES.Sprint2.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();
       
            int a = 242;
            int b = 155;
            int c = 456;
            int d = 17;

            bool[] wait = { false, false, false, true, true, true };
            CollectionAssert.AreEqual(wait, ds.GetLogicOperations(a, b, c, d));
        }
    }
}
