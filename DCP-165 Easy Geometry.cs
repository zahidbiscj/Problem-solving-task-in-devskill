#define ONLINE_JUDGE
using System;

public class DCP165
{
    public static void Main()
    {

        int T = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < T; i++)

        {

            string s = Console.ReadLine();
            string[] values = s.Split(' ');

            int a = int.Parse(values[0]);
            int b = int.Parse(values[1]);


            Console.WriteLine("Case {0}: {1}",i+1,(a * 2) + (b * 3));

            


        }





    }
}