using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 11 'Числа подряд': ");
        Console.WriteLine("Введите целочисленное число: ");
        int ex11 = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.listNums(ex11);
        Console.WriteLine(" ");
    }

    public string listNums(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i++)
        {
            result += i + " ";
        }
        Console.WriteLine("Вы ввели = {0}, Результат = {1}", x, result);
        return result;
    }
}