using System;

public class Program
{
    public static void Main()
    {
        bool flag = true;
        Program pr = new Program();
        while (flag) {
            Console.WriteLine("Введите номер задачи (1-20): ");
            string x;
            x = Console.ReadLine();
            switch(x)
            {
                case "1":
                {
                    Console.WriteLine("Задача 1 'Дробная часть': ");
                    Console.WriteLine("Введите вещественое число: ");
                    double ex1;
                    ex1 = double.Parse(Console.ReadLine());
                    pr.fraction(ex1);
                    Console.WriteLine(" ");
                    break;
                }
                case "2":
                {
                    Console.WriteLine("Задача 2 'Букву в число': ");
                    Console.WriteLine("Введите символ: ");
                    char ex2;
                    ex2 = char.Parse(Console.ReadLine());
                    pr.charToNum(ex2);
                    Console.WriteLine(" ");
                    break;
                }
                case "3":
                {
                    Console.WriteLine("Задача 3 'Двузначное': ");
                    Console.WriteLine("Введите целочисленное число: ");
                    int ex3;
                    ex3 = int.Parse(Console.ReadLine());
                    pr.Is2Digits(ex3);
                    Console.WriteLine(" ");
                    break;
                }
                case "4":
                {
                    Console.WriteLine("Задача 4 'Диапазон': ");
                    Console.WriteLine("Введите два целочисленных числа: ");
                    int ex4_a, ex4_b, ex4_num;
                    ex4_a = int.Parse(Console.ReadLine());
                    ex4_b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите целочисленное число num: ");
                    ex4_num = int.Parse(Console.ReadLine());
                    pr.IsInRange(ex4_a, ex4_b, ex4_num);
                    Console.WriteLine(" ");
                    break;
                }
                case "5":
                {
                    Console.WriteLine("Задача 5 'Равенство': ");
                    Console.WriteLine("Введите три целочисленных числа: ");
                    int ex5_a, ex5_b, ex5_c;
                    ex5_a = int.Parse(Console.ReadLine());
                    ex5_b = int.Parse(Console.ReadLine());
                    ex5_c = int.Parse(Console.ReadLine());
                    pr.isEqual(ex5_a, ex5_b, ex5_c);
                    Console.WriteLine(" ");
                    break;
                }
                case "6":
                {
                    Console.WriteLine("Задача 6 'Модуль числа': ");
                    Console.WriteLine("Введите целочисленное число: ");
                    int ex6;
                    ex6 = int.Parse(Console.ReadLine());
                    pr.abs(ex6);
                    Console.WriteLine(" ");
                    break;
                }
                case "7":
                {
                    Console.WriteLine("Задача 7 'Тридцать пять': ");
                    Console.WriteLine("Введите целочисленное число: ");
                    int ex7;
                    ex7 = int.Parse(Console.ReadLine());
                    pr.is35(ex7);
                    Console.WriteLine(" ");
                    break;
                }
                case "8":
                {
                    Console.WriteLine("Задача 8 'Тройной максимум': ");
                    Console.WriteLine("Введите три целочисленных числа: ");
                    int ex8_a, ex8_b, ex8_c;
                    ex8_a = int.Parse(Console.ReadLine());
                    ex8_b = int.Parse(Console.ReadLine());
                    ex8_c = int.Parse(Console.ReadLine());
                    pr.max3(ex8_a, ex8_b, ex8_c);
                    Console.WriteLine(" ");
                    break;
                }
                case "9":
                {
                    Console.WriteLine("Задача 9 'Двойная сумма': ");
                    Console.WriteLine("Введите два целочисленных числа: ");
                    int ex9_a, ex9_b;
                    ex9_a = int.Parse(Console.ReadLine());
                    ex9_b = int.Parse(Console.ReadLine());
                    pr.sum2(ex9_a, ex9_b);
                    Console.WriteLine(" ");
                    break;
                }
                case "10":
                {
                    Console.WriteLine("Задача 10 'День недели': ");
                    Console.WriteLine("Введите день недели (1-7): ");
                    int ex10;
                    ex10 = int.Parse(Console.ReadLine());
                    pr.day(ex10);
                    Console.WriteLine(" ");
                    break;
                }
                case "11":
                {
                    Console.WriteLine("Задача 11 'Числа подряд': ");
                    Console.WriteLine("Введите целочисленное число: ");
                    int ex11;
                    ex11 = int.Parse(Console.ReadLine());
                    pr.listNums(ex11);
                    Console.WriteLine(" ");
                    break;
                }
                case "12":
                {
                    Console.WriteLine("Задача 12 'Четные числа': ");
                    Console.WriteLine("Введите целочисленное число: ");
                    int ex12;
                    ex12 = int.Parse(Console.ReadLine());
                    pr.chet(ex12);
                    Console.WriteLine(" ");
                    break;
                }
                case "13":
                {
                    Console.WriteLine("Задача 13 'Длина числа': ");
                    Console.WriteLine("Введите целочисленное число: ");
                    long ex13;
                    ex13 = long.Parse(Console.ReadLine());
                    pr.numLen(ex13);
                    Console.WriteLine(" ");
                    break;
                }
                case "14":
                {
                    Console.WriteLine("Задача 14 'Квадрат': ");
                    Console.WriteLine("Введите целочисленное число: ");
                    int ex14;
                    ex14 = int.Parse(Console.ReadLine());
                    pr.square(ex14);
                    Console.WriteLine(" ");
                    break;
                }
                case "15":
                {
                    Console.WriteLine("Задача 15 'Правый треугольник': ");
                    Console.WriteLine("Введите целочисленное число: ");
                    int ex15;
                    ex15 = int.Parse(Console.ReadLine());
                    pr.rightTriangle(ex15);
                    Console.WriteLine(" ");
                    break;
                }
                case "16":
                {
                    Console.WriteLine("Задача 16 'Поиск первого значения': ");
                    Console.WriteLine("Введите массив целочисленных чисел через ПРОБЕЛ: ");
                    int[] ex16_arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    Console.WriteLine("Введите целочисленное число для поиска: ");
                    int ex16_x = int.Parse(Console.ReadLine());
                    pr.findFirst(ex16_arr, ex16_x);
                    Console.WriteLine(" ");
                    break;
                }
                case "17":
                {
                    Console.WriteLine("Задача 17 'Поиск максимального': ");
                    Console.WriteLine("Введите массив целочисленных чисел через ПРОБЕЛ: ");
                    int[] ex17_arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    pr.maxAbs(ex17_arr);
                    Console.WriteLine(" ");
                    break;
                }
                case "18":
                {
                    Console.WriteLine("Задача 18 'Добавление массива в массив': ");
                    Console.WriteLine("Введите массив целочисленных чисел через ПРОБЕЛ: ");
                    int[] ex18_arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    Console.WriteLine("Введите массив целочисленных чисел для вставки через ПРОБЕЛ: ");
                    int[] ex18_ins = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    Console.WriteLine("Введите позицию для вставки: ");
                    int ex18_pos = int.Parse(Console.ReadLine());
                    pr.add(ex18_arr, ex18_ins, ex18_pos);
                    Console.WriteLine(" ");
                    break;
                }
                case "19":
                {
                    Console.WriteLine("Задача 19 'Возвратный реверс': ");
                    Console.WriteLine("Введите массив целочисленных чисел через ПРОБЕЛ: ");
                    int[] ex19_arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    pr.reverseBack(ex19_arr);
                    Console.WriteLine(" ");
                    break;
                }
                case "20":
                {
                    Console.WriteLine("Задача 20 'Все вхождения': ");
                    Console.WriteLine("Введите массив целочисленных чисел через ПРОБЕЛ: ");
                    int[] ex20_arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    Console.WriteLine("Введите целочисленное число для поиска: ");
                    int ex20_x = int.Parse(Console.ReadLine());
                    pr.findAll(ex20_arr, ex20_x);
                    Console.WriteLine(" ");
                    break;
                }
                default: 
                {
                    Console.WriteLine("----конец выполнения программы----"); 
                    flag = false; 
                    break;
                }
            }
        }
    }

