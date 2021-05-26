using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myList = new List<Car>()
            {

               new Car { Make = "BMW", Model = "91", VIN = "A1"},
               new Car { Make = "Geo", Model = "92", VIN = "A2"},
               new Car { Make = "BMW", Model = "93", VIN = "A3"},
               new Car { Make = "Ford", Model = "94", VIN = "A4"},
               new Car { Make = "Nissan", Model = "95", VIN = "A5"}
            };


            //LINQ Query    
            /*
            var bmws = from car in myList 
                       where car.Make == "BMW" 
                       && car.VIN == "A3"
                        select car;

            var orderedCar = from car in myList
                             orderby car.Model descending
                             select car;
            */

            //LINQ method
            // var bmws = myList.Where(p => p.Make == "BMW" && p.VIN == "A3"); 

            var orderedCar = myList.OrderByDescending(p => p.Model);


            foreach (var car in orderedCar)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            /*foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }*/

            Console.ReadLine();
        }

    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }
}
