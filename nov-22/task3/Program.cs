using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            string [] foods = { "mansaf", "maqluba", "dawali", "kusa", "falafel" };
        string[] sports = { "football" , "tennis" , "swimming"};
        string[] movies = { "endgame", "matrix", "matrix2", "ther quest" };

            foreach (string food in foods)
            {
                Console.WriteLine(food);
            }
            foreach (string sport in sports)
            {
                Console.WriteLine(sport);
            }
            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }
    }
}
