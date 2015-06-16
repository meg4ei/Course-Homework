using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourth_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a new number:");
                int y = int.Parse(Console.ReadLine());
            int result= (x % y );
            Console.Write("The result is ");
            Console.WriteLine(result);

        }
    }
}
