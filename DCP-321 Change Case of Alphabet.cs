#define ONLINE_JUDGE
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProblemSolvingTesting
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int tcs = 0; tcs < t; tcs++)
            {
                char ch;
                Stack stack = new Stack();
                string line = Console.ReadLine();
                if (line == null) { break; }

                for (int i = line.Length-1; i >= 0; i--)
                {
                    if (line[i] >= 'a' && line[i] <= 'z')
                    {
                        ch = Convert.ToChar(Convert.ToInt32(line[i]) - 32);
                        stack.Push(ch);
                    }

                    else {
                        ch = Convert.ToChar(Convert.ToInt32(line[i]) + 32);
                        stack.Push(ch);
                    }
                }

                foreach (var item in stack)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

        }
    }
}