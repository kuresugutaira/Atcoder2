using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var x = long.Parse(input[0]);
            var y = long.Parse(input[1]);
            var a = long.Parse(input[2]);
            var b = long.Parse(input[3]);
            var exp = 0L;
            var aTimes = 0L;
            if(x <= 1000000000)
            {
                while (x * a <= x + b && x * a < y)
                {
                    x *= a;
                    exp++;
                }
            }
            var bTimes = (y - x - 1) / b;
            exp += bTimes;
            Console.WriteLine(exp);
        }
    }
}