#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProblemSolvingTesting
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int tcs = 0; tcs < t; tcs++)
            {
                var str = Console.ReadLine().Split(' ');
                if (str == null) { break; }

                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);

                if (a > b) { Console.WriteLine("Argentina {0} - {1} Brazil", a, b); }
                else { Console.WriteLine("Brazil {0} - {1} Argentina", b, a); }
            }

        }
    }
}