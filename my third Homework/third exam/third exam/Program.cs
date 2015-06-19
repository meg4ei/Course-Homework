using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a card:");
            string b =(Console.ReadLine());
            switch (b)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "A":
                case "K":
                case "Q":
                    Console.WriteLine("Your card is valid!");
                    break;
                default:
                    Console.WriteLine("Your card is incorect!");
                    break;
            }
                
            
           
            }
            
        }
    }

