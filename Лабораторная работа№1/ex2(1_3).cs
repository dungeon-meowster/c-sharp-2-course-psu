using System;

public class Program2
{
    public static void Main()
    {
        Console.WriteLine("Задача 2 'Букву в число': ");
        Console.WriteLine("Введите символ: ");
        string input = Console.ReadLine();
        if (input.Length == 1 && char.TryParse(input, out char ex2))
        {
            int y = CharToNum(ex2);
            Console.WriteLine("Вы ввели = {0}, Результат = {1}", ex2, y);
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите один символ.");
        }
    }

    public static int CharToNum(char x)
    {
        return x - '0';
    }
}