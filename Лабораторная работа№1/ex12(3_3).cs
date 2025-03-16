using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 12 'Четные числа': ");
        Console.WriteLine("Введите целочисленное число: ");
        int ex12 = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.chet(ex12);
        Console.WriteLine(" ");
    }

    public string chet(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i += 2)
        {
            result += i + " ";
        }
        Console.WriteLine("Вы ввели = {0}, Результат = {1}", x, result);
        return result;
    }
}