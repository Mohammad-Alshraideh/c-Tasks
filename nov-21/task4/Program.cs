using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 2;
            int third = 6;
            int fourth = 9;
            int fifth = 5;
            int res = first;
            if(second > res)
            {
                res = second;
            }
            if (third > res)
            {
                res = third;
            }
            if (fourth > res)
            {
                res = fourth;
            }
            if (fifth > res)
            {
                res = fifth;
            }

            Console.WriteLine(res);
        }
    }
}
