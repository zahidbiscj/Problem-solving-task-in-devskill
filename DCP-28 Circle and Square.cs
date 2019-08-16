#define ONLINE_JUDGE
#define ONLINE_JUDGE


using System;

namespace ProblemSolvingTask
{
    class DCP28
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var line = Console.ReadLine().Split(' ');
                if (line == null) { break; }

                double r = double.Parse(line[0]);
                double s = double.Parse(line[1]);

                r = r * 2;
                s = Math.Sqrt(2) * s;
                double a = Math.Abs(s - r);

                if (r == s ||  a<= 0.1)
                {
                    Console.WriteLine("Yes");
                }
                else Console.WriteLine("No");

            }

        }
    }
}
