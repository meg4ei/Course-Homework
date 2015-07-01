using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The index is " + (i * 10));
            }
        }
    }
}
