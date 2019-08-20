using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTask
{
    class DCP272
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int tcs = 0; tcs < t; tcs++)
            {
                int n = int.Parse(Console.ReadLine());
                var hash1 = new SortedSet<int>();
                var hash2 = new SortedSet<int>();
                
                for (int i = 0; i < n; i++)
                {
                    var line = Console.ReadLine().Split(' ');
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (i % 2 == 0) { hash1.Add(int.Parse(line[j]));}
                        else { hash2.Add(int.Parse(line[j])); }
                    }
                    var resultHash = new SortedSet<int>(hash1);
                    resultHash.IntersectWith(hash2);
                    if (i == 0) { continue; }
                    
                    if (i % 2 == 0) { hash2.Clear(); hash1 = resultHash; }
                    if (i % 2 != 0) { hash1.Clear(); hash2 = resultHash; }

                    if (i == (n - 1)) {
                        
                        if (resultHash.Count == 0) { Console.WriteLine("Empty"); break; }
                        string output = null;
                        foreach (var item in resultHash)
                        {
                             output += item + " ";
                        }
                        output.TrimEnd();
                        Console.WriteLine(output);
                    }
                }

            }
        }

    }
}
