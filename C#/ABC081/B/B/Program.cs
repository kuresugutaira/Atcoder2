using System;
using System.Collections.Generic;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Int32.Parse(Console.ReadLine());
            var aArray = Console.ReadLine().Split(' ');
            var result = Int32.MaxValue;
            var count = 0;
            foreach(string str in aArray)
            {
                var a = Int32.Parse(str);
                count = 0;
                while (a % 2 == 0)
                {
                    a /= 2;
                    count++;
                }
                if (result > count) result = count;
            }
            Console.WriteLine(result);
        }
    }
}
