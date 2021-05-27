using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class KnowVar
    {
       int _m = 10;//as var can only be used for local variables
        public void MyMethod(int i, int j = 10)
        {
            var k = i + j;
            var sum = "The sum";
            var n=0;
            var mul="";
            n = i * j;
            mul = "The multiplication";
            var ob = new Program();
            KnowVar ob2 = null;
        }
    }
}
