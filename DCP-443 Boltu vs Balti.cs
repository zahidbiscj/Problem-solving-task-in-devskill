#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProblemSolvingTesting
{
    class DCP443
    {
       

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int tcs = 0; tcs < t; tcs++)
            {
                long n = long.Parse(Console.ReadLine());

                if (n == 1 || n == 3) { Console.WriteLine("Case {0}-> YES;", tcs + 1); }
                else { Console.WriteLine("Case {0}-> NO;", tcs + 1); }

            }

        }
    }
}