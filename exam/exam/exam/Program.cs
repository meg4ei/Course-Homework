using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a number from 2 to 9 :");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            int s= n*n;
            int z=0;
            int []b= new int [s];
            int sum=0;

            if (n>=2 && n < 10)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = int.Parse(Console.ReadLine()); 
                    }
                } Console.WriteLine();
                
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                            b[z] = array[j, i];
                            Console.WriteLine(b[z]);
                            sum += b[z];
                            z++;
                    }
                   
                }
                Console.WriteLine();
                Console.WriteLine("The sum is: " + sum);
            }
        }
    }
}


