using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size = 4;
            int count = 1;
            string str = "";
            for (int i = 0; i <= size; i++)
            {
                for (int j = size; j >= 0; j--)
                {
                    if (j < i)
                    {
                        str += $"   {count}";
                        count++;
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
