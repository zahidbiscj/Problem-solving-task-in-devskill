#define ONLINE_JUDGE

using System;

namespace ProblemSolvingTask
{
    class DCP85
    {
        static void Main(string[] args)
        {
            while (true) {
                string line = Console.ReadLine();
                if (line == null) { break; }

                int n = int.Parse(line);
                if (n == 29 || n == 30) { Console.WriteLine("YES"); }
                else { Console.WriteLine("NO"); }
            } 
           
        }
    }
}
