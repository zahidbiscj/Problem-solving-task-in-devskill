using System;

namespace ProblemSolvingTask
{
    class DCP483
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (str == null) { break; }

                string quote = "never be so happy when you are happy and never be so sad when you are sad";

                var word = quote.Split(' ');
                int flag = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (str == word[i]) { flag = 1; break; }
                   
                }
                if (flag == 1) { Console.WriteLine("YES"); }
                else { Console.WriteLine("NO"); }
            }
        }
    }
}
