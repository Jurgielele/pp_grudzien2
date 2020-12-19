using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, sum = 0;
            int.TryParse(Console.ReadLine(), out a);
            while (a != 0)
            {
                sum += a % 10;
                a /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
