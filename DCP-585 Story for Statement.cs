#define ONLINE_JUDGE
using System;
using System.Collections;
using System.Collections.Generic;


namespace ProblemSolvingTesting
{
    class DCP585
    {
        static void Main(string[] args)
        {
            var dataList = new List<string>() { "programming", "coding" };
            var outputList = new List<string>() { };

            int range = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < range; i++)
            {
                string iputData = Console.ReadLine();
                var data = ""; string temp = "";
                for (int j = 0; j < dataList.Count; j++)
                {
                    data = IsExistStoryCharacter(iputData.ToLower(), dataList[j]);
                    if (data.Contains("Yes"))
                    {
                        temp = "Yes";
                        break;
                    }
                    else
                    {
                        temp = "No";
                    }
                }
                outputList.Add(temp);
            }

            foreach (var data in outputList)
            {
                Console.WriteLine(data);
            }
        }
        public static string IsExistStoryCharacter(string inputdata, string stringdata)
        {
            var inputDictionary = new Dictionary<char, int>();
            var stringDictionary = new Dictionary<char, int>();

            inputDictionary = GetCountValue(inputdata);
            stringDictionary = GetCountValue(stringdata);
            var count = 0; var flag = "";

            foreach (var data2 in inputDictionary)
            {
                foreach (var data in stringDictionary)
                {
                    if (data.Key == data2.Key && data2.Value >= data.Value)
                    {
                        count += data.Value;
                    }
                }

            }
            if (count == stringdata.Length)
                flag = "Yes";
            else
                flag = "No";

            return flag;
        }


        public static Dictionary<char, int> GetCountValue(string name)
        {
            Dictionary<char, int> aDictionary = new Dictionary<char, int>();
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
            return aDictionary;
        }
    }
}