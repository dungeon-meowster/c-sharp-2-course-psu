using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 19 'Возвратный реверс': ");
        Console.WriteLine("Введите массив целочисленных чисел через ПРОБЕЛ: ");
        int[] ex19_arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Program pr = new Program();
        pr.reverseBack(ex19_arr);
        Console.WriteLine(" ");
    }

    public int[] reverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }
        Console.WriteLine("Результат = {0}", string.Join(", ", result));
        return result;
    }
}