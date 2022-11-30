using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static nov_29.Program;

namespace nov_29
{
    internal class Program
    {
        public class Employee
        {
            public string name { get; }
            public int yearOfBirth { get; }
            public  int id { get; }

            public Employee(string name, int yearOfBirth, int id) { 
                this.name = name;
                this.yearOfBirth = yearOfBirth;
                this.id = id;
            }

           

            public int age(int yearOfBirth)
            {
                string currentYear = DateTime.Now.ToString("yyyy");
                int year = Convert.ToInt32(currentYear);

                return year - yearOfBirth;
            }
            public virtual void  greet (string name) {
               Console.WriteLine("hello" + " " + name);
            }
            public virtual void greet(int id)
            {
                Console.WriteLine("hello emplyee number" + " " + id);
            }
        }

        public class Manager : Employee
        {
            public override void greet(string name)
            {
                Console.WriteLine("hello" + " " + " Mr." + name);
            }
            public Manager(string name, int yearOfBirth, int id) : base(name, yearOfBirth, id)
            {

            }
        }
        static void Main(string[] args)
        {
            Manager manager1 = new Manager("shraideh" , 1995 , 1);
            Console.WriteLine(manager1.name + " " + manager1.age(manager1.yearOfBirth) + " " + manager1.id) ;
            manager1.greet(manager1.name) ;

        }
    }
}
