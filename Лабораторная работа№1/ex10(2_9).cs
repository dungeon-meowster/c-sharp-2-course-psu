using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задача 10 'День недели': ");
        Console.WriteLine("Введите день недели (1-7): ");
        int ex10 = int.Parse(Console.ReadLine());
        Program pr = new Program();
        pr.day(ex10);
        Console.WriteLine(" ");
    }

    public string day(int x)
    {
        string result;
        switch (x)
        {
            case 1: result = "понедельник"; break;
            case 2: result = "вторник"; break;
            case 3: result = "среда"; break;
            case 4: result = "четверг"; break;
            case 5: result = "пятница"; break;
            case 6: result = "суббота"; break;
            case 7: result = "воскресенье"; break;
            default: result = "это не день недели"; break;
        }
        Console.WriteLine("Вы ввели = {0}, Результат = {1}", x, result);
        return result;
    }
}