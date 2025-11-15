using Tyuiu.GroshevID.Sprint4.Task7.V7.Lib;

namespace Tyuiu.GroshevID.Sprint4.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];

            string value = "31415926";

            int res = ds.Calculate(n, m, value);
            int wait = 5;

            Assert.AreEqual(wait, res);
        }
    }
}