    public double fraction(double x)
    {
        double y;
        y = x % 1;
        Console.WriteLine("Вы ввели = {0}, Результат = {1}", x, y);
        return y;   
    }
    
    public int charToNum(char x)
    {
        int y = x - 48;
        Console.WriteLine("Вы ввели = {0}, Результат = {1}", x, y);
        return y;
    }
    
    public bool Is2Digits(int x)
    {
        bool y = (x.ToString().Length == 2);
        Console.WriteLine("Вы ввели = {0}, Результат = {1}", x, y);
        return y;
    }
    
    public bool IsInRange(int a, int b, int num)
    {
        int min, max;
        if (a > b) 
        {
            max = a;
            min = b;
        }
        else
        {
            max = b;
            min = a;
        }
        bool y = (num >= min && num <= max);
        Console.WriteLine("Вы ввели = {0}, в диапозоне от {1} до {2} Результат = {3}", num, min, max, y);
        return y;
    }

    public bool isEqual(int a, int b, int c)
    {
        bool y = (a == b && b == c);
        Console.WriteLine("Вы ввели = {0}, {1}, {2}, Результат = {3}", a, b, c, y);
        return y;
    }

    public int abs(int x)
    {
        int y = Math.Abs(x);
        Console.WriteLine("Вы ввели = {0}, Результат = {1}", x, y);
        return y;
    }

