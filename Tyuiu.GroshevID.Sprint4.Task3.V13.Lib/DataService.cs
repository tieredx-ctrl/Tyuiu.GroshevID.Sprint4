using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GroshevID.Sprint4.Task3.V13.Lib
{
    public class DataService : ISprint4Task3V13
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 3)
                    {
                        sum += array[i, j];
                    }
                }
            }

            return sum;
        }
    }
}
