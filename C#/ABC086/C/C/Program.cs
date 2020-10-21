using System;
using System.Linq;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var txys = new long[n][];
            var result = true;
            var postT = 0L;
            var postX = 0L;
            var postY = 0L;
            for(int i = 0; i < n; i++)
            {
                txys[i] = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            }
            foreach(var txy in txys)
            {
                var diffT = txy[0] - postT;
                var diffPos = Math.Abs(txy[1] - postX) + Math.Abs(txy[2] - postY);
                if (diffT < diffPos || diffT % 2 != diffPos % 2)
                {
                    result = false;
                    break;
                }
                postT = txy[0];
                postX = txy[1];
                postY = txy[2];
            }
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
