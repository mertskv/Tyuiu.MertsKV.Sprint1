using Tyuiu.MertsKV.Sprint1.Task7.V9.Lib;

namespace Tyuiu.MertsKV.Sprint1.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServise ds = new DataServise();
            double x = 1;
            double y = 2;
            double wait = 1.975;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
