using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 17 'Поиск максимального': ");
        Console.WriteLine("Введите массив целочисленных чисел через ПРОБЕЛ: ");
        int[] ex17_arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Program pr = new Program();
        pr.maxAbs(ex17_arr);
        Console.WriteLine(" ");
    }

    public int maxAbs(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > Math.Abs(max)) max = arr[i];
        }
        Console.WriteLine("Результат = {0}", max);
        return max;
    }
}