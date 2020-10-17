using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var n = Int32.Parse(input[0]);
            var a = Int32.Parse(input[1]);
            var b = Int32.Parse(input[2]);

            Console.WriteLine(n - a + b);
        }
    }
}
