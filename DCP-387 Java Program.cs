#define ONLINE_JUDGE
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProblemSolvingTesting
{
    class DCP387
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int tcs = 0; tcs < t; tcs++)
            {
                string input = Console.ReadLine();
                Queue<char> queue = new Queue<char>();

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '.') { break; }
                    if (input[i] >= 'A' && input[i] <= 'Z') {
                        queue.Enqueue(' ');
                    }
                    queue.Enqueue(input[i]);
                }
                Console.Write("Case #{0} ->",tcs+1);
                foreach (var item in queue)
                {
                    Console.Write(item);
                }
                Console.WriteLine();

            }
           

        }
    }
}