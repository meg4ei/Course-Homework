﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please,enter the number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please,enter next number");
            int y = int.Parse(Console.ReadLine());
            int result = (x + y);
            Console.Write("Result is ");
            Console.WriteLine(result);
            
        }
    }
}
