using Tyuiu.GroshevID.Sprint4.Task6.V6.Lib;

namespace Tyuiu.GroshevID.Sprint4.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            var array = new string[] { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };

            var res = ds.Calculate(array);
            var wait = new string[] { "Борис", "Ирина" };

            Assert.AreEqual(wait, res);
        }
    }
}
