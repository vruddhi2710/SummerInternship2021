using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString() );
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());

            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());

            Console.WriteLine(myValue.Month);

            //DateTime myBDay = new DateTime(1999,3,27);

            DateTime myBDay = DateTime.Parse("3/27/1999");
            Console.WriteLine(myBDay.ToLongDateString());

            TimeSpan myAge = DateTime.Now.Subtract(myBDay);
            Console.WriteLine(myAge.Days);

            Console.ReadLine();
        }
    }
}
