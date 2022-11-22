using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

           int i = 1;
            int sum = 0;
            string strOfNums = "";
            while (i < 101)
            {
                if (i % 2 != 0)
                {
                    strOfNums += $"{i} ";
                    sum+= i ;
                }
                i++;
            }
            Console.WriteLine(strOfNums);
            Console.WriteLine(sum);
        }
    }
}
