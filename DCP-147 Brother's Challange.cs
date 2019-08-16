#define ONLINE_JUDGE

using System;

namespace ProblemSolvingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                long sum = 0;
                string line = Console.ReadLine();
                if (line == null) { break; }

                int n = int.Parse(line);
                for (int i = 0; i < n; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine(sum);
                
            } 
           
        }
    }
}
