using System;

namespace Lab_3
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            PrintResults(1, 0);
            PrintResults(1, 1);
            PrintResults(2, 1);
            PrintResults(1, 2);
            PrintResults(2, -10);
            PrintResults(20, 20);
            PrintResults(21, 21);
            PrintResults(1, 10);
            PrintResults(-1, 10);
            PrintResults(0, Double.MaxValue);
            PrintResults(1, Double.MaxValue);
            PrintResults(1, Double.NaN);
        }
        public static double calSum(double k, double m)
        {
            if (k < 1 || k > 30)
            {
                throw new ArgumentOutOfRangeException(nameof(k), k, "Invalid value");
            }
            else if (m < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(m), m, "Invalid value");
            }

            double resultSum = 0;

            for (int i = 1; i < k; i++)
            {
                resultSum += Math.Sqrt(m * (1 / i)) * Math.Sin(m * i);
            }

            return resultSum;
        }

        static void PrintResults(double k, double m)
        {
            Console.Write($"k:{k} m:{m} result:");
            try
            {
                Console.WriteLine(calSum(k, m));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("EXCEPTION! {0}", e.Message);
            }
        }
    }
}
