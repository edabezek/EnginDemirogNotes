using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IsPrimeNum(6))
            {
                Console.WriteLine("This  is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
        }
        private static bool IsPrimeNum ( int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
}
