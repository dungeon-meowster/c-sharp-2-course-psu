using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 20 'Все вхождения': ");
        Console.WriteLine("Введите массив целочисленных чисел через ПРОБЕЛ: ");
        int[] ex20_arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Console.WriteLine("Введите целочисленное число для поиска: ");
        int ex20_x = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.findAll(ex20_arr, ex20_x);
        Console.WriteLine(" ");
    }

    public int[] findAll(int[] arr, int x)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) count++;
        }
        int[] result = new int[count];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) result[j++] = i;
        }
        Console.WriteLine("Результат = {0}", string.Join(", ", result));
        return result;
    }
}