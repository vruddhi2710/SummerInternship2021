using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello world";
            s.Replace('o', 'i');
            s.Replace("r", string.Empty);
            Console.WriteLine(s);
        }
    }
}
//The output will be helli wi\0ld
