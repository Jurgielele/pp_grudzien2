using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; int b = 1;
            int.TryParse(Console.ReadLine(), out a);
            while (a > 0)
            {
                b *= a;
                a--;
            }
            Console.WriteLine(b);
        }
    }
}
