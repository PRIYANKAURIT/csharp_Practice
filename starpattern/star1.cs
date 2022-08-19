using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Practice.starpattern
{
    /*
*
**
***
****
*****
*/
    public class star1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
    /*
    *****
    ****
    ***
    **
    *
    */
    public class star2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
    
    /*
      *
     **
    ***
    */
    public class star3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = n;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j >= k)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
                k--;
            }

        }
    }

    /*
     *****
      ****
       ***
        **
         *
         */

    public class star4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = n;
            for (int i=n;i>=1;i--)
            {
                for(int j=n;j>=1;j--)
                {
                    if(j<=k)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                k--;
            }
        }
    }
}
