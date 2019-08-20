#define ONLINE_JUDGE

using System;

namespace ProblemSolvingTask
{
    class DCP467
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
            for (int tcs = 0; tcs < t; tcs++)
            {
                string str = Console.ReadLine();
                int cnt = 2018;

                for (int i = str.Length-1; i >= 0; i--)
                {
                    if (str[i] == 'r') { break; }
                    if (str[i] == '+') { cnt++; }
                    

                }

                Console.WriteLine("Happy New Year-{0}",cnt); 

            }
        }
    }
}
