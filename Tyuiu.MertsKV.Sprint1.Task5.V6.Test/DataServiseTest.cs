using Tyuiu.MertsKV.Sprint1.Task5.V6.Lib;

namespace Tyuiu.MertsKV.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServise ds = new DataServise();
            int x = 10;
            double res = ds.Calculate(x);
            Assert.AreEqual(3, res);
        }
    }
}
