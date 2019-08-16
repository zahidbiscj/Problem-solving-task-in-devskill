#define ONLINE_JUDGE

using System;

namespace ProblemSolvingTask
{
    class DCP500
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();
                string[] values = s.Split(' ');
                int a = int.Parse(values[0]);
                int b = int.Parse(values[1]);

                if (b == 0) { Console.WriteLine(":kick:"); }
                else if (a % b == 0) { Console.WriteLine(":wink:"); }
                else Console.WriteLine(":kick:");

            }
        }
    }
}
