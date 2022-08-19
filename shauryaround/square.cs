using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Practice.shauryaround
{
    public class square
    {
        static void Main(string[] args)
        {

            int[] arr = { 10, 20, 30, 40, 50, 60 };
            int cnt = 0;
            for (int j = 0; j < arr.Length; j++)
            {

                Console.Write(arr[j] + ",");

            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                cnt++;
                Console.Write(arr[i] * arr[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Count=" + cnt);
        }
    }
}

