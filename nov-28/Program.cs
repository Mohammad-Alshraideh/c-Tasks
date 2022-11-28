using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nov_28
{
    internal class Program
    {
        class Car
        {
            public string make { get; }
            public int year { get; }
            public string type { get; }
            public int price { get; }
            public string model { get; }
            public int palletNo { get; }
            public string color { get; }
            public int cons { get; }
            public Car(string make, int year, string type, int price, string model, int palletNo, string color, int cons)
            {
                this.make = make;
                this.year = year;
                this.type = type;
                this.price = price;
                this.model = model;
                this.palletNo = palletNo;
                this.color = color;
                this.cons = cons;
            }

            public void engineStart()
            {
                Console.WriteLine( "Engine Started");
            }
            public void engineStop()
            {
                Console.WriteLine("Engine Stopped");
            }
            public void print()
            {
                Console.WriteLine($"make: {make} year: {year} type: {type} price: {price} model: {model} palletNo: {palletNo} color: {color}");
            }
            public void range()
            {
               Console.WriteLine($"{cons * 20}km");
            }

        }
        class Car1 : Car
        {
            public Car1(string make, int year, string type, int price, string model, int palletNo, string color , int cons) : base(make, year, type, price, model, palletNo, color , cons)
            {


            }

            

        }
static void Main(string[] args)
        {
            Car car1 = new Car("first", 2010, "asd", 20000, "asd", 7854, "red" , 20);

       
           Car1 dCar = new Car1("asadsdsd", 2010, "asd", 20000, "asd", 7854, "red" , 15);
            dCar.print();
            car1.range();
 



        }
    }
}
