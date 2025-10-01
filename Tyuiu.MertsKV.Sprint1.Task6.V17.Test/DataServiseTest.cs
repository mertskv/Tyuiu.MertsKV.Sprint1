using Tyuiu.MertsKV.Sprint1.Task6.V17.Lib;
namespace Tyuiu.MertsKV.Sprint1.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidString()
        {
            string test = "дед";
            DataServise ds = new DataServise();
            var res = ds.CheckPalindrome(test);

            Assert.IsTrue(res);
        }
    }
}
