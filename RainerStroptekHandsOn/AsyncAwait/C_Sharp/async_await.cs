using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
//https://www.youtube.com/watch?v=FIZVKteEFyk
namespace C_Sharp
{
    class async_await
    {
        static void Main(string[] args)
        {
            //Our program writes output to STDOUT file  we can redirect output to a file
            var line = Console.ReadLine();
            Console.WriteLine($"{line}");
            Console.WriteLine("Async Await");

            Console.Read();
        }
    }
}
