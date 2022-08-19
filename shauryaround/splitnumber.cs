using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Practice.shauryaround
{
    public class splitnumber
    {
        static void Main(string[] args)
        {
            string s = "10,20,30,40,50,60";
            string[] s1 = s.Split(",");
            int c = 0;
            int sqr = 0;
            for (int i = 0; i < s1.Length; i++)
            {

                Console.WriteLine(sqr);
                c++;
            }
            Console.WriteLine(c);

            for (int j = 0; j < s1.Length; j++)
            {
                // sqr = s1[j] * s1[j];
                Console.Write(sqr);
            }
        }
    }

}
