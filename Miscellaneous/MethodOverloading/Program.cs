using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2,3));
            Console.WriteLine(Multiply(2,3,4));
            Console.ReadLine();
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1,int number2,int number3)
        {
            return number1 * number2 * number3;
        }
    }
}
