using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://docs.microsoft.com/en-us/learn/modules/csharp-basic-formatting/2-exercise-character-escape-sequences
namespace C_Sharp
{
    class String_prac
    {
        static void PraccMain(string[] args)
        {
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine(@"   c:\source\repos   
      (this is where your code goes)");
            Console.Write(@"c:\invoices");
            // Kon'nichiwa World
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            //There are several caveats here.First, some consoles like the Windows Command Prompt will not display all Unicode characters.It will replace those characters with question mark characters intead. Also, the examples used here are UTF-16.Some characters require UTF - 32 and therefore require a different escape sequence.This is a complicated subject, and this module is only aiming at showing you what is possible.Depending on your need, you may need to spend quite a bit of time learning and working with Unicode characters in your applications.
            string firstName = "Bob";
            string message = "Hello " + firstName;
            Console.WriteLine(message);
            string greeting = "Hello";
            message = greeting + " " + firstName + "!";
           
            message = $"{greeting} {firstName}!";
            Console.WriteLine(message);


            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");

            Console.Read();
        }
    }
}
