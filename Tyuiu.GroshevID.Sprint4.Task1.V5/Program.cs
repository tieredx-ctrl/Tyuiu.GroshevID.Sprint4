using Tyuiu.GroshevID.Sprint4.Task1.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Грошев И. Д. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Грошев Илья Дмитриевич | РППб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный         *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 5 до 9 подсчитать сумму четных   *");
        Console.WriteLine("* элементов массива. С клавиатуры: 9, 6, 6, 9, 7, 8, 5, 9, 6, 6, 8, 6, 8, *");
        Console.WriteLine("* 6, 7                                                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int len;
        Console.Write("Введите количество элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[len];

        for (int i = 0; i < len; i++)
        {
            Console.Write("Введите значение " + i + " элемента массива: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();

        Console.WriteLine("Массив:");
        for (int i = 0; i < len; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(array);

        Console.WriteLine(res);
        Console.ReadKey();
    }
}