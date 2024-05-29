using System;

namespace Lab_3_3_
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            PrintResults(-1);
            PrintResults(-3);
            PrintResults(-8);
            PrintResults(-2);
            PrintResults(-4);
            PrintResults(20);
            PrintResults(-8);
        }
        public static double calSum3(double t)
        {
            if (t > 0)
            {
                throw new ArgumentOutOfRangeException(nameof(t), t, "Invalid value");
            }

            double resultSum, differPrecis;
            int i = 1;
            resultSum = 0;

            do
            {
                differPrecis = Math.Pow(-1, (i + 1)) / (i * (i + 1) * (i + 2));
                resultSum += differPrecis;
                i++;
            } while (Math.Abs(differPrecis) > Math.Pow(10, t));


            return resultSum;
        }

        static void PrintResults(double t)
        {
            Console.Write($"t:{t} result:");
            try
            {
                Console.WriteLine(calSum3(t));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("EXCEPTION! {0}", e.Message);
            }
        }
    }
}
