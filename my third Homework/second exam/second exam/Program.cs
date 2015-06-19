using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_exam
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Please enter your points : from 1 to 9");
            int num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 3)
            {
                int result = num * 5;
             Console.WriteLine(result);
                }
                
            else if (num >= 4 && num <= 6)
           
                {
                    int result1= num *10 ;
                    Console.WriteLine(result1);
                }
            
                else if (num >=7 && num<=9)
                {
                    int result2 = num * 50;
                    Console.WriteLine(result2);
                }
                else
                {
                    Console.WriteLine("You write incorrect points");
                }
        }
    }
}
