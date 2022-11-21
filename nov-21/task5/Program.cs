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
            Console.WriteLine("Enter kilometeres to convert to miles:");
            int kilos = Convert.ToInt32( Console.ReadLine());
            
            float miles = 0.621371f;
            Console.WriteLine($"{kilos} kilometeres is {kilos * miles} Miles");
        }
    }
}
