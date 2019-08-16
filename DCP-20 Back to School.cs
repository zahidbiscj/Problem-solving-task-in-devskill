#define ONLINE_JUDGE
#define ONLINE_JUDGE


using System;

namespace ProblemSolvingTask
{
    class DCP20
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var line = Console.ReadLine().Split(' ');
                if (line == null) { break; }

                double cx = double.Parse(line[0]);
                double cy = double.Parse(line[1]);
                double r = double.Parse(line[2]);
                double px = double.Parse(line[3]);
                double py = double.Parse(line[4]);

                double d = Math.Sqrt(((cx - px) * (cx - px)) + ((cy - py) * (cy - py)));
                if (d == r)
                    Console.WriteLine("Case {0}: OnCircle", i + 1);
                else if (d > r)
                    Console.WriteLine("Case {0}: Outside", i + 1);
                else
                    Console.WriteLine("Case {0}: Inside", i + 1);

            }

        }
    }
}
