using System;
using System.Linq;
using System.Collections.Generic;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Int32.Parse(Console.ReadLine());
            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            Console.WriteLine(list.Distinct().Count());
        }
    }
}
