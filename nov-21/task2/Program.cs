using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a Number:");
           string inpNum =  Console.ReadLine();
            int num = Convert.ToInt32(inpNum);
            if(num < 0 )
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}
