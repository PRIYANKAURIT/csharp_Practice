using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Practice.starpattern
{
    public class alphabetX
    {
        static void Main(string[] args)
        {
            int k = 4;
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    
                        if (r == c || k==c)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                   
                }
                Console.WriteLine();
                k--;
            }
        }
    }
}
