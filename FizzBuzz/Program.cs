using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++) {
                Console.WriteLine(FizzBuzz.Fizz(i));
            }
            Console.ReadKey();
        }
    }

    class FizzBuzz {
        public static string Fizz(int i) {
            return (i % 15 == 0) ? "FizzBuzz" : ((i % 3 == 0) ? "Fizz" : ((i % 5 == 0) ? "Buzz" : i.ToString()));
        }
    }
}
