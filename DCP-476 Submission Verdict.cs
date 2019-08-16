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
                var str = Console.ReadLine();
                if (str == null) { break; }

                if (str.Contains("ac")) { Console.WriteLine("Accepted"); }
                if (str.Contains("wa")) { Console.WriteLine("Wrong Answer"); }
                if (str.Contains("rte")) { Console.WriteLine("Run Time Error"); }
                if (str.Contains("tle")) { Console.WriteLine("Time Limit Exceeded"); }
            }

        }
    }
}