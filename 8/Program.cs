using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 2; 
            int.TryParse(Console.ReadLine(), out a);
            
            while (b <= a)
            {
                if (a % b == 0)
                {
                    if (a == b)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                        break;
                    }
                }
                b++;
            }
        }
    }
}
