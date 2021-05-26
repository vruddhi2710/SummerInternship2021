using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "OldMobile";
            car1.Model = "99";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "A2";

            Book book = new Book();
            book.Author = "Robert Downey";
            book.Title = "Ironman : The Unsunged Hero";
            book.ISBN = "0-000-00000-0";

            /* ArrayList myAraayList = new ArrayList();
             myAraayList.Add(car1);
             myAraayList.Add(car2);
             myAraayList.Add(book);
             myAraayList.Remove(book);

             foreach (Car car in myAraayList)
             {
                 Console.WriteLine(car.Make);
             }*/

            //List<T>
            /*List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(book); //It  wont let you add car to the List.

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }*/

            //Dictionary<Tkey, TValue>
            /* Dictionary<string, Car> myDict = new Dictionary<string, Car>();
             myDict.Add(car1.VIN, car1);
             myDict.Add(car2.VIN, car2);

             Console.WriteLine(myDict["A2"].Make);*/

            //string[] names = { "Bob", "Charlie", "Brian", "Cook" };

            //Object Initializer 
            Car car3 = new Car() { Make = "BMW", Model = "97", VIN = "A3" };
            Car car4 = new Car() { Make = "Mercedes", Model = "92", VIN = "A4" };

            //Collection Initializer
            List<Car> myList = new List<Car>()
            {
                new Car { Make = "Hyundai", Model = "95", VIN = "A5"},
                new Car { Make = "Nissan", Model = "96", VIN = "A6"}
            };


            Console.ReadLine();
        }

    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; } 
    }
}
