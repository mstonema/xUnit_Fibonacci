using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static int FibonacciReverse(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else return FibonacciReverse(n - 2) - FibonacciReverse(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the last number of the sequence (Hint 13): ");
            int upperBound = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while(i < upperBound)
            {
                Console.WriteLine(Fibonacci(i));
                i += 1;
            }
            while (i > 0)
            {
                Console.WriteLine(FibonacciReverse(i));
                i -= 1;
            }
            Console.ReadLine();
        }
    }
}
