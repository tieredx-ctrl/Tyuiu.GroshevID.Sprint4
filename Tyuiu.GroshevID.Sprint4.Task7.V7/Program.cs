using Tyuiu.GroshevID.Sprint4.Task7.V7.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = 4;
        int m = 2;
        int[,] mtrx = new int[n, m];

        string value = "31415926";

        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Грошев И. Д. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Грошев Илья Дмитриевич | РППб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр 31415926. Преобразуйте ее в матрицу   *");
        Console.WriteLine("* 4 на 2 и подсчитайте количество нечетных чисел в матрице.               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int index = 0;

        Console.WriteLine("\nМассив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{value[index]} \t");
                index++;
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(n, m, value);

        Console.WriteLine("Количество нечётных элементов = " + res);

        Console.ReadKey();
    }
}