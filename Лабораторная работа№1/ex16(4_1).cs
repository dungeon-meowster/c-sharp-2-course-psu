using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 16 'Поиск первого значения': ");
        Console.WriteLine("Введите массив целочисленных чисел через ПРОБЕЛ: ");
        int[] ex16_arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Console.WriteLine("Введите целочисленное число для поиска: ");
        int ex16_x = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.findFirst(ex16_arr, ex16_x);
        Console.WriteLine(" ");
    }

    public int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                Console.WriteLine("Результат = {0}", i);
                return i;
            }
        }
        Console.WriteLine("Результат = {0}", -1);
        return -1;
    }
}