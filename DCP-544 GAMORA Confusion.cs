#define ONLINE_JUDGE
using System;

public class DCP544
{
    public static void Main()
    {

        int T = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < T; i++)

        {

            string s = Console.ReadLine();

            if (s.Contains("Quill"))
            {
                Console.WriteLine("I am going to ask you this one time, where is Gamora?");
            }
            else if (s.Contains("Stark"))
            {
                Console.WriteLine("I will do you one better, who is Gamora?");
            }

            else if (s.Contains("Drax"))
            {
                Console.WriteLine("I will do you one better, why is Gamora?");
            }
            else {
                Console.WriteLine("What is Gamora?");
            }




        }





    }
}