using System;

class Numbers
{
    public int a;
    public int b;
    public int c;

    public Numbers(int x, int y , int z)
    {
        a = x;
        b = y;
        c = z;
    }

    public Numbers(Numbers other)
    {
        a = other.a;
        b = other.b;
        c = other.c;
    }

    public int min()
    {
        int m = a;
        if (b < m) m = b;
        if (c< m) m = c;
        return m;
    }

    public override string ToString()
    {
        return a + " " + b + " " + c;
    }
}

class Model : Numbers
{
    public Model(int width, int length, int height) : base(width, length, height)
    {}

    public Model(Model other) : base(other)
    {}

    public int area()
    {
        return a * b;}

    public int volume()
    {
        return a * b * c;
    }
}

class Program
{
    public static void Main()
    {
        //ТЕСТЫ ДЛЯ ПРОВЕРКИ ЗАДАНИЯ
        //класс
        Console.WriteLine("Введите три числа для коробки чисел:");
        Console.WriteLine("Первое число:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Второе число:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Третье число:");
        int num3 = int.Parse(Console.ReadLine());
        Numbers n1 = new Numbers(num1, num2, num3);
        Console.WriteLine("Ваши числа: " + n1.ToString());
        Console.WriteLine("Самое маленькое: " + n1.min());
        Numbers n2 = new Numbers(n1);
        Console.WriteLine("Копия чисел: " + n2.ToString());

        //дочерний класс
        Console.WriteLine("\nТеперь введите размеры модели:");
        Console.WriteLine("Ширина:");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Длина:");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Высота:");
        int height = int.Parse(Console.ReadLine());
        Model m1 = new Model(width, length, height);
        Console.WriteLine("Размеры модели: " + m1.ToString());
        Console.WriteLine("Площадь основания: " + m1.area());
        Console.WriteLine("Объем модели: " + m1.volume());
        Model m2 = new Model(m1);
        Console.WriteLine("Копия модели: " + m2.ToString());
    }
    
    
}
