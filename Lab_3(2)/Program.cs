using System;

namespace Lab_3_2_
{
    internal class Task2
    {
        public static void Main(String[] args)
        {
            PrintResults(0, 0, 3);
            PrintResults(0, 1, 2);
            PrintResults(1, 4, 1);
            PrintResults(1, 5, 8);
            PrintResults(2, 4, 4);
            PrintResults(1, 7, 3);
            PrintResults(2, -10, -7);
            PrintResults(20, 20, 4);
            PrintResults(21, 21, 15);
            PrintResults(1, 10, 8);
            PrintResults(-1, 10, 9);
            PrintResults(1, Double.NaN, 14);
        }
        public static double calSum2(double t, double n, double l)
        {
            if (t == 0 || t < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(t), t, "Invalid value");
            } else if (l < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(l), l, "Invalid value");
            } else if (n < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(n), n, "Invalid value");
            }

            double resultSum = 0;

            for(int i = 1; i <= n; i++)
            {
                for (int l_1 = 1; l_1 <= l; l_1 += 2)
                {
                    resultSum += (1 / t) * l_1;
                }
                for (int l_2 = 2; l_2 <= l; l_2 += 2)
                {
                     resultSum += (1 / Math.Sqrt(t)) * l_2;
                }
            }

            return resultSum;
        }

        static void PrintResults(double t, double n, double l)
        {
            Console.Write($"t:{t} n: {n} l: {l} result:");
            try
            {
                Console.WriteLine(calSum2(t, n, l));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("EXCEPTION! {0}", e.Message);
            }
        }
    }
}
