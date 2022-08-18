using System;
using System.Collections.Generic;

namespace OR.HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            while (list.Count < 15)
            {

                while (true)
                {
                    Console.Write("Введите число: ");
                    string text = Console.ReadLine();
                    if (int.TryParse(text, out int number))
                    {
                        Console.WriteLine("Вы ввели число {0}", number);
                        list.Add(int.Parse(text));
                        break;
                    }
                    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                }
            }

            int summa = 0;

            for (int i = 0; i < 15; i++)
            {
                summa = summa + list[i];
            }

            decimal difference = 0;
            int a = 0;
            while (a < 15)

            {
               difference = difference - list[a];
               a++;
            }


            double multiply = 1;
            int b = 0;

            do
            {
                multiply = multiply * list[b];
                b++;
            }
            while (b < 15);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(difference);
            Console.WriteLine(summa);
            Console.WriteLine(multiply);
            Console.ReadLine();

        }



    }
}
