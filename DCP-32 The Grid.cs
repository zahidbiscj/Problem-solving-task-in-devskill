#define ONLINE_JUDGE
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace ProblemSolvingTesting
{
    class DCP32
    {
       

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int tcs = 0; tcs < t; tcs++)
            {
                
                var line = Console.ReadLine().Split(' ');
                if (line == null) { break; }

                var x1 = int.Parse(line[0]);
                var y1 = int.Parse(line[1]);
                var x2 = int.Parse(line[2]);
                var y2 = int.Parse(line[3]);

                var x = Math.Abs(x2 - x1);
                var y = Math.Abs(y2 - y1);

                Console.WriteLine("Case {0}: {1}",tcs+1,x+y);


            }

        }
    }
}