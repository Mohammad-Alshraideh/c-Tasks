using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = { "hi", "hello", "hly", "halloo", "hoyy" };
            Console.WriteLine($"{strArr[0].Substring(0 , 2)} {strArr[1].Substring(0, 2)}  {strArr[2].Substring(0, 2)}  {strArr[3].Substring(0, 2)} {strArr[4].Substring(0, 2)}  ");
        }
    }
}
