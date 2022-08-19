using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Practice.starpattern
{
    public class capitalY
    {
        static void Main(string[] args)
        {
            int k = 9;
            
            for (int r = 1; r <= 9; r++)
            {
                for (int c = 1; c <= 9; c++)
                {
                    if ((r==c || c==k) && r<6)
                    {
                        Console.Write("*");
                    }
                    else if(r>=6 && c==5)
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
