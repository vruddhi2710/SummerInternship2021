using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class TestBoxing
    {
        static void Main()
        {
            int i = 123;
            object o = i;   //Boxing
            i = 456;
            int j = (int)o;     //Unboxing
            System.Console.WriteLine(i);
            System.Console.WriteLine(j);
        }
    }
}
