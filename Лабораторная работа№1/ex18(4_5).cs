using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 18 'Добавление массива в массив': ");
        Console.WriteLine("Введите массив целочисленных чисел через ПРОБЕЛ: ");
        int[] ex18_arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Console.WriteLine("Введите массив целочисленных чисел для вставки через ПРОБЕЛ: ");
        int[] ex18_ins = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Console.WriteLine("Введите позицию для вставки: ");
        int ex18_pos = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.add(ex18_arr, ex18_ins, ex18_pos);
        Console.WriteLine(" ");
    }

    public int[] add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];
        Array.Copy(arr, 0, result, 0, pos);
        Array.Copy(ins, 0, result, pos, ins.Length);
        Array.Copy(arr, pos, result, pos + ins.Length, arr.Length - pos);
        Console.Write("Результат = ");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
        return result;
    }
}