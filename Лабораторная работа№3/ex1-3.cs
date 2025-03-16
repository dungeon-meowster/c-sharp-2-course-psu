using System;

class Matrix
{
    private double[,] array;

    public Matrix(int n, int m)
    {
        array = new double[n, m];
        Console.WriteLine("Введите элементы массива " + n + "x" + m + " по строкам:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                string input = Console.ReadLine();
                if (!double.TryParse(input, out array[i, j]))
                {
                    Console.WriteLine("Неверный ввод, ставлю 0.");
                    array[i, j] = 0;
                }
            }
        }
    }

    public Matrix(int n, bool isRandom)
    {
        array = new double[n, n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i + j < n - 1)
                    array[i, j] = rand.Next(-65, 121);
                else
                    array[i, j] = rand.NextDouble() * (10.75 - (-3.5)) + (-3.5);
            }
        }
    }

    public Matrix(int n)
    {
        array = new double[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (j < i) array[i, j] = 0;
                else array[i, j] = 15 - j + i;
    }

    // Метод для задания 2
    public int GetMaxDebtBank()
    {
        int m = array.GetLength(1);
        double[] totalDebts = new double[m];
        for (int i = 0; i < m; i++)
        {
            double sum = 0;
            for (int j = 0; j < m; j++)
                sum += array[i, j];
            totalDebts[i] = sum;
        }

        int maxBank = 0;
        for (int i = 1; i < m; i++)
            if (totalDebts[i] > totalDebts[maxBank])
                maxBank = i;

        return maxBank;
    }

    // Перегрузка ToString
    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                result += $"{array[i, j],8:F2}";
            result += "\n";
        }
        return result;
    }

    // Перегрузка операторов для задания 3
    public static Matrix operator *(double k, Matrix m)
    {
        int n = m.array.GetLength(0);
        int p = m.array.GetLength(1);
        Matrix result = new Matrix(n, p);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < p; j++)
                result.array[i, j] = k * m.array[i, j];
        return result;
    }

    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        int n = m1.array.GetLength(0);
        int p = m1.array.GetLength(1);
        Matrix result = new Matrix(n, p);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < p; j++)
                result.array[i, j] = m1.array[i, j] - m2.array[i, j];
        return result;
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        int n = m1.array.GetLength(0);
        int m = m1.array.GetLength(1);
        int p = m2.array.GetLength(1);
        Matrix result = new Matrix(n, p);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < p; j++)
            {
                double sum = 0;
                for (int k = 0; k < m; k++)
                    sum += m1.array[i, k] * m2.array[k, j];
                result.array[i, j] = sum;
            }
        return result;
    }

    public Matrix Transpose()
    {
        int n = array.GetLength(0);
        int m = array.GetLength(1);
        Matrix result = new Matrix(m, n);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                result.array[j, i] = array[i, j];
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Задание 1
        Console.WriteLine("Первый массив (ввод с клавиатуры):");
        Console.Write("Введите число строк (n): ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Введите число столбцов (m): ");
        int m1 = int.Parse(Console.ReadLine());
        Matrix matrix1 = new Matrix(n1, m1);
        Console.WriteLine(matrix1);

        Console.WriteLine("Второй массив (случайные числа):");
        Console.Write("Введите размер матрицы (n): ");
        int n2 = int.Parse(Console.ReadLine());
        Matrix matrix2 = new Matrix(n2, true);
        Console.WriteLine(matrix2);

        Console.WriteLine("Третий массив (по шаблону):");
        Console.Write("Введите размер матрицы (n): ");
        int n3 = int.Parse(Console.ReadLine());
        Matrix matrix3 = new Matrix(n3);
        Console.WriteLine(matrix3);

        // Задание 2
        Console.WriteLine("\nЗадание 2: Банк с максимальным долгом");
        Console.Write("Введите число банков (m): ");
        int mDebt = int.Parse(Console.ReadLine());
        Matrix debts = new Matrix(mDebt, mDebt);
        Console.WriteLine("Матрица долгов:");
        Console.WriteLine(debts);
        int maxDebtBank = debts.GetMaxDebtBank();
        Console.WriteLine($"Банк с максимальным долгом: {maxDebtBank + 1} (нумерация с 1)");

        // Задание 3: 2*A - B^T * C
        Console.WriteLine("\nЗадание 3: 2*A - B^T * C");

        Console.WriteLine("Матрица A:");
        Console.Write("Введите число строк (n): ");
        int nA = int.Parse(Console.ReadLine());
        Console.Write("Введите число столбцов (m): ");
        int mA = int.Parse(Console.ReadLine());
        Matrix A = new Matrix(nA, mA);
        Console.WriteLine(A);

        Console.WriteLine("Матрица B:");
        Console.Write("Введите число строк (n): ");
        int nB = int.Parse(Console.ReadLine());
        Console.Write("Введите число столбцов (m): ");
        int mB = int.Parse(Console.ReadLine());
        Matrix B = new Matrix(nB, mB);
        Console.WriteLine(B);

        Console.WriteLine("Матрица C:");
        Console.Write("Введите число строк (n): ");
        int nC = int.Parse(Console.ReadLine());
        Console.Write("Введите число столбцов (m): ");
        int mC = int.Parse(Console.ReadLine());
        Matrix C = new Matrix(nC, mC);
        Console.WriteLine(C);

        Matrix Bt = B.Transpose();
        Console.WriteLine("Матрица B^T:");
        Console.WriteLine(Bt);

        Matrix BtC = Bt * C;
        Console.WriteLine("Матрица B^T * C:");
        Console.WriteLine(BtC);

        Matrix twoA = 2 * A;
        Console.WriteLine("Матрица 2*A:");
        Console.WriteLine(twoA);

        Matrix result = twoA - BtC;
        Console.WriteLine("Результат 2*A - B^T * C:");
        Console.WriteLine(result);
    }
}