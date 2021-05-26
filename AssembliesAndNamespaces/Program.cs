using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            string text ="A class is the most powerful data type in C#. Like a structure, " +
           "a class defines the data and behavior of the data type. ";

            //File.WriteAllText(@"D:\SI\WriteText.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("https://docs.microsoft.com");

            //Console.WriteLine(reply);
            File.WriteAllText(@"D:\SI\WriteText.txt", reply );
            Console.ReadLine();
        }
    }
}
