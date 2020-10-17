using System;
using System.Collections.Generic;
using System.Linq;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var list = new List<long>();
            for (long l = 1; l * l <= n; l++)
            {
                if (n % l == 0)
                {
                    Console.WriteLine(l);
                    if(l != (n / l)) list.Add(n / l);
                }
            }
            list.Reverse();
            foreach(long l in list)
            {
                Console.WriteLine(l);
            }
            
        }
    }
}
