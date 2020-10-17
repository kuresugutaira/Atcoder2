using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ');
            var xs = new long[n];
            var tmp = new long[n];
            for(int i = 0; i < n; i++)
            {
                xs[i] = long.Parse(input[i]);
                tmp[i] = Math.Abs(xs[i]);
            }
            var result1 = 0L;
            var result2 = 0L;
            var result3 = tmp[0];
            foreach (Int64 i in tmp)
            {
                result1 += i;
                result2 += i * i;
            }
            Console.WriteLine(result1);
            var str = Math.Sqrt(result2).ToString("F15");
            Console.WriteLine(str);
            for(int i = 1; i < n; i++)
            {
                result3 = Math.Max(result3, tmp[i]);
            }

            Console.WriteLine(result3);
            
        }
    }
}
