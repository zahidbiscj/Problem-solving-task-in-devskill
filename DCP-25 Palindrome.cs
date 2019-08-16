#define ONLINE_JUDGE

using System;

namespace ProblemSolvingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt=0;
            int t = int.Parse(Console.ReadLine());

            for (int a = 0; a < t; a++)
            {

                string text = Console.ReadLine().ToString().ToLower();
                int len = text.Length;

                int i = 0, j = len-1;
                cnt = 0;
                while (i<len/2) {
                    
                    if (text[i] == text[j])
                    {
                        cnt++;
                        i++; j--;
                    }
                    else { break; }
                }
                if ((len / 2) == cnt) {
                    Console.WriteLine("Yes");
                }
                else Console.WriteLine("No");

            }

        }
    }
}
