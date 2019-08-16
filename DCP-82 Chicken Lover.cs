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

                if (n >= 120) { Console.WriteLine("Good Boy Sifat"); }
                else { Console.WriteLine("Naughty Boy Sifat"); }
            }
        }
    }
}
