using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 14 'Квадрат': ");
        Console.WriteLine("Введите целочисленное число: ");
        int ex14 = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.square(ex14);
        Console.WriteLine(" ");
    }

    public void square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}