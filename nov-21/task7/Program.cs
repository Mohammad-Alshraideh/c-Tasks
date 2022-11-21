using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minutes:");
            int mins = Convert.ToInt32(Console.ReadLine());
            double hrs = mins / 60;
            Console.WriteLine($"Hours {hrs} , {mins % 60} Minutes");
        }
    }
}
