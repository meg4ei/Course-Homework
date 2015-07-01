using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            array[0] = 0;
            array[1] = 1;
            array[2]= 1;
            
            for (int i = 0; i < n; i++)
            {
                array[i] = (i - 1) + (i - 2);
                if (array[i] > 0)
                {
                    Console.WriteLine(array[i]);

                }
                }
                
            }

        }
    }
}
