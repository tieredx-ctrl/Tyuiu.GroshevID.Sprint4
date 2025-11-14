using Tyuiu.GroshevID.Sprint4.Task4.V24.Lib;

namespace Tyuiu.GroshevID.Sprint4.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,] {
                { 4, 7, 4, 2, 1 },
                { 6, 7, 3, 6, 5 },
                { 6, 5, 3, 3, 5 },
                { 4, 4, 6, 4, 7 },
                { 2, 1, 2, 3, 4 }
            };

            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[,] {
                { 1, 7, 1, 1, 1 },
                { 1, 7, 3, 1, 5 },
                { 1, 5, 3, 3, 5 },
                { 1, 1, 1, 1, 7 },
                { 1, 1, 1, 3, 1 }
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
