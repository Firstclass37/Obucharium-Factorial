using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            if (int.TryParse(Console.ReadLine(), out input))
            {
                int result = 1;
                for (int i = 1; i <= input; i++)
                    result *= i;
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
