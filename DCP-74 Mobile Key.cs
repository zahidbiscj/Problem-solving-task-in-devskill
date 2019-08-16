#define ONLINE_JUDGE

using System;

namespace ProblemSolvingTask
{
    class DCP74
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < t; i++)
            {
                long n = Int64.Parse(Console.ReadLine());
                Console.Write("Case #{0}: ",i+1);

                long num = n * 3;

                if (n % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2}", num, num - 1, num - 2);
                }
                else {
                    Console.WriteLine("{0} {1} {2}",num-2,num-1,num);
                }
            }
            

        }
    }
}
