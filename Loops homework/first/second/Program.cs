using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 7;
            int b = 11;

            for (int i = 0; i <= 100; i++)
            {
                if (i % a == 0 || i % b == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
