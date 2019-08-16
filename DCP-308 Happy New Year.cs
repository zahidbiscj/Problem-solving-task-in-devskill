#define ONLINE_JUDGE
using System;
using System.Collections;
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
                
                var line = Console.ReadLine().Split(' ');
                if (line == null) { break; }

                if (line.Contains("nobo")) {
                    int year = int.Parse(line[3]);
                    year = year + 650;
                    Console.WriteLine("Shuva naya barsha "+year);
                   
                }
                if (line.Contains("naya"))
                {
                    int year = int.Parse(line[3]);
                    year = year - 650;
                    Console.WriteLine("Shuvo nobo borsho " + year);

                }


            }

        }
    }
}