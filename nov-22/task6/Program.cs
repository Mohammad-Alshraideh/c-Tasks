using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            string str = "";
            for (int i = 0; i <= size; i++)
            {
                for (int j = size; j  >=  0; j--)
                {
                     if(j < i)
                    {
                        str += "   *";
                    }
                 
                    if (j >= i)
                    { 
                    
                        str += "  ";
                    }

                }
            

                Console.WriteLine(str);
               str = "";
            }

        }
    }
}
