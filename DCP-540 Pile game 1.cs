#define ONLINE_JUDGE
using System;

public class DCP540
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        for (int tcs = 0; tcs < t; tcs++)
        {
            long n = long.Parse(Console.ReadLine());

            if (n % 3 == 0) { Console.WriteLine("Second"); }
            else { Console.WriteLine("First"); }
        }
    }
}