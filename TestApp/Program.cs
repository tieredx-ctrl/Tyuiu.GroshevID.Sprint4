string str = "548685532";
int[,] matrix = new int[3, 3];
int sum = 0;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrix[i, j] = int.Parse(str[i * 3 + j].ToString());
        if (i == 2)
        {
            sum += matrix[i, j];
        }
    }
}

Console.WriteLine(sum);