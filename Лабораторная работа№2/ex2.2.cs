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

    public static RightTriangle operator ++(RightTriangle t)
    {
        return new RightTriangle(t.a * 2, t.b * 2);}

    public static RightTriangle operator --(RightTriangle t)
    {
        return new RightTriangle(t.a / 2, t.b / 2);}

    public static explicit operator double(RightTriangle t)
    {
        if(t.a > 0 && t.b > 0) return t.GetArea();
        return -1;
    }

    public static implicit operator bool(RightTriangle t)
    {
        return t.a > 0 && t.b > 0;}

    public static bool operator <=(RightTriangle t1, RightTriangle t2)
    {
        return t1.GetArea() <= t2.GetArea();}

    public static bool operator >=(RightTriangle t1, RightTriangle t2)
    {
        return t1.GetArea() >= t2.GetArea();}
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Создаём первый треугольник с вашими данными:");
        Console.Write("Введите длину первого катета (a): ");
        string inputA1 = Console.ReadLine();
        Console.Write("Введите длину второго катета (b): ");
        string inputB1 = Console.ReadLine();

        double a1, b1;
        if (!double.TryParse(inputA1, out a1) || !double.TryParse(inputB1, out b1))
        {
            Console.WriteLine("Вы ввели что-то не то, ставлю катеты по умолчанию (1 и 1).");
            a1 = 1;
            b1 = 1;
        }

        RightTriangle triangle1 = new RightTriangle(a1, b1);
        Console.WriteLine("Ваш первый треугольник: " + triangle1);

        Console.WriteLine("\nСоздаём второй треугольник с вашими данными:");
        Console.Write("Введите длину первого катета (a): ");
        string inputA2 = Console.ReadLine();
        Console.Write("Введите длину второго катета (b): ");
        string inputB2 = Console.ReadLine();

        double a2, b2;
        if (!double.TryParse(inputA2, out a2) || !double.TryParse(inputB2, out b2))
        {
            Console.WriteLine("Вы ввели что-то не то, ставлю катеты по умолчанию (1 и 1).");
            a2 = 1;
            b2 = 1;
        }

        RightTriangle triangle2 = new RightTriangle(a2, b2);
        Console.WriteLine("Ваш второй треугольник: " + triangle2);

        Console.WriteLine("\nУвеличиваем первый треугольник (++):");
        triangle1++;
        Console.WriteLine("Первый треугольник после ++: " + triangle1);

        Console.WriteLine("\nУменьшаем второй треугольник (--):");
        triangle2--;
        Console.WriteLine("Второй треугольник после --: " + triangle2);

        Console.WriteLine("\nПлощадь первого треугольника через приведение к double:");
        double area1 = (double)triangle1;
        Console.WriteLine("Площадь: " + area1);

        Console.WriteLine("\nПроверяем, существует ли первый треугольник:");
        bool exists1 = triangle1;
        Console.WriteLine("Существует? " + exists1);

        Console.WriteLine("\nСравниваем площади треугольников:");
        Console.WriteLine("Первый <= второго? " + (triangle1 <= triangle2));
        Console.WriteLine("Первый >= второго? " + (triangle1 >= triangle2));
    }
}