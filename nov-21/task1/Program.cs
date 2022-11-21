using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 6;
            if(x < y)
            {
                Console.WriteLine(y);
            }else if(y < x)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Equal numbers");
            }
        }
    }
}
