using System;
using System.Collections.Generic;

namespace OR.HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("c=");
            int c = int.Parse(Console.ReadLine());

            int maximum = 0;

            if (a>b)
            {
                if (a>c)
                 {
                    maximum = a;
                 }
                else
                 {
                    maximum = c;
                 }
            
                                  
            }

            if (b > a)
            {
                if (b > c)
                {
                    maximum = b;
                }
                else
                {
                    maximum = c;
                }



            }

            int proverka = maximum % 2;
            
            switch(proverka)
            {
                case 0:
                Console.WriteLine("чётное");
                break;

                case 1:
                Console.WriteLine("нечётное");
                break;


            }


            Console.WriteLine(maximum < 100 ? "yes" : "no" );


            Console.WriteLine(maximum);
            Console.ReadLine();
           
        }
    }
}
