using Tyuiu.MertsKV.Sprint1.Task0.V30.Lib;

namespace Tyuiu.MertsKV.Sprint1.Task0.V30.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServise ds = new DataServise();
            var res = ds.Calculate();
            Assert.AreEqual(96, res);
        }
    }
}
