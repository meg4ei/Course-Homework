using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            do
            {
                c++;
                if (c % 7 == 0 || c % 11 == 0)
                {
                    Console.WriteLine(c);
                }
            } while (c <= 100);
        }
    }
}
