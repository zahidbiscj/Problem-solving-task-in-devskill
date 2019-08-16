#define ONLINE_JUDGE
using System;

public class PracticeCoding
{
    public static void Main()
    {

        int T = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < T; i++)

        {
            int win = 0;
            for (int j = 0; j < 2; j++)
            {
                string s = Console.ReadLine();
                string[] values = s.Split(' ');


                int b1 = int.Parse(values[0]);
                int b2 = int.Parse(values[1]);
                int p1 = int.Parse(values[2]);
                int p2 = int.Parse(values[3]);
                if ((b1 + b2) > (p1 + p2))
                {
                    win++;
                }
            }
            if (win == 2)
            {
                Console.WriteLine("Banglawash");
            }
            else
            {
                Console.WriteLine("Miss");
            }
            win = 0;
        }





    }
}