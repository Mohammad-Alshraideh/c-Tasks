using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tasks
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("task1----------------------------------------------------");
            //task1
            string userRead = Console.ReadLine();
               Console.WriteLine(userRead);
            Console.WriteLine("task2----------------------------------------------------");
            //task2
            double dNumber = 4.56;
            Console.WriteLine(dNumber);
            int intNumber = 5;
            Console.WriteLine(intNumber);
            bool boolVal = true;
            Console.WriteLine(boolVal);
            char oneChar= 'a';
            Console.WriteLine(oneChar);
            string fullString = "hello";
            Console.WriteLine(fullString);
            const int constant = 13;
            Console.WriteLine(constant);



            Console.WriteLine("task3---------------------------------------------------");
            //task3
            string[] arr = { "BMW", "Mercedes", "Toyota", "KIA" };
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[3]);



            Console.WriteLine("task4---------------------------------------------------");
            //task4
            Console.Write("input your firstname:");
            string firstname = Console.ReadLine();
            Console.Write("input your firstname:");
            string lastname = Console.ReadLine();
            Console.Write("input your firstname:");
            string year = Console.ReadLine();

            Console.WriteLine($"{firstname} {lastname} {year}");




            Console.WriteLine("task5---------------------------------------------------");
            //task5

            int[] numArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            numArr[0] = 1;
            numArr[1] = 1;
            numArr[2] = 2;
            Console.WriteLine($"{numArr[0]} {numArr[1]} {numArr[2]} {numArr[3]} {numArr[4]} {numArr[5]} {numArr[6]} {numArr[7]} {numArr[8]} {numArr[9]}");




            Console.WriteLine("task6---------------------------------------------------");
            //task6
            int[] sumArr = { 2, 5, 8 };
            Console.WriteLine($"Sum of all elements stored in the array is : {sumArr[0] + sumArr[1] + sumArr[2]}");
        }
    }
}
