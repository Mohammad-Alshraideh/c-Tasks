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
            Console.WriteLine("enter three numbers:");
            int sum = 0;
            string g = Console.ReadLine();
          string[] t = g.Split(',');
            foreach (string item in t)
            {
                sum += int.Parse(item);
            }
            Console.WriteLine(sum);
        }
    }
}
