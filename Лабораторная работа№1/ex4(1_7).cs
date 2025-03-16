using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 4 'Диапазон': ");
        Console.WriteLine("Введите два целочисленных числа: ");
        int ex4_a = int.Parse(Console.ReadLine());
        int ex4_b = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите целочисленное число num: ");
        int ex4_num = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.IsInRange(ex4_a, ex4_b, ex4_num);
        Console.WriteLine(" ");
    }

    public bool IsInRange(int a, int b, int num)
    {
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        bool y = (num >= min && num <= max);
        Console.WriteLine("Вы ввели = {0}, в диапазоне от {1} до {2}, Результат = {3}", num, min, max, y);
        return y;
    }
}