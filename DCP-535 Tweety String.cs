#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProblemSolvingTesting
{
    class DCP535
    {
       

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
             
            for (int tcs = 0; tcs < t; tcs++)
            {
                int sum = 0;
                string str = Console.ReadLine();
                if (str == null) { break; }

                for (int i = 0; i < str.Length; i++)
                {
                    int n = Convert.ToInt32(str[i]);
                    sum = sum + n;
                }
                if (sum % 20 == 0) { Console.WriteLine("Yes"); }
                else Console.WriteLine("No");

               
            }

        }
    }
}