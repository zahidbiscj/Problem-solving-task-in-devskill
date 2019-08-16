#define ONLINE_JUDGE


using System;

namespace ProblemSolvingTask
{
    class DCP27
    {
        static void Main(string[] args)
        {
            

            int tcs = int.Parse(Console.ReadLine());
            for (int tc = 0; tc < tcs; tc++)
            {
                int n= int.Parse(Console.ReadLine());
                bool flag = true;
                if (n == 2) { Console.WriteLine("Yes"); }
                else if (n == 0 || n == 1) { Console.WriteLine("No"); }

                else
                {
                    double s = Math.Sqrt(n);
                    for (int i = 2; i <= s; i++)
                    {
                        if (n % i == 0)
                        {
                            flag = false;
                            Console.WriteLine("No");
                            break;

                        }
                    }
                    if (flag == true)
                    {
                        Console.WriteLine("Yes");
                    }
                }
            }
        }
    }
}
