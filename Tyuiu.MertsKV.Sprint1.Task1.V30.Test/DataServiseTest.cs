using Tyuiu.MertsKV.Sprint1.Task1.V30.Lib;

namespace Tyuiu.MertsKV.Sprint1.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServise ds = new DataServise();
            double x = 2.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(2, res);
        }
    }
}
