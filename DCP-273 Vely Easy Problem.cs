#define ONLINE_JUDGE
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProblemSolvingTesting
{
    class DCP273
    {
       

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int tcs = 0; tcs < t; tcs++)
            {
                
                string line = Console.ReadLine();
                if (line == null) { break; }

                if (line.Contains("r"))
                {
                    Console.WriteLine("Not vely easy");

                }
                else {
                    Console.WriteLine("Vely easy");

                }



            }

        }
    }
}