using System;
using System.Collections.Generic;



namespace PracticeCoding
{
    class DCP38
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<int, string>();
            for (int tcs = 0; tcs < t; tcs++)
            {
                int n = int.Parse(Console.ReadLine());
                int max = 9999999, min = -1;
                for (int i = 0; i < n; i++)
                {
                    var line = Console.ReadLine().Split(' ');

                    string name = line[0];
                    int fm = int.Parse(line[1]);

                    if (i == 0) { min = fm; max = fm; }

                    if (fm > max) { max = fm; }
                    if (fm < min) { min = fm; }

                    if (dictionary.ContainsKey(fm)) {
                        dictionary.Remove(fm);
                    }    
                    dictionary.Add(fm, name);
                    
                }

                Console.WriteLine(dictionary[max]+" "+dictionary[min]);

            }

        }
    }
}
