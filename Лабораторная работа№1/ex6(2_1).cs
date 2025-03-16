using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 6 'Модуль числа': ");
        Console.WriteLine("Введите целочисленное число: ");
        int ex6 = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.abs(ex6);
        Console.WriteLine(" ");
    }

    public int abs(int x)
    {
        int y = Math.Abs(x);
        Console.WriteLine("Вы ввели = {0}, Результат = {1}", x, y);
        return y;
    }
}