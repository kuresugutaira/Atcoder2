using System;
using System.Xml.Schema;
using System.Collections.Generic;
using System.Linq;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var aArray = Console.ReadLine().Split(' ').Select(s => long.Parse(s)).ToArray();
            var n = long.Parse(input[0]);
            var x = long.Parse(input[1]);
            var result = 0L;
            if (aArray[0] > x)
            {
                var tmp = aArray[0] - x;
                aArray[0] -= tmp;
                result += tmp;
            }
            for (int i = 1; i < n; i++)
            {
                if (aArray[i - 1] + aArray[i] > x)
                {
                    var tmp = aArray[i - 1] + aArray[i] - x;
                    aArray[i] -= tmp;
                    result += tmp;
                }
            }
            Console.WriteLine(result);
        }
    }
}