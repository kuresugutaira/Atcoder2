using System;
using System.Linq;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new String(Console.ReadLine().Reverse().ToArray());
            var result = false;

            while (true)
            {
                if (s == "")
                {
                    result = true;
                    break;
                }

                if (s.Length < 5) break;

                if(s.Substring(0,5) == "maerd")
                {
                    s = s.Substring(5, s.Length - 5);
                    continue;
                }
                else if(s.Substring(0, 5) == "esare")
                {
                    s = s.Substring(5, s.Length - 5);
                    continue;
                }

                if (s.Length < 6) break;

                else if (s.Substring(0, 6) == "resare")
                {
                    s = s.Substring(6, s.Length - 6);
                    continue;
                }

                if (s.Length < 7) break;

                if (s.Substring(0, 7) == "remaerd")
                {
                    s = s.Substring(7, s.Length - 7);
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(result ? "YES" : "NO");
        }
    }
}
