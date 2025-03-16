using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 13 'Длина числа': ");
        Console.WriteLine("Введите целочисленное число: ");
        long ex13 = long.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.numLen(ex13);
        Console.WriteLine(" ");
    }

    public int numLen(long x)
    {
        int count = 0;
        if (x == 0) count = 1; // Коррекция для случая 0
        while (x > 0)
        {
            x /= 10;
            count++;
        }
        Console.WriteLine("Результат = {0}", count);
        return count;
    }
}