using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sum=0;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                sum += a;

            } while (a > 0);
            Console.WriteLine(sum);
        }
    }
}
