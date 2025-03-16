using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 8 'Тройной максимум': ");
        Console.WriteLine("Введите три целочисленных числа: ");
        int ex8_a = int.Parse(Console.ReadLine());
        int ex8_b = int.Parse(Console.ReadLine());
        int ex8_c = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.max3(ex8_a, ex8_b, ex8_c);
        Console.WriteLine(" ");
    }

    public int max3(int x, int y, int z)
    {
        int max = x;
        if (y > max) max = y;
        if (z > max) max = z;
        Console.WriteLine("Вы ввели = {0}, {1}, {2}, Результат = {3}", x, y, z, max);
        return max;
    }
}