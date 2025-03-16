using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 5 'Равенство': ");
        Console.WriteLine("Введите три целочисленных числа: ");
        int ex5_a = int.Parse(Console.ReadLine());
        int ex5_b = int.Parse(Console.ReadLine());
        int ex5_c = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.isEqual(ex5_a, ex5_b, ex5_c);
        Console.WriteLine(" ");
    }

    public bool isEqual(int a, int b, int c)
    {
        bool y = (a == b && b == c);
        Console.WriteLine("Вы ввели = {0}, {1}, {2}, Результат = {3}", a, b, c, y);
        return y;
    }
}