/*     ABDULLAH MANAN
       2026SCS-11
       SECTION A
 TASK1
 using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("HELLO WORLD !");
        }
    }
}
*/


/* task2
 using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD !");
            Console.Write("HELLO WORLD !");
        }
    }
}*/

/* task3
using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable = 7;
            Console.WriteLine("Value: ");
            Console.Write(variable);
        }
    }
}*/


/* task4
using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable = " i am string";
            Console.WriteLine("String: ");
            Console.Write(variable);
            Console.ReadKey();
        }
    }
}*/


/* task5
using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            char variable =  'A';
            Console.WriteLine("Character: ");
            Console.Write(variable);
            Console.ReadKey();
        }
    }
}*/



/* task6

 using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            float variable = 2.2F;
            Console.WriteLine("Decimal: ");
            Console.Write(variable);
            Console.ReadKey();
        }
    }
}*/



/* task7
 using System;

namespace Week1
{
   class Program
   {
       static void Main(string[] args)
       {
           string str;
           str=Console.ReadLine();
           Console.WriteLine("You have intputted : ");
           Console.WriteLine(str);
           Console.ReadKey();
       }
   }
}*/
/*task8
 using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("You have intputted : ");
            int num = int.Parse(str);
            Console.WriteLine("The number is :");
            Console.Write(str);
            Console.ReadKey();
        }
    }
}*/


/*task9
 using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
           // str = Console.ReadLine();
            Console.WriteLine("You have intputted : ");
            str = Console.ReadLine();

            float num = float.Parse(str);
            Console.WriteLine("The floating  number is :");
            Console.Write(num);
            Console.ReadKey();
        }
    }
}*/







/* task10
using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            float length;
            float area;
            string str;
            Console.WriteLine("Enter Length : ");
            str = Console.ReadLine();

            length = float.Parse(str);
            area = length * length;
            Console.WriteLine("The Area is :");
            Console.Write(area);
            Console.ReadKey();
        }
    }
}*/




/*task 11
 using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            float length;
            float area;
            string str;
            Console.WriteLine("Enter Length : ");
            str = Console.ReadLine();

            length = float.Parse(str);
            area = length * length;
            Console.WriteLine("The Area is :");
            Console.Write(area);
            Console.ReadKey();
        }
    }
}*/




/*task12
 using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {


            string input;
            float marks;
            Console.Write("Enter  the marks : ");
            input = Console.ReadLine();

            marks = float.Parse(input);

            if (marks > 50)
            {
                Console.WriteLine("you are passed ");
            }
            else
            {
                Console.WriteLine("you are failed ");
            }


            Console.Read();

        }
    }
}*/




/*task13
 using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int x=0; x<5; x++)
            {
                Console.WriteLine("Welcome Jack");
            }
            Console.Read();
        }
    }
}*/




/*task14
 using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num ;
            int sum = 0;
            Console.Write("Enter Number: ");
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                sum= sum+num;
                Console.Write("Enter Number: ");
                num = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The total sum is {0}", sum);
            Console.Read();

            
        }
    }
}*/




/* TASK 15 using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            do
            {
                Console.Write("Enter Number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;

            } while (num != -1);
            
                sum = sum + 1;
                Console.WriteLine("The total sum is {0}",sum);
               
            Console.Read();


        }
    }
}*/



/* TASK 16 using System;
using System.ComponentModel;

namespace Week1
{
    class Program
    {

        static int add(int n1, int n2)
        {

            return n1 + n2;
        }
        static void Main(string[] args)
        {
            int num1;
            int num2; 
            
            
                Console.Write("Enter  1st Number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter  2nd Number: ");
            num2 = int.Parse(Console.ReadLine());
            int result = add(num1, num2);
            Console.WriteLine("Sum is {0}", result);
            Console.Read();



            


        }
    }
}*/



















