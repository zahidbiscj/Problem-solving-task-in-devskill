#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProblemSolvingTesting
{
    class DCP586
    {
       

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int tcs = 0; tcs < t; tcs++)
            {
                var line = Console.ReadLine().Split(' ');
                if (line == null) { break; }

                int b = int.Parse(line[0]);
                int s = int.Parse(line[1]);
                int g = int.Parse(line[2]);

                int score = (b * 10) + (s * 50) + (g * 100);

                Console.WriteLine(score);
            }

        }
    }
}