using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Console.Write("Message -> ");
            ReverseString("Message");
            Console.WriteLine();
            Display();
            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        private static void ReverseString(string msg)
        {
            char[] arr = msg.ToCharArray();
            Array.Reverse(arr);
            foreach (char item in arr)
            {
                Console.Write(item);
            }
        }

        private static void Display()
        {
            string x = "hello";
            string y = "Lucifer";
            string z = "Morningstar";
            Console.WriteLine(String.Format("{0}, {1} {2}.", x, y, z));
        }
    }
}
