using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GroshevID.Sprint4.Task6.V6.Lib
{
    public class DataService : ISprint4Task6V6
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, name => name.Length == 5);

            return res;
        }
    }
}
