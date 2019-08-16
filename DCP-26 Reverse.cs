#define ONLINE_JUDGE

using System;

namespace ProblemSolvingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {


                string str = Console.ReadLine();
                
                string reverse = "";

                for (int j = str.Length - 1; j >= 0; j--)
                {
                    reverse += str[j];
                }
                Console.WriteLine(reverse);
            }
        }
    }
}
