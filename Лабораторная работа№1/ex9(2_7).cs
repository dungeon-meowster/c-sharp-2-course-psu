using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 9 'Двойная сумма': ");
        Console.WriteLine("Введите два целочисленных числа: ");
        int ex9_a = int.Parse(Console.ReadLine());
        int ex9_b = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.sum2(ex9_a, ex9_b);
        Console.WriteLine(" ");
    }

    public int sum2(int x, int y)
    {
        int sum = x + y;
        if (sum >= 10 && sum <= 19) sum = 20;
        Console.WriteLine("Вы ввели = {0}, {1}, Результат = {2}", x, y, sum);
        return sum;
    }
}