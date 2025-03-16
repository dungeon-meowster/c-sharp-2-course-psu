using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 15 'Правый треугольник': ");
        Console.WriteLine("Введите целочисленное число: ");
        int ex15 = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.rightTriangle(ex15);
        Console.WriteLine(" ");
    }

    public void rightTriangle(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}