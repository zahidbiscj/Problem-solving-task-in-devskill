#define ONLINE_JUDGE

using System;

namespace ProblemSolvingTask
{
    class DCP166
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int tcs = 0; tcs < t; tcs++)
            {
                int n = int.Parse(Console.ReadLine());
                double sum = 0.0;
                for (int i = 0; i < n; i++)
                {
                    var line = Console.ReadLine().Split(' ');
                    double p = double.Parse(line[0]);
                    double q = double.Parse(line[1]);

                    sum = sum + (p * q);
                }
                double g = double.Parse(Console.ReadLine());

                double result = Math.Floor(g - sum);
                Console.WriteLine("Case {0}: {1}",tcs+1,result);

            }
        }
    }
}
