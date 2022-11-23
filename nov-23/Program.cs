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
            int ageInDays = ageInYears * 12 * 30;
            return ageInDays;
        }
        static int task5(int chicken , int cows , int pigs)
        {
            return (chicken * 2) + (cows * 4) + (pigs * 4);
        }
        static string task6(string username , string password)
        {
            string[] users = { "hello123" , "qqq564"};
            string res = "";
            foreach (string user in users)
            {
                if (username+password == user)
                {
                    res= "pass";
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
        static int[] task8(int[] arr)
        {
            int count = 0;
            foreach (int year in arr)
            {
                if(year % 4 == 0 && year % 100 != 0 || year % 400 ==0){
                    count++;
                }
            }
            int[] arr1 = new int[count + 1];

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)

                {
                    if (arr[j] % 4 == 0 && arr[j] % 100 != 0 || arr[j] % 400 == 0)
                    {
                        arr1[j] = arr[j];
                    }
                }
            }
         
            return arr1;
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
