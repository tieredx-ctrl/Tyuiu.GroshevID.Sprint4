using Tyuiu.GroshevID.Sprint4.Task2.V6.Lib;

namespace Tyuiu.GroshevID.Sprint4.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 3, 6, 7, 3, 8, 3, 2, 4, 7, 7, 8, 4, 4, 2 };

            int res = ds.Calculate(array);
            int wait = 9261;

            Assert.AreEqual(wait, res);
        }
    }
}
