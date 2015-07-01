using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a number: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Search Index of number: ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (m == myArray[i])
                {
                    Console.WriteLine();
                    Console.WriteLine("The Index is: " + i);
                    break;
                }
            }

        }
    }
}
