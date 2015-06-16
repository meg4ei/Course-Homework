using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixth_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the number ");
            int x = int.Parse(Console.ReadLine());
            int result = (x / 2);
            Console.Write("The result is ");
            Console.WriteLine(result);
        }
    }
}
