using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int currentNumber = 0;

            do
           {
                  Console.WriteLine("Enter a number:");
                  currentNumber = int.Parse(Console.ReadLine());
                   sum = sum + currentNumber;

            } while (currentNumber != 0);

                Console.WriteLine(sum);
        }
    }
}
