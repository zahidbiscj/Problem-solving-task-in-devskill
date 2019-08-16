#define ONLINE_JUDGE

using System;
using System.Linq;

namespace ProblemSolvingTask
{
    class Program
    {
        static int getMin(int[] arr,int n)
        {
            int res = arr[0];

            for (int i = 1; i < n; i++)
                res = Math.Min(res, arr[i]);
            return res;
        }


        static void Main(string[] args)
        {
            int cnt = 1;
            int t = int.Parse(Console.ReadLine());
            
            for (int tcs = 0; tcs < t; tcs++)
            {
                int[] arr = new int[100];
                var line = Console.ReadLine().Split(' ');
                if (line == null) { break; }

                for (int i = 0; i < line.Length; i++)
                {
                     arr[i] = int.Parse(line[i]);
                }

                Console.WriteLine("Case {0}: Among {1} numbers {2} is maximum and {3} is minimum",cnt++,line.Length,arr.Max(),getMin(arr,line.Length));

            }

        }
    }
}