    public bool is35(int x)
    {
        bool result = (x % 3 == 0 || x % 5 == 0) && !(x % 3 == 0 && x % 5 == 0);
        Console.WriteLine("Вы ввели = {0}, Результат = {1}", x, result);
        return result;
    }

    public int max3(int x, int y, int z)
    {
        int max = x;
        if (y > max) max = y;
        if (z > max) max = z;
        Console.WriteLine("Вы ввели = {0}, {1}, {2}, Результат = {3}", x, y, z, max);
        return max;
    }

    public int sum2(int x, int y)
    {
        int sum = x + y;
        if (sum >= 10 && sum <= 19) sum = 20;
        Console.WriteLine("Вы ввели = {0}, {1}, Результат = {2}", x, y, sum);
        return sum;
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

    public string chet(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i++)
        {
            if (i % 2 == 0) result += i + " ";
        }
        Console.WriteLine("Вы ввели = {0}, Результат = {1}", x, result);
        return result;
    }
    public int numLen(long x)
    {
        int count = 0;
        while (x > 0)
        {
            x /= 10;
            count++;
        }
        Console.WriteLine("Результат = {0}",count);
        return count;
    }
    
    public void square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    public void rightTriangle(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    public int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) 
            {
              Console.WriteLine("Результат = {0}", i);
              return i;
            }
        }
        Console.WriteLine("Результат = {0}", -1);
        return -1;
    }

    public int maxAbs(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > Math.Abs(max)) max = arr[i];
        }
        Console.WriteLine("Результат = {0}", max);
        return max;
    }

    public int[] add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];
        Array.Copy(arr, 0, result, 0, pos);
        Array.Copy(ins, 0, result, pos, ins.Length);
        Array.Copy(arr, pos, result, pos + ins.Length, arr.Length - pos);
        Console.WriteLine(result);
        Console.Write("Результат = ");
        for (int i = 0; i < arr.Length + ins.Length; i++)
        {
            Console.Write(result[i]);
        } 
        Console.WriteLine();
        return result;
    }
    
    public int[] reverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }
        Console.WriteLine("Результат = {0}", string.Join(", ", result));
        return result;
    }

    public int[] findAll(int[] arr, int x)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) count++;
        }
        int[] result = new int[count];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) result[j++] = i;
        }
        Console.WriteLine("Результат = {0}", string.Join(", ", result));
        return result;
    }
}
