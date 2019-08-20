#define ONLINE_JUDGE
using System;


namespace PracticeCoding
{
    class DCP169
    {
        static void Main(string[] args)
        {
            
            int t = int.Parse(Console.ReadLine());

            for (int tcs = 0; tcs < t; tcs++)
            {
                var line = Console.ReadLine().Split(' ');
                if (line == null) { break; }

                int row = int.Parse(line[0]);
                int column = int.Parse(line[1]);
                char[] ch;
                int flag = 0,i=0,j=0;


                Console.WriteLine("Case {0}:", tcs + 1);
                for (i = 0; i < row; i++)
                {
                    ch = Console.ReadLine().ToCharArray();

                    for (j = 0; j < column; j++)
                    {
                        
                        if (ch[j] == '$') {
                            flag = 1;
                           

                            Console.WriteLine("{0},{1}", i + 1, j + 1);
                        }
                    }

                }
               

                
                if (flag == 0) {
                    Console.WriteLine("No Gold Found");
                }

            }


        }
    }
}
