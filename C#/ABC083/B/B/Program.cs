using System;
using System.Threading;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var n = Int32.Parse(input[0]);
            var a = Int32.Parse(input[1]);
            var b = Int32.Parse(input[2]);
            var count = 0;
            var result = 0;

            for(int i = 1; i < n + 1; i++)
            {
                count = 0;
                var charArray = i.ToString().ToCharArray();
                foreach(char c in charArray)
                {
                    count += Int32.Parse(c.ToString());
                }
                if (count >= a && count <= b) result += i;
            }

            Console.WriteLine(result);
        }
    }
}
