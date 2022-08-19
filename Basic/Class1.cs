using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Practice.Basic
{
 //   1. Write a C# Sharp program to print Hello and your name in a separate line.
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Priyanka");
        }
    }
    // 2. Write a C# Sharp program to print the sum of two numbers.

    public class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine(sum);

        }
    }
    /*3. Write a C# Sharp program to print the result of dividing two numbers.*/

    public class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(18/2);
        }
    }
    //5. Write a C# Sharp program to swap two numbers.

    public class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp;

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping");
            Console.WriteLine("a :"+a);
            Console.WriteLine("b :"+b);
        }
    }

   // 6.Write a C# Sharp program to print the output of multiplication
        //of three numbers which will be entered by the user.

    public class Class5
    {
        static void Main(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3=Convert.ToInt32(Console.ReadLine());
            int mult;
            mult = (n1 * n2 * n3);
            Console.WriteLine(mult);
        }
    }
    /*8. Write a C# Sharp program that takes a number as input and print its multiplication table.
       */

    public class Class6
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(  );
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(n*i);   
            }

        }
    }

   // 9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
   /*average =n1 +n2 =ans
           = ans/no of nmbers*/

    public class Class7
    {
        static void Main(string[] args)
        {
            int n1=Convert.ToInt32(Console.ReadLine());
            int n2=Convert.ToInt32(Console.ReadLine());
            int n3= Convert.ToInt32(Console.ReadLine());
            int n4=Convert.ToInt32(Console.ReadLine());

            int avg;
            Console.WriteLine((n1+n2+n3+n4)/4);

        }
    }

    /*11. Write a C# Sharp program that takes an age (for example 20) as input
        and prints something as "You look older than 20".*/

    public class Class8
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());
            if(age>18)
            {
                Console.WriteLine("you are eligible for vote ");
            }
            else
            {               
                    Console.WriteLine("you are not eligible for vote ");                
            }
        }
    }

    /*12. Write a C# program to that takes a number as input and display it four times in a row 
        (separated by blank spaces), and then four times in the next row, with no separation.
        You should do it two times: Use Console.Write and then use { 0}.*/
          
    public class Class9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int j=5;j>=1;j--)
            {
                for (int i = 1; i <= 4; i++)
                {
                    Console.Write(" " + num);
                    
                }
                Console.WriteLine(" ");
            }
            
        }
    }
   /* 13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns
        wide and 5 rows tall using that digit. */

    class Class10

    {
        static void Main()

        {           

            Console.WriteLine("Program to Print Rectangle *'s");

            Console.WriteLine("enter number: ");
            int n=Convert.ToInt32(Console.ReadLine());

            int width = 0, height = 0;



            Console.Write("Enter Height :");

            height = int.Parse(Console.ReadLine());



            Console.Write("Enter Width :");

            width = int.Parse(Console.ReadLine());



            for (int i = 1; i <= height; i++)

            {

                for (int j = 1; j <= width; j++)

                {

                    if ((i == 1 || i == height) || (j == 1 || j == width))

                        Console.Write(n); //prints at border place

                    else

                        Console.Write(" "); //prints inside other than border

                }

                Console.WriteLine();

            }
        }


       // 14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit
       //formula tu calculate farhenheit =°C = [(°F - 32)×5]/9.
        public class Class11
        {
            static void Main(string[] args)
            {
                Console.WriteLine("celsius");
                decimal c = Convert.ToDecimal(Console.ReadLine());

                decimal f;
                
                Console.WriteLine(f =(c - 32) * 5/ 9);


            }
        }
    }
}
