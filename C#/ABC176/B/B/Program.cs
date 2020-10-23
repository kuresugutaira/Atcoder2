using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().ToCharArray();

            var result = 0L;
            foreach(var num in nums)
            {
                result = (result + long.Parse(num.ToString())) % 9;
            }
            Console.WriteLine(result == 0 ? "Yes" : "No");
        }
    }
}
