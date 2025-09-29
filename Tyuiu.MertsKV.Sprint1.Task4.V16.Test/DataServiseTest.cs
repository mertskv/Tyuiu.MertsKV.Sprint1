using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MertsKV.Sprint1.Task4.V16.Lib;


namespace Tyuiu.MertsKV.Sprint1.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServise ds = new DataServise();
            double x = 5;
            double wait = 0.111;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
