using Tyuiu.GroshevID.Sprint4.Task3.V13.Lib;

namespace Tyuiu.GroshevID.Sprint4.Task3.V13.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[,] {
                { 4, 7, 4, 2, 1 },
                { 6, 7, 3, 6, 5 },
                { 6, 5, 3, 3, 5 },
                { 4, 4, 6, 4, 7 },
                { 2, 1, 2, 3, 4 }
            };

            int res = ds.Calculate(array);
            int wait = 18;

            Assert.AreEqual(wait, res);
        }
    }
}
