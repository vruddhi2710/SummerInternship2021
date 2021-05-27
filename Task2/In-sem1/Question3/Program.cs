using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "757657657657657";
                int res = int.Parse(str);
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Error caught {0}", e);
            }
        }
    }
}
