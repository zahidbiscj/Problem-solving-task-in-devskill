#define ONLINE_JUDGE

using System;

namespace ProblemSolvingTask
{
    class DCP394
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var lines = Console.ReadLine();

                if (lines == null) { break; }
                

                for (int i = 0; i < lines.Length-1; i++)
                {
                    Console.Write("9");
                }

                Console.Write("8");

                for (int i = 0; i < lines.Length-1; i++)
                {
                    Console.Write("0");
                }

                Console.WriteLine("1");
            }
        }
    }
}
