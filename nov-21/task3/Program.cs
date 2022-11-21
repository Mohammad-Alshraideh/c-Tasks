using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 11;
            int secondd = 2;
            int third = 3;
            if (first > secondd && secondd > third)
            {
                Console.WriteLine($"{first} , {secondd} , {third}");
            }
            else if (first > third && third > secondd)
            {
                Console.WriteLine($"{first} , {third} , {secondd}");
            }
            else if (secondd > first && first > third)
            {
                Console.WriteLine($"{secondd} , {first} , {third}");
            }
            else if (secondd > third && third > first)
            {
                Console.WriteLine($"{secondd} , {third} , {first}");
            }
            else if (third > first && first > secondd)
            {
                Console.WriteLine($"{third} , {first} , {secondd}");
            }
            else if (third > secondd && secondd > first) 
            {
                Console.WriteLine($"{third} , {secondd} , {first}");
            }
        }       
    }
}
