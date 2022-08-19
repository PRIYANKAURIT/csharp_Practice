using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Practice.Recursion
{
    //1. Write a program in C# Sharp to print the first n natural number using recursion.
    //without using recursion
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<=n;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    //using recursion

    public class recursion1
    {
        
            //Console.WriteLine("Enter number");
           int n = Convert.ToInt32(Console.ReadLine());
        int num = 1;

            void natural()
            {
                if(num==n+1)
                {
                    return;               
                }
            Console.WriteLine(num);
            num++;
            natural();
            
            }
        
    static void Main(string[] args)
    {
            recursion1 r = new recursion1();
            r.natural();
           // Console.WriteLine(Nutural);
            Console.ReadLine();
    }

        
    }
    //2. Write a program in C# Sharp to print numbers from n to 1 using recursion. 
    //without using recursion
    public class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=n;i>=1;i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    //using recursion
    public class recursion2
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        void naturals()
        {
            if(n+1==1)
            {
                return;
            }
            Console.WriteLine(n);
            n--;
            naturals();
        }
        static void Main(string[] args)
        {
            recursion2 r2 = new recursion2();
            r2.naturals();
            Console.ReadLine();
        }
    }

    //3. Write a program in C# Sharp to find the sum of first n natural numbers using recursion.
    // without using recursion
    public class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for (int i=1;i<=n;i++)
            {               
                 sum = sum + i;                
            }
            Console.WriteLine(sum);
        }
    }
    //using recursion

    public class recursion3
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int i = 1;
        int sumnatural()
        {
            if(n==0)
            {
                return 1;
            }
            sum = sum + i;
            i++;
            Console.WriteLine(sum);
            sumnatural();
            return sum;
        }
        static void Main(string[] args)
        {
            recursion3 r3 = new recursion3();
            r3.sumnatural();
            Console.ReadLine();
        }
    }
    //4. Write a program in C# Sharp to display the individual digits of a given number using recursion.

    public partial class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n;
            
            while (n > 1)
            {
                a = n % 10;
                Console.WriteLine(a);
                n = n / 10;
               
            }
            
        }
    }
  //  5. Write a program in C# Sharp to count the number of digits in a number using recursion. 
    public class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n;
            int c = 1;
            while (n > 1)
            {
                a = n % 10;
                //Console.WriteLine(a);
                n = n / 10;
                c++;
            }
            Console.WriteLine(c);
        }
    }

    //6. Write a program in C to print even or odd numbers in a given range using recursion. 

    public class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("even number :");
            for (int i = 1; i <= n; i++)
            {
                //Console.WriteLine(i);
               
                if (i % 2 == 0)
                {                    
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("odd number :");
            for (int i = 1; i <= n; i++)
                {
                
                if (i%2!=0)
                    {                   
                      Console.WriteLine(i);
                    }
                }
            
        }
    }
    //15. Write a program in C# Sharp to calculate the power of any number using recursion. 
    public class Class15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter exponent number");
            int e = Convert.ToInt32(Console.ReadLine());
            int pwr = 1;
            for(int i=1;i<=e;i++)
            {
                pwr = b * pwr;                
            }
            Console.WriteLine("power :"+pwr);
        }
    }
    //factorial using recursion

    public class facto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n Recursion : Find the factorial of a given number :");
            Console.WriteLine("-------------------------------------------------------");

            Console.Write(" Input any positive number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            long fact = FactorialCalcu(n1);
            Console.WriteLine(" The factorial of {0} is : {1} ", n1, fact);
            Console.ReadKey();
        }

        private static long FactorialCalcu(int n1)
        {
            if (n1 == 0)
            {
                return 1;
            }
            return n1 * FactorialCalcu(n1 - 1);
        }
    }

}
