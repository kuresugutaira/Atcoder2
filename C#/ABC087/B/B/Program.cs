using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Int32.Parse(Console.ReadLine());
            var b = Int32.Parse(Console.ReadLine());
            var c = Int32.Parse(Console.ReadLine());
            var x = Int32.Parse(Console.ReadLine());

            var result = 0;
            for (int i = 0; i < a + 1; i++)
            {
                for (int j = 0; j < b + 1; j++)
                {
                    for (int k = 0; k < c + 1; k++)
                    {
                        if (500 * i + 100 * j + 50 * k == x) result++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
