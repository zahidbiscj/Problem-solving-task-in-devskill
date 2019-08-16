#define ONLINE_JUDGE
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace ProblemSolvingTesting
{
    class DCP65
    {
       

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int tcs = 0; tcs < t; tcs++)
            {

                int x = int.Parse(Console.ReadLine());
                var ans = Math.Ceiling(((Math.Sqrt(1.0 + (8 * x))) - 1.0) / 2.0);
                Console.WriteLine(ans);

            }

        }
    }
}