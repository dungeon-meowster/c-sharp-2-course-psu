using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 7 'Тридцать пять': ");
        Console.WriteLine("Введите целочисленное число: ");
        int ex7 = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.is35(ex7);
        Console.WriteLine(" ");
    }

    public bool is35(int x)
    {
        bool result = (x % 3 == 0 || x % 5 == 0) && !(x % 3 == 0 && x % 5 == 0);
        Console.WriteLine("Вы ввели = {0}, Результат = {1}", x, result);
        return result;
    }
}