#define ONLINE_JUDGE
using System;


namespace PracticeCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {

                var input = Console.ReadLine().Split(' ');
                double v = Convert.ToDouble(input[0]);
                double s = Convert.ToDouble(input[1]);

                Console.WriteLine("{0:F2}", -(v / s));
                
            }

        }
    }
}
