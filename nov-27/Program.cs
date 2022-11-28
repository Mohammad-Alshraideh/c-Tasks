using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace nov_27
{
    internal class Program
    {

        internal class Person
        {
            public int age;
            private string gender;
            public string name;
            private string email;
            public int id;
            private string phoneNumber;
            public   Person( int age , string gender , string name , string email , int id , string phoneNumber)
            {

                bool ageCheck = false;
                bool phoneCheck = false;
                
                if (age >= 18 && age <= 60)
                {
                    ageCheck = true;
               
                }
                else
                {
                    Console.WriteLine("age not in range.");
                }

               
                if (Convert.ToInt32( phoneNumber[0]) == '0' && Convert.ToInt32(phoneNumber[1]) == '7' && (Convert.ToInt32(phoneNumber[2]) == '7'|| Convert.ToInt32(phoneNumber[2]) == '8' || Convert.ToInt32(phoneNumber[2]) == '9'))
                {
                    phoneCheck = true;
                }
                else
                {
                    Console.WriteLine("invalid phone number.");
                
                    
                }

                if (ageCheck && phoneCheck)
                {
             
                    this.age = age;
                    this.gender = gender;
                    this.name = name;
                    this.email = email;
                    this.phoneNumber = phoneNumber;
                    this.id = id;
                
                }
             
               
            }
        }
       
        static void Main(string[] args)
        {
            Person person= new Person( 18 , "male" , "mohammad" , "mavip@gmail.com" , 1 , "077456574");
           Console.WriteLine(person.age);

        }
    }
}
