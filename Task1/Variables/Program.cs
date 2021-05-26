using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x, y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string fName = Console.ReadLine();

            Console.Write("Type your last name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("Hello, " + fName + " " + lName);
            Console.ReadLine();

        }
    }
}
