using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var n = long.Parse(input[0]);
            var x = long.Parse(input[1]);
            var t = long.Parse(input[2]);
            Console.WriteLine((n % x == 0) ? (n / x) * t : ((n / x) + 1) * t);
        }
    }
}
