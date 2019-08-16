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

                if (n % 2 == 0) { Console.WriteLine("1"); }
                else { Console.WriteLine("9"); }
            }
           
        }
    }
}
