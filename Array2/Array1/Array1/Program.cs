using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 4]
            {
            {5,6,7,8},
            {11,15,17,20},
            {15,75,10,14},
            };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        Console.WriteLine(a[i, j] + "\t");
                    }
                }
            }
        }
    }
}