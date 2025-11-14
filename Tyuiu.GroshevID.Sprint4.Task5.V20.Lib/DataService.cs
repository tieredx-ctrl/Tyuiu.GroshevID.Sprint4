using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GroshevID.Sprint4.Task5.V20.Lib
{
    public class DataService : ISprint4Task5V20
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int res = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == Math.Abs(matrix[i, j]))
                    {
                        res += matrix[i, j];
                    }
                }
            }
            return res;
        }
    }
}
