using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.myMethod();
            
            /*myCar.Make = "OldMobile";
            myCar.Model = "Honda";
            myCar.Year = 1986;
            myCar.Color = "White";

            Car myThirdCar = new Car("Hyundai", "95");

            Console.WriteLine("{0} {1} {2} {3}",
                myThirdCar.Make, myThirdCar.Model, myThirdCar.Year, myThirdCar.Color);

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
               myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            myOtherCar = null;

            Console.WriteLine("{0} {1} {2} {3}",
               myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myCar = null;*/


            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public  Car()
        {
            this.Make = "Nissan";
        }

        public Car(string make, string model)
        {
            this.Make = make;
            this.Model = model; 
        }

        public static void myMethod()
        {
            //Console.WriteLine("{0} {1} {2} {3}",this.Make, this.Model, this.Year, this.Color);
            Console.WriteLine("Static Method of Car Class");
        }
    }

}
