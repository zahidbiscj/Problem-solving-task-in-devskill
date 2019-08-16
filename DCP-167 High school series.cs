#define ONLINE_JUDGE

using System;

namespace ProblemSolvingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Case {0}: {1}",i+1,((n*n)*Math.Pow(n+1,2))/4);
            }
        }
    }
}
