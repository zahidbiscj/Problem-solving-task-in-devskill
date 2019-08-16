#define ONLINE_JUDGE


using System;

namespace ProblemSolvingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[44];
            arr[0] = 1;
            arr[1] = 3;
            arr[2] = 4;
            for (int i = 3; i < 44; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}", arr[n - 1]);

            }
        }
    }
}
