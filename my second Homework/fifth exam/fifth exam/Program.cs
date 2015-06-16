using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please,enter the text");
            string z = (Console.ReadLine());
            Console.WriteLine("Please,enter next text");
            string y = (Console.ReadLine());
            string result = (z + " " + y);
            Console.Write("You write ");
            Console.WriteLine(result);
        }
    }
}
