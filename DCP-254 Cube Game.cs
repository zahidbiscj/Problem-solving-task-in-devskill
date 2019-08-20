#define ONLINE_JUDGE

using System;
using System.Collections.Generic;

namespace ProblemSolvingTask
{
    class DCP254
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>(); 
            int t = int.Parse(Console.ReadLine());
            int score;
            for (int tcs = 0; tcs < t; tcs++)
            {
                var line = Console.ReadLine().Split(' ');
                int b = int.Parse(line[0]); // blue +1 point
                int s = int.Parse(line[1]); //silver +3 point
                int g = int.Parse(line[2]); //gold +10 point
                int r = int.Parse(line[3]); //Red -5 point
                score = (b * 1) + (s * 3) + (g * 10) + (r * (-5));
                result.Add(score);

                if (result[tcs] < 0) { score = 0; }
                Console.WriteLine("Player {0}: {1}",tcs+1,score);
            }
            result.Sort(); // sort korle lowest ta 0 index e thakbe ar highest ta last e
            Console.WriteLine("High Score = {0}",result[result.Count-1]);

        }
    }
}
