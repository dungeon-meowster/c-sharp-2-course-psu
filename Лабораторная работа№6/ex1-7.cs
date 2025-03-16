using System;
using System.Collections.Generic;
using System.Linq;

public interface IMeowable
{
    void Meow();
}

public class Cat : IMeowable
{
    private string name;
    private int meowCount = 0;

    public Cat(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Имя кота не может быть пустым");
        this.name = name;
    }

    public void Meow()
    {
        Console.WriteLine($"{name}: мяу!");
        meowCount++;
    }

    public void Meow(int n)
    {
        if (n <= 0)
            throw new ArgumentException("Количество мяуканий должно быть положительным");
        string meows = string.Join("-", Enumerable.Repeat("мяу", n));
        Console.WriteLine($"{name}: {meows}!");
        meowCount += n;
    }

    public int GetMeowCount() => meowCount;

    public override string ToString() => $"кот: {name}";
}

public class Dog : IMeowable
{
    public void Meow() => Console.WriteLine("Гав! (пытается мяукать)");
}

public static class Funs
{
    public static void MeowsCare(IMeowable meower)
    {
        Console.Write("Введите количество мяуканий для объекта (по порядку): ");
        int count = int.Parse(Console.ReadLine());
        if (count <= 0)
            throw new ArgumentException("Количество мяуканий должно быть положительным");
        for (int i = 0; i < count; i++)
            meower.Meow();
    }
}

public interface IFraction
{
    double GetDoubleValue();
    void SetNumerator(int value);
    void SetDenominator(int value);
}

public class Fraction : ICloneable, IFraction
{
    private int numerator;
    private int denominator;
    private double? cachedDoubleValue = null;

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Знаменатель не может быть равен 0");
        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public Fraction Sum(Fraction other) => 
        new Fraction(numerator * other.denominator + other.numerator * denominator, 
                    denominator * other.denominator);
    
    public Fraction Sum(int number) => 
        new Fraction(numerator + number * denominator, denominator);

    public Fraction Minus(Fraction other) => 
        new Fraction(numerator * other.denominator - other.numerator * denominator, 
                    denominator * other.denominator);
    
    public Fraction Minus(int number) => 
        new Fraction(numerator - number * denominator, denominator);

    public Fraction Multiply(Fraction other) => 
        new Fraction(numerator * other.numerator, denominator * other.denominator);
    
    public Fraction Multiply(int number) => 
        new Fraction(numerator * number, denominator);

    public Fraction Div(Fraction other) => 
        new Fraction(numerator * other.denominator, denominator * other.numerator);
    
    public Fraction Div(int number) => 
        new Fraction(numerator, denominator * number);

    public override string ToString() => $"{numerator}/{denominator}";

    public override bool Equals(object obj)
    {
        if (obj is Fraction other)
            return numerator == other.numerator && denominator == other.denominator;
        return false;
    }

    public override int GetHashCode() => HashCode.Combine(numerator, denominator);

    public object Clone() => new Fraction(numerator, denominator);

    public double GetDoubleValue()
    {
        if (!cachedDoubleValue.HasValue)
            cachedDoubleValue = (double)numerator / denominator;
        return cachedDoubleValue.Value;
    }

    public void SetNumerator(int value)
    {
        numerator = value;
        cachedDoubleValue = null;
    }

    public void SetDenominator(int value)
    {
        if (value == 0)
            throw new ArgumentException("Знаменатель не может быть равен 0");
        denominator = value > 0 ? value : -value;
        numerator = value < 0 ? -numerator : numerator;
        cachedDoubleValue = null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Основной запуск для кота
        Console.WriteLine("Задание 1.1: Кот");
        Cat barsik = new Cat("Барсик");
        Console.WriteLine(barsik);
        barsik.Meow();
        barsik.Meow(3);

        Console.WriteLine("\nЗадание 1.2: Интерфейс Мяуканье");
        Console.Write("Введите количество мяукающих объектов: ");
        int meowableCount = int.Parse(Console.ReadLine());
        if (meowableCount <= 0)
            throw new ArgumentException("Количество объектов должно быть положительным");

        List<IMeowable> meowers = new List<IMeowable>();
        for (int i = 0; i < meowableCount; i++)
        {
            Console.Write($"Введите тип объекта {i + 1} (1 - Кот, 2 - Собака): ");
            int type = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                Console.Write("Введите имя кота: ");
                string catName = Console.ReadLine();
                meowers.Add(new Cat(catName));
            }
            else if (type == 2)
            {
                meowers.Add(new Dog());
            }
            else
            {
                Console.WriteLine("Неверный тип, добавлена собака по умолчанию");
                meowers.Add(new Dog());
            }
        }

        foreach (var m in meowers)
            Funs.MeowsCare(m);

        Console.WriteLine("\nЗадание 1.3: Подсчет мяуканий");
        Console.Write("Введите имя кота для подсчета мяуканий: ");
        string murkaName = Console.ReadLine();
        Cat murka = new Cat(murkaName);
        Funs.MeowsCare(murka);
        Console.WriteLine($"Кот мяукал {murka.GetMeowCount()} раз");

        // Работа с дробями
        Console.WriteLine("\nЗадание 2.1: Дроби");
        Console.Write("Введите количество дробей для создания: ");
        int fractionCount = int.Parse(Console.ReadLine());
        if (fractionCount <= 0)
            throw new ArgumentException("Количество дробей должно быть положительным");

        List<Fraction> fractions = new List<Fraction>();
        for (int i = 0; i < fractionCount; i++)
        {
            Console.Write($"Введите числитель дроби {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write($"Введите знаменатель дроби {i + 1}: ");
            int den = int.Parse(Console.ReadLine());
            fractions.Add(new Fraction(num,  den));
        }

        if (fractions.Count >= 1)
        {
            Fraction f1 = fractions[0];
            Console.Write("Введите целое число для сложения с первой дробью: ");
            int sumNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"{f1} + {sumNum} = {f1.Sum(sumNum)}");

            if (fractions.Count >= 2)
            {
                Fraction f2 = fractions[1];
                Console.WriteLine($"{f1} - {f2} = {f1.Minus(f2)}");
                Console.WriteLine($"{f1} * {f2} = {f1.Multiply(f2)}");

                if (fractions.Count >= 3)
                {
                    Fraction f3 = fractions[2];
                    Console.WriteLine($"{f2} / {f3} = {f2.Div(f3)}");
                    Fraction result = f1.Sum(f2).Div(f3).Minus(5);
                    Console.WriteLine($"{f1}.Sum({f2}).Div({f3}).Minus(5) = {result}");
                }
            }
        }

        if (fractions.Count >= 2)
        {
            Console.WriteLine("\nЗадание 2.2: Сравнение дробей");
            Console.WriteLine($"{fractions[0]} == {fractions[1]}: {fractions[0].Equals(fractions[1])}");
        }

        if (fractions.Count >= 1)
        {
            Console.WriteLine("\nЗадание 2.3: Клонирование");
            Fraction clone = (Fraction)fractions[0].Clone();
            Console.WriteLine($"Клон {fractions[0]} = {clone}");
        }

        if (fractions.Count >= 1)
        {
            Console.WriteLine("\nЗадание 2.4: Шаблоны");
            Console.WriteLine($"Вещественное значение {fractions[0]} = {fractions[0].GetDoubleValue()}");
        }
    }
}