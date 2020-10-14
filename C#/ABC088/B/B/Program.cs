using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Int32.Parse(Console.ReadLine());
            var inputArray = Console.ReadLine().Split(' ');
            var aArr = new int[n];
            var alice = 0;
            var bob = 0;
            for (int i = 0; i < n; i++)
            {
                aArr[i] = Int32.Parse(inputArray[i]);
            }
            Array.Sort(aArr);
            Array.Reverse(aArr);
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    alice += aArr[i];
                }
                else
                {
                    bob += aArr[i];   
                }
            }
            Console.WriteLine(alice - bob);
            
        }
    }
}
