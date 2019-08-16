#define ONLINE_JUDGE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTask
{
    class Program
    {
        public static void Main(string[] args)
        {

            int count = 0;
            int range = Int32.Parse(Console.ReadLine());
            Dictionary<char, int> aDictionary = new Dictionary<char, int>();
            List<string> aList = new List<string>();

            for (int i = 0; i < range; i++)
            {
                count += 1;
                string stringdata = Console.ReadLine();
                
                aList.Add("Case " + count + ":");
                foreach (var data in GetDictValue(stringdata))
                {
                    aList.Add(data);
                }
            }
            foreach (string data in aList)
            {
                Console.WriteLine(data);
            }

            Console.ReadKey();
        }

        public static List<string> GetDictValue(string name)
        {
            Dictionary<char, int> aDictionary = new Dictionary<char, int>();
            List<string> aList = new List<string>();

            for (int i = 0; i < name.Length; i++)
            {
                if (aDictionary.ContainsKey(name[i]))
                {
                    aDictionary[name[i]] += 1;
                }
                else
                {
                    aDictionary.Add(name[i], 1);

                }

            }
            foreach (var data in aDictionary.OrderBy(i => i.Key))
            {
                aList.Add(data.Key + " " + data.Value);
            }

            return aList;


        }
    }
}
