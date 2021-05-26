using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game!");
            Console.Write("What's your first name?  ");
            string fName = Console.ReadLine();
            Console.Write("What's your last name?  ");
            string lName = Console.ReadLine();
            DisplayResult(ReverseString(fName),ReverseString(lName));

            DisplayResult(ReverseString(fName) + " " + ReverseString(lName));
            Console.ReadLine();
        }
        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(string fName, string lName)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1}", fName, lName));
            Console.WriteLine();
        }

        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);
            Console.WriteLine();
        }
    }
}
