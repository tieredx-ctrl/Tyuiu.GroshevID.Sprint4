using Tyuiu.GroshevID.Sprint4.Task3.V13.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Грошев И. Д. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Грошев Илья Дмитриевич | РППб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* статическими значениями в диапазоне от 1 до 7. Найдите сумму элементов  *");
        Console.WriteLine("* в третьем столбце массива.                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] array = new int[,] {
                { 4, 7, 4, 2, 1 },
                { 6, 7, 3, 6, 5 },
                { 6, 5, 3, 3, 5 },
                { 4, 4, 6, 4, 7 },
                { 2, 1, 2, 3, 4 }
            };

        int rows = array.GetUpperBound(0) + 1;
        int columns = array.Length / rows;

        Console.WriteLine("Массив:");
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(array);

        Console.WriteLine("Сумма элементов третьего столбца = " + res);
        Console.ReadKey();
    }
}