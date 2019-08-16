#define ONLINE_JUDGE
using System;
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
                int cnt = 0;
                int n = int.Parse(Console.ReadLine());
                string str = Console.ReadLine();
                if (str == null) { break; }
                int[] vowel = new int[1001];

                for (int i = 0; i < n; i++)
                {
                     
                     char ch = str[i];

                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        if (i == 0) { cnt++; }

                       else if (vowel[i - 1] == 1 && vowel[i] == 0)
                        {
                            vowel[i] = 0;
                            cnt++;
                        }
                    }
                    else { vowel[i] = 1; }

                }

                Console.Write("Case {0}: ",tcs+1);
                Console.WriteLine(cnt);
            }

        }
    }
}