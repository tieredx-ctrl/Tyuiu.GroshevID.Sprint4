using System.Data.Common;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GroshevID.Sprint4.Task7.V7.Lib
{
    public class DataService : ISprint4Task7V7
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value[i*m + j].ToString());

                    if (mtrx[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
