using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = "";

            for(int i = 0; i < 10; i++ )
            {
                j = i.ToString();
                k = i.ToString();
                
                //Console.WriteLine(i);
            }

            Console.WriteLine("J Outside for loop : " + j);
            Console.WriteLine("K Outside for loop : " + k);
            HelperMethod();

            Car car = new Car();
            car.DoSomething();
            Console.ReadLine();
        }

        public static void HelperMethod()
        {
            Console.WriteLine("K Outside Main fn : " + k);
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World";
        }
    }
}
