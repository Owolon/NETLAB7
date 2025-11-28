using System;
using System.Collections.Generic;

namespace LabTasks
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Выберите задание:");
                Console.WriteLine("1 — Количество строк в двумерном массиве, упорядоченных по возрастанию");
                Console.WriteLine("2 — Вычисление выражений по формулам");
                Console.WriteLine("3 — Вычисление u, v и k (ref, out, in)");
                Console.WriteLine("4 — Нахождение номера минимального элемента массива");
                Console.WriteLine("5 — Числа из диапазона [a,b] с заданной суммой цифр");
                Console.WriteLine("6 - Найти площадь треугольника по координатам трёх точек.");

                Console.WriteLine("0 — Выход");
                Console.Write("\nВаш выбор: ");
                int choice = ReadInt();

                switch (choice)
                {
                    case 1: Task1(); break;
                    case 2: Task2_Formulas(); break;
                    case 3: Task3_UVK(); break;
                    case 4: Task4_MinIndex(); break;
                    case 5: Task5_DigitSum(); break;
                    case 6: Task6_TriangleArea(); break;
                    case 0: return;
                    default: Console.WriteLine("Нет такого задания."); break;
                }
            }
        }

        static int ReadInt()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int x))
                    return x;
                Console.Write("Ошибка! Введите целое число: ");
            }
        }

        static double ReadDouble()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double x))
                    return x;
                Console.Write("Ошибка! Введите число: ");
            }
        }

        static void Task1()
        {
            Console.Write("Введите количество строк: ");
            int n = ReadInt();

            Console.Write("Введите количество столбцов: ");
            int m = ReadInt();

            int[,] arr = new int[n, m];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"[{i},{j}] = ");
                    arr[i, j] = ReadInt();
                }

            List<int> increasingRows = GetIncreasingRows(arr);

            Console.WriteLine($"\nКоличество строк, в которых элементы строго возрастают: {increasingRows.Count}");

            if (increasingRows.Count > 0)
            {
                Console.WriteLine("\nСтроки, где элементы возрастают:");

                foreach (int row in increasingRows)
                {
                    Console.Write($"Строка {row+1}: ");
                    for (int j = 0; j < arr.GetLength(1); j++)
                        Console.Write(arr[row, j] + " ");

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Таких строк нет.");
            }
        }

        static List<int> GetIncreasingRows(int[,] arr)
        {
            List<int> rows = new List<int>();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                bool ok = true;

                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] <= arr[i, j - 1])
                    {
                        ok = false;
                        break;
                    }
                }

                if (ok)
                    rows.Add(i);
            }

            return rows;
        }

        static void Task2_Formulas()
        {
            Console.WriteLine("Введите x (первый аргумент): ");
            double x = ReadDouble();

            Console.WriteLine("Введите y (второй аргумент): ");
            double y = ReadDouble();

            Console.WriteLine("Введите z (третий аргумент): ");
            double z = ReadDouble();

            double a = CalculateA(x, y);
            double b = CalculateB(z);

            Console.WriteLine("\nРезультаты вычислений:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }

        static double CalculateA(double x, double y)
        {
            return 2 * Math.Pow(Math.Cos(x - (Math.PI / 6)), 4)
                   / (0.5 + Math.Pow(Math.Sin(y), 2));
        }

        static double CalculateB(double z)
        {
            return 1 + Math.Pow(z, 2) / (3 + (Math.Pow(z, 2) / 5));
        }

        static void Task3_UVK()
        {
            Console.Write("Введите a: ");
            double a = ReadDouble();
            Console.Write("Введите b: ");
            double b = ReadDouble();

            double u = 0, v = 0, k = 0;

            ComputeUVK(in a, in b, ref u, out v, out k);

            Console.WriteLine($"\nРезультаты:");
            Console.WriteLine($"u = {u}");
            Console.WriteLine($"v = {v}");
            Console.WriteLine($"k = {k}");
        }

        static void ComputeUVK(in double a, in double b, ref double u, out double v, out double k)
        {
            u = Math.Max(a, b - a);
            v = Math.Min(a * b, a + b);
            k = Math.Min(u + v * 2, 3.14);
        }

        static void Task4_MinIndex()
        {
            Console.Write("Введите длину массива: ");
            int n = ReadInt();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"[{i}] = ");
                arr[i] = ReadInt();
            }

            int index = IndexOfMin(arr);
            Console.WriteLine($"\nМинимальный элемент = {arr[index]}, индекс = {index}");
        }

        static int IndexOfMin(int[] arr)
        {
            int min = arr[0];
            int pos = 0;

            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min)
                {
                    min = arr[i];
                    pos = i;
                }

            return pos;
        }

        static void Task5_DigitSum()
        {
            Console.Write("Введите a: ");
            int a = ReadInt();

            Console.Write("Введите b: ");
            int b = ReadInt();

            Console.Write("Введите требуемую сумму цифр: ");
            int sum = ReadInt();

            int[] result = Array.Empty<int>();
            bool ok;

            FindNumbersWithDigitSum(ref a, ref b, sum, out result, out ok);

            if (!ok)
            {
                Console.WriteLine("NO");
                return;
            }

            Console.WriteLine("\nПодходящие числа:");
            foreach (int x in result)
                Console.Write(x + " ");
            Console.WriteLine();
        }

        static void FindNumbersWithDigitSum(ref int a, ref int b, int digitSum, out int[] result, out bool found)
        {
            if (a > b) (a, b) = (b, a);

            List<int> list = new List<int>();

            for (int x = b; x >= a; x--)
                if (SumDigits(x) == digitSum)
                    list.Add(x);

            result = list.ToArray();
            found = list.Count > 0;
        }

        static int SumDigits(int x)
        {
            x = Math.Abs(x);
            int s = 0;
            while (x > 0)
            {
                s += x % 10;
                x /= 10;
            }
            return s;
        }

        static void RAST(double x1, double y1, double x2, double y2, ref double result)
        {
            result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static double PERIMETR(
            double x1 = 0, double y1 = 0,
            double x2 = 2, double y2 = 0,
            double x3 = 1, double y3 = 2)
        {
            double a = 0, b = 0, c = 0;

            RAST(x1, y1, x2, y2, ref a);
            RAST(x2, y2, x3, y3, ref b);
            RAST(x1, y1, x3, y3, ref c);

            return a + b + c;
        }

        static void Task6_TriangleArea()
        {
            Console.WriteLine("Если хотите использовать значения по умолчанию (0,0), (2,0), (1,2), нажмите Enter.");
            Console.WriteLine("Иначе введите координаты вручную.");

            bool custom = false;

            Console.Write("Использовать свои координаты?: ");
            string ans = Console.ReadLine().Trim().ToLower();
            if (ans == "y" || ans == "yes" || ans == "да") custom = true;

            double x1, y1, x2, y2, x3, y3;

            if (custom)
            {
                Console.Write("Введите x1: "); x1 = ReadDouble();
                Console.Write("Введите y1: "); y1 = ReadDouble();

                Console.Write("Введите x2: "); x2 = ReadDouble();
                Console.Write("Введите y2: "); y2 = ReadDouble();

                Console.Write("Введите x3: "); x3 = ReadDouble();
                Console.Write("Введите y3: "); y3 = ReadDouble();
            }
            else
            {
                x1 = 0; y1 = 0;
                x2 = 2; y2 = 0;
                x3 = 1; y3 = 2;

                Console.WriteLine("\nИспользуются координаты по умолчанию:");
                Console.WriteLine("(0,0), (2,0), (1,2)");
            }

            double a = 0, b = 0, c = 0;

            RAST(x1, y1, x2, y2, ref a);
            RAST(x2, y2, x3, y3, ref b);
            RAST(x1, y1, x3, y3, ref c);

            Console.WriteLine($"\nСторона a = расстояние между точками 1 и 2: {a:F4}");
            Console.WriteLine($"Сторона b = расстояние между точками 2 и 3: {b:F4}");
            Console.WriteLine($"Сторона c = расстояние между точками 1 и 3: {c:F4}");

            double P = custom ? PERIMETR(x1, y1, x2, y2, x3, y3) : PERIMETR();

            Console.WriteLine($"\nP треугольника: {P:F4}");

            double s = P / 2.0;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"\nS треугольника: {area:F4}\n");
        }
    }
}
