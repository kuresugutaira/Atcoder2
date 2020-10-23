using System;
using System.Linq;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            var result = 0L;
            for(int i = 0; i < n - 1; i++)
            {
                if(input[i] > input[i + 1])
                {
                    result += input[i] - input[i + 1];
                    input[i + 1] = input[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
