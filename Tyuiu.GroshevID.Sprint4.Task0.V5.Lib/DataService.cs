using System.Buffers;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GroshevID.Sprint4.Task0.V5.Lib
{
    public class DataService : ISprint4Task0V5
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
