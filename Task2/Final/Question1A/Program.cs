using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1A
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryOverInts();
            /*
             Output:
                80 50 60 70 90
                45
             */
        }
        static void QueryOverInts()
        {
            int[] numbers = { 20, 80, 10, 50, 30, 60, 40, 70, 90 };

            var less = numbers.Where(n => n > numbers[2]).Select(n => n);
            var intFactor = numbers.Select(n => n / numbers.Min()).ToArray();
            numbers[2] = 40;
            foreach (var i in less)
                Console.Write("{0} ", i);
            Console.WriteLine();
            Console.WriteLine("{0}", intFactor.Sum());
            Console.ReadLine();
        }
    }
}
