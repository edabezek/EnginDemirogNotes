using System;
using System.Linq;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add4(4,5,6,8,9));
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
        
    }
}
