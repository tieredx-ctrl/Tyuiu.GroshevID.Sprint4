using Tyuiu.GroshevID.Sprint4.Task5.V20.Lib;

namespace Tyuiu.GroshevID.Sprint4.Task5.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,]
            {
                { -4, -2, 0, -1, -3 },
                { 3, 2, -1, 0, -1 },
                { 0, 0, 1, 3, 3 },
                { -7, -3, 3, 0, -1 },
                { 0, 0, 0, -1, -7 }
            };

            int res = ds.Calculate(matrix);
            int wait = 15;

            Assert.AreEqual(wait, res);
        }
    }
}
