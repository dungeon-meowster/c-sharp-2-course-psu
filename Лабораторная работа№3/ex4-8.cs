using System;
using System.IO ;
using System.Xml.Serialization;
using System.Collections.Generic;

public class FileTasks
{
    // Метод для заполнения бинарного файла случайными числами (Задание 4)
    public static void FillBinaryFile(string fileName , int count) {
        Random rand = new Random();
        using (BinaryWriter writer = new BinaryWriter(File.Open(fileName , FileMode.Create)))
        {
            for (int i = 0; i < count; i++)
            {
                writer.Write(rand.Next(-100 , 101)); // случайные числа от -100 до 100
            }
        }
        Console.WriteLine($"Бинарный файл {fileName} заполнен {count} случайными числами.");
    }

    // Задание 4: Подсчитать количество пар противоположных чисел
    public static int CountOppositePairs(string fileName) {
        List<int> numbers = new List<int>();
        using (BinaryReader reader = new BinaryReader(File.Open(fileName , FileMode.Open)))
        {
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                numbers.Add(reader.ReadInt32());
            }
        }

        int pairs = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (numbers[i] == -numbers[j]) pairs++;
            }
        }
        return pairs ;
    }

    // Структура для багажа (Задание 5)
    public struct Luggage
    {
        public string Name ;
        public double Weight;

        public Luggage(string name , double weight) {
            Name = name ;
            Weight = weight;
        }
    }

    // Метод для заполнения бинарного файла структурами (Задание 5)
    public static void FillLuggageFile(string fileName , int count) {
        Random rand = new Random();
        string[] names = {"Чемодан" , "Сумка" , "Коробка" , "Рюкзак"};
        Luggage[] luggages = new Luggage[count];
        for (int i = 0; i < count; i++)
        {
            luggages[i] = new Luggage(names[rand.Next(names.Length)] , rand.NextDouble() * 50); // вес от 0 до 50
        }

        // XML-сериализация в отдельный файл
        XmlSerializer serializer = new XmlSerializer(typeof(Luggage[]));
        using (FileStream fs = new FileStream("luggage.xml" , FileMode.Create))
        {
            serializer.Serialize(fs , luggages);
        }

        // Запись в бинарный файл
        using (BinaryWriter writer = new BinaryWriter(File.Open(fileName , FileMode.Create)))
        {
            foreach (var luggage in luggages)
            {
                writer.Write(luggage.Name);
                writer.Write(luggage.Weight);
            }
        }
        Console.WriteLine($"Бинарный файл {fileName} заполнен {count} элементами багажа.");
    }

    // Задание 5: Разница между максимальным и минимальным весом багажа
    public static double GetWeightDifference(string fileName)
    {
        List<double> weights = new List<double> () ;
        using (BinaryReader reader = new BinaryReader(File.Open(fileName , FileMode.Open)))
        {
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                reader.ReadString();
                weights.Add(reader.ReadDouble()); 
            }
        }

        if (weights.Count == 0) return 0 ;
        double maxWeight = weights[0];
        double minWeight = weights[0];
        foreach (var weight in weights)
        {
            if (weight > maxWeight) maxWeight = weight ;
            if (weight < minWeight) minWeight = weight ;
        }
        return maxWeight - minWeight ;
    }

    // Метод для заполнения текстового файла числами по одному в строке (Задание 6)
    public static void FillTextFile(string fileName , int count) {
        Random rand = new Random();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            for (int i = 0; i < count; i++)
            {
                writer.WriteLine(rand.Next(-50 , 51)); 
            }
        }
        Console.WriteLine($"Текстовый файл {fileName} заполнен {count} числами.");
    }

    // Задание 6: Проверка на отсутствие нуля
    public static bool HasNoZero(string fileName) {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (int.Parse(line) == 0) return false ;
            }
        }
        return true ;
    }

    // Метод для заполнения текстового файла числами по несколько в строке (Задание 7)
    public static void FillMultiNumberTextFile(string fileName , int lines , int numbersPerLine) {
        Random rand = new Random();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < numbersPerLine; j++)
                {
                    writer.Write(rand.Next(-100 , 101) + " ");
                }
                writer.WriteLine();
            }
        }
        Console.WriteLine($"Текстовый файл {fileName} заполнен {lines} строками по {numbersPerLine} чисел.");
    }

    // Задание 7: Максимальный элемент
    public static int GetMaxElement(string fileName) {
        int max = int.MinValue ;
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] numbers = line.Split(' ' , StringSplitOptions.RemoveEmptyEntries);
                foreach (var num in numbers)
                {
                    int value = int.Parse(num);
                    if (value > max) max = value ;
                }
            }
        }
        return max ;
    }

    // Задание 8: Переписать строки, оканчивающиеся на заданный символ
    public static void CopyLinesEndingWith(string inputFile , string outputFile , char endChar)
    {
        using (StreamReader reader = new StreamReader(inputFile))
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.EndsWith(endChar.ToString())) writer.WriteLine(line);
            }
        }
        Console.WriteLine($"Строки, оканчивающиеся на '{endChar}', переписаны в {outputFile}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Задание 4
        Console.WriteLine("Задание 4: Подсчитать количество пар противоположных чисел");
        Console.Write("Введите количество чисел для файла: ") ;
        int count4 = int.Parse(Console.ReadLine());
        FileTasks.FillBinaryFile("numbers.bin" , count4);
        int pairs = FileTasks.CountOppositePairs("numbers.bin");
        Console.WriteLine($"Количество пар противоположных чисел: {pairs}");

        // Задание 5
        Console.WriteLine("\nЗадание 5: Разница между макс и мин весом багажа");
        Console.Write("Введите количество единиц багажа: ") ;
        int count5 = int.Parse(Console.ReadLine());
        FileTasks.FillLuggageFile("luggage.bin" , count5);
        double diff = FileTasks.GetWeightDifference("luggage.bin");
        Console.WriteLine($"Разница между максимальным и минимальным весом: {diff:F2}");

        // Задание 6
        Console.WriteLine("\nЗадание 6: Проверка на отсутствие нуля");
        Console.Write("Введите количество чисел для файла: ") ;
        int count6 = int.Parse(Console.ReadLine());
        FileTasks.FillTextFile("numbers.txt" , count6);
        bool noZero = FileTasks.HasNoZero("numbers.txt");
        Console.WriteLine($"Файл не содержит нуля: {noZero}");

        // Задание 7
        Console.WriteLine("\nЗадание 7: Максимальный элемент");
        Console.Write("Введите количество строк: ") ;
        int lines7 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество чисел в строке: ") ;
        int numsPerLine7 = int.Parse(Console.ReadLine());
        FileTasks.FillMultiNumberTextFile("multi_numbers.txt" , lines7 , numsPerLine7);
        int max = FileTasks.GetMaxElement("multi_numbers.txt");
        Console.WriteLine($"Максимальный элемент: {max}");

        // Задание 8
        Console.WriteLine("\nЗадание 8: Строки, оканчивающиеся на символ");
        Console.WriteLine("Создайте файл text.txt с текстом (например, вручную) и нажмите Enter.") ;
        Console.ReadLine();
        Console.Write("Введите символ для фильтрации строк: ") ;
        char endChar = Console.ReadLine()[0];
        FileTasks.CopyLinesEndingWith("text.txt" , "filtered_text.txt" , endChar);
    }
}