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
                
                long n = long.Parse(Console.ReadLine());
                Console.WriteLine("{0}",n*(n+1)/2);
            }



        }
    }
}
