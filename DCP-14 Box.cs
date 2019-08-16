#define ONLINE_JUDGE
using System;

public class PracticeCoding
{
    public static void Main()
    {

        int T = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < T; i++)

        {

            string s = Console.ReadLine();
            string[] values = s.Split(' ');

            double a = double.Parse(values[0]);
            double b = double.Parse(values[1]);
            double c = double.Parse(values[2]);

            double result = Math.Sqrt((a * a) + (b * b) + (c * c));
           

            Console.WriteLine("{0:F2}",result);


        }





    }
}