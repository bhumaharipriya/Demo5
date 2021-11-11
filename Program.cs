using System;

namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
              int a = 10;
            int? b = null;
            int? c = 100;

            Console.WriteLine(a);
            Console.WriteLine(b);

            int k = b?? 0;
            Console.WriteLine(k);
            int y = c ?? 0;
            Console.WriteLine(y);
        }
    }
}
