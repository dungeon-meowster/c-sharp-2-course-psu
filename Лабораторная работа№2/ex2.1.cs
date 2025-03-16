using System;

class RightTriangle
{
    private double a;
    private double b ; 

    public double A
    {
        get { return a; }
        set { if(value > 0) a = value; else a = 1;} 
    }

    public double B
    {
        get { return b; }
        set { if (value > 0) b = value; else b = 1; }
    }

    public RightTriangle()
    {
        a = 1;
        b = 1;
    }

    public RightTriangle(double a, double b)
    {
        A = a;
        B = b;}

    public double GetArea()
    {
        return 0.5 * a * b;}

    public override string ToString()
    {
        return $"Прямоугольный треугольник: катет a = {a}, катет b = {b}, площадь = {GetArea()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // тестируем конструктор без параметров
        Console.WriteLine("Создаём треугольник по умолчанию:");
        RightTriangle triangle1 = new RightTriangle();
        Console.WriteLine(triangle1);

        //вводим данные для второго треугольника
        Console.WriteLine("\nСоздаём треугольник с вашими данными:");
        Console.Write("Введите длину первого катета (a): ");
        string inputA = Console.ReadLine();
        Console.Write("Введите длину второго катета (b): ");
        string inputB = Console.ReadLine();

        double a, b;
        if (!double.TryParse(inputA, out a) || !double.TryParse(inputB, out b))
        {
            Console.WriteLine("Вы ввели что-то не то, ставлю катеты по умолчанию (1 и 1).");
            a = 1;
            b = 1;
        }

        RightTriangle triangle2 = new RightTriangle(a, b);
        Console.WriteLine("Ваш треугольник: " + triangle2);

        Console.WriteLine("Площадь вашего треугольника: " + triangle2.GetArea());
    }
}