#define ONLINE_JUDGE
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProblemSolvingTesting
{
    class DCP194
    {
       

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string mobileOperatorName = null;

            for (int tcs = 0; tcs < t; tcs++)
            {
                string number = Console.ReadLine();
                if (number.Contains("011")) { mobileOperatorName = "Citycell";  }
                else if (number.Contains("015")) { mobileOperatorName = "Teletalk"; }
                else if (number.Contains("016")) { mobileOperatorName = "Airtel"; }
                else if (number.Contains("017")) { mobileOperatorName = "Grameenphone"; }
                else if (number.Contains("018")) { mobileOperatorName = "Robi"; }
                else if (number.Contains("019")) { mobileOperatorName = "Banglalink"; }

                if (number.StartsWith("880")) { Console.WriteLine(number + " " + mobileOperatorName); }
                else {
                    Console.WriteLine("88"+number+" "+mobileOperatorName);
                }


            }



        }
    }
}