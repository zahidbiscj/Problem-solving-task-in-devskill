#define ONLINE_JUDGE

using System;

namespace ProblemSolvingTask
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                var lines = Console.ReadLine();
               
                if (lines == null) { break; }
                var line = lines.Split(' ');


                decimal sum = 0;
                
                int ct = Convert.ToInt32(line[0]);
                int n = Convert.ToInt32(line[1]);

                for (int i = 0; i < n; i++)
                {
                    int p = Int32.Parse(Console.ReadLine());
                    sum = sum + p;

                }
                decimal result = ct / sum;

                if (Math.Ceiling(result) == 1)
                {
                    Console.WriteLine("Project will finish within 1 day.");
                }

                else
                {
                    Console.WriteLine("Project will finish within {0:F0} days.", Math.Ceiling(result));
                }





            }

        }
    }
}
