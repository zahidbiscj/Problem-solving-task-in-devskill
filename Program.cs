using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace ProblemSolvingTesting
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());

            for (int i = 1; i <= tc; i++)
            {
                int n = int.Parse(Console.ReadLine());

                int r =Convert.ToInt32(Math.Sqrt(n));


                Console.Write("Case {0}: ",i);

                if (r * r == n) { Console.WriteLine("YES"); }
                else Console.WriteLine("NO");
               

            }

        }
    }
}