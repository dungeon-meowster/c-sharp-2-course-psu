using System;

public class Program3
{
    public static void Main()
    {
        Console.WriteLine("Задача 3 'Двузначное': ");
        Console.WriteLine("Введите целочисленное двузначное число: ");
        if (int.TryParse(Console.ReadLine(), out int ex3) && ex3 >= 10 && ex3 <= 99)
        {
            bool y = Is2Digits(ex3);
            Console.WriteLine("Вы ввели = {0}, Результат = {1}", ex3, y);
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите двузначное целое число.");
        }
    }

    public static bool Is2Digits(int x)
    {
        return x.ToString().Length == 2;
    }
}