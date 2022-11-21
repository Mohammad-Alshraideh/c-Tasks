using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Hours:");
            int hrs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter minutes:");
            int mins = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{(hrs * 60) + mins}");
        }
    }
}
