#define ONLINE_JUDGE

using System;

namespace ProblemSolvingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var lines = Console.ReadLine();

                if (lines == null) { break; }
                var line = lines.Split(' ');

                long n = Convert.ToInt64(line[0]);
                long m = Convert.ToInt64(line[1]);

                if (m == n)
                {
                    Console.WriteLine("Even");
                }

                else if (m == 1 || n == 1)
                {
                    Console.WriteLine("Odd");
                }
                else { Console.WriteLine("Even"); }

            }
        }
    }
}
