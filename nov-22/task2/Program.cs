using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tomato = 0;
            int banana = 0;
           

            String[] fruits = {"Tomato", "Banana", "Watermelon"};

            for (int i = 0; i < fruits.Length; i++) {
                if (fruits[i] == "Tomato")
                {
                   tomato = i;

                }
                if (fruits[i] == "Banana")
                {

                banana = i;

                }

               

            }
            Console.WriteLine($"index of banana is {banana} and index of tomato is {tomato}");
        }
    }
}
