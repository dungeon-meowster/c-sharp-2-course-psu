using System;
public class Program
{
    public double fraction(double x)
    {
        double y;
        y = x % 1;
        Console.WriteLine("Вы ввели = {0}, Результат = {1}", x, y);
        return y;   
    }

    public static void Main()
    {
        bool flag = true;
        Program pr = new Program();
        Console.WriteLine("Задача 1 'Дробная часть': ");
        while (flag) {
            Console.Write("Введите вещественое число: ");
            string x;
            x = Console.ReadLine();
            double ex1;
            if (double.TryParse(x, out ex1))
            {
                ex1 = double.Parse(x);
                pr.fraction(ex1);
                Console.WriteLine(" ");
                break;
            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
            }
        }
    }
}