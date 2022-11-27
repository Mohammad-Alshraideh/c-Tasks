using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov_23
{
    internal class Program
    {
        static void task1(int num1 , int num2 , int num3, int num4, int num5, int num6, int num7, int num8, int num9, int num10)
        {
            int sum = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
            double avg =Convert.ToDouble(sum) /  10;
            Console.WriteLine($"The sum of 10 no is : {sum}");
            Console.WriteLine($"The Average is : {avg}");

        }
        static void task2(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Number is : {i} and cube of the {i} is :{i*i*i}");
            }

        }
        static void task3()
        {
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            foreach (int year in years)
            {
                if (year > 1950)
                {
                    Console.WriteLine(year);
                }
            }

        }
        static int task4( int ageInYears)
        {
            int ageInDays = ageInYears * 365;
            return ageInDays;
        }
        static int task5(int chicken , int cows , int pigs)
        {
            return (chicken * 2) + (cows * 4) + (pigs * 4);
        }
        static string task6(string username, string password)
        {

            string[][] users =
{
    new string[] { "123", "qqq" },
    new string[] { "qqq", "123" },

};

            Console.WriteLine(users[0][0]);
            string res = "";
            for (int i = 0; i < users.Length; i++)
            {
  
                    if (username == users[i][0] && password == users[i][1])
                    {
                        res = "pass";
                    break;
                }
                else
                {
                    res = "fail";
                }
                
            }

            return res;
        }
        static double task7(double bas , double pow)
        {
            return Math.Pow(bas, pow);
        }
        static void task8()
        {
            Console.WriteLine("Enter a year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year >= 1900 && year <= 2024)
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine($"{year} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year");
                }

            }



            
        }
        static bool task9( int x)
        {
            bool prime = false;
            for (int i = 2; i < x; i++)
            {
                if(x % i == 0)
                {
                    prime = false;
                    break;  
                }
                else
                {
                    prime = true;
                }
            }
            return prime;
        }
        static int task10( string sent)
        {
            
            return sent.Split(' ').Length;
        }

        static void Main(string[] args)
        {

            
            
        }
    }
}
