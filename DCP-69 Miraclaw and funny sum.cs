#define ONLINE_JUDGE

using System;

namespace ProblemSolvingTask
{
    class DCP69
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int tcs = 0; tcs < t; tcs++)
            {
                
                int sum = 0,miraclawSum = 0,value,z=0 ;
                int n = int.Parse(Console.ReadLine());
                var line = Console.ReadLine().Split(' ');
                if (line == null) { break; }

                for (int i = 0; i < n; i++)
                {
                    value = int.Parse(line[i]);
                    sum = sum + value;
                    z = (value - i);
                    if (z < 0) { z = 0; }
                    miraclawSum += z;
                }
                Console.WriteLine(sum-miraclawSum);
            }
        }
    }
}
