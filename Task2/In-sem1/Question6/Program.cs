using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        class Point
        {
            public static int X
            {
                get
                {
                    return X;
                }
            }
            public static int Y
            {
                get
                {
                    return Y;
                }
            }
            public Point(int x,int y)
            {
                x = X;
                y = Y;
            }
            public static Tuple<int,int> Deconstruct()
            {
                return Tuple.Create(X, Y);
            }
        }
    }
}

