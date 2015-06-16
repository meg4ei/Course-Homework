using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seventh_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the text ");
            string a = (Console.ReadLine());
            Console.WriteLine("Please, enter next text ");
            string b = (Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(b.Contains(a));
            Console.WriteLine();
        }
    }
}
