using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            static void AnArray()
            {
                /*your answer goes here*/
                object[] TestArray = new object[4];
                TestArray[0] = 10;
                TestArray[1] = false;
                TestArray[2] = new DateTime(2019, 01, 01);
                TestArray[3] = "sample string";

                foreach (object obj in TestArray)
                {
                    Console.WriteLine(obj);
                    
                }
                //Console.ReadLine();
            }
            AnArray();
        }
    }
}