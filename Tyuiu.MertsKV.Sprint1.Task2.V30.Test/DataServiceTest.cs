using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint1.Task2.V30.Lib;


namespace Tyuiu.MertsKV.Sprint1.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateWholeNumbers()
        {
            DataService converter = new DataService();

            Assert.AreEqual(1000, converter.ConvertKmToMetre(1)); // Исправлено на ConvertKmToMetre
            Assert.AreEqual(5000, converter.ConvertKmToMetre(5));
            Assert.AreEqual(25000, converter.ConvertKmToMetre(25));
        }

        [TestMethod]
        public void ValidCalculateDecimalNumbers()
        {
            DataService converter = new DataService();

            Assert.AreEqual(1250.500, converter.ConvertKmToMetre(1.2505));
            Assert.AreEqual(834.750, converter.ConvertKmToMetre(0.83475));
            Assert.AreEqual(15234.567, converter.ConvertKmToMetre(15.234567));
        }

        [TestMethod]
        public void ValidCalculateZero()
        {
            DataService converter = new DataService();

            Assert.AreEqual(0, converter.ConvertKmToMetre(0));
        }

        [TestMethod]
        public void ValidCalculateSmallNumbers()
        {
            DataService converter = new DataService();

            Assert.AreEqual(0.001, converter.ConvertKmToMetre(0.000001));
            Assert.AreEqual(0.500, converter.ConvertKmToMetre(0.0005));
        }

        [TestMethod]
        public void ValidCalculateRounding()
        {
            DataService converter = new DataService();

            Assert.AreEqual(1234.568, converter.ConvertKmToMetre(1.23456789));
            Assert.AreEqual(999.999, converter.ConvertKmToMetre(0.999999));
            Assert.AreEqual(1000.001, converter.ConvertKmToMetre(1.0000005));
        }
    }
}

