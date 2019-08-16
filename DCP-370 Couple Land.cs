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
                Int64 n = Int64.Parse(Console.ReadLine());
                Console.Write("Case {0}: ",i+1);
                if (n % 2 == 0)
                {
                    Console.WriteLine((n / 2) * (n / 2));
                }
                else {
                    Console.WriteLine((n/2)*((n/2)+1));
                }
            }
            

        }
    }
}
