using System;
using System.Data;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



string[] abcValues = new string[] { ">a :\nb  :\nc  :", "a  :\n>b :\nc  :", "a  :\nb  :\n>c :\n" };



Console.Write(abcValues[0]);
Console.SetCursorPosition(5, 0);



//Console.Write(abcValues[1]);

//Console.Write(abcValues[2]);



ConsoleKeyInfo ki;
int position = 0;
int[] positionIndex = new int[] { 2, 0, 1 };

do
{



    ki = Console.ReadKey();
    switch (ki.Key)

    {
        case ConsoleKey.DownArrow:

            position++;
            position = (position) % 3;
            Console.SetCursorPosition(0,0);
            Console.Write(abcValues[position]);
            Console.SetCursorPosition(5, position);
            //          Console.WriteLine("позиция вниз clear" + positionClear);


            break;

            case ConsoleKey.UpArrow:

            position++;
            //position = Math.Abs(position);
            position = (position) % 3;
            Console.SetCursorPosition(0,0);
            Console.Write(abcValues[positionIndex[position]]);
            Console.SetCursorPosition(5, positionIndex[position]);



            break;

             default:

                 break;
     
    }
    
    }

while (ki.Key != ConsoleKey.Enter);


/*





ConsoleKeyInfo ki;
            
int positionSet = 0;
int position = 0;


            Console.WriteLine(" a: ");
            Console.WriteLine(" b: ");
            Console.WriteLine(" c: ");



Console.SetCursorPosition(0, position);
Console.WriteLine(">");
Console.SetCursorPosition(5, position);

int[] positionDown = new int[] {0,1,2};
int[] positionClearDown = new int[] {2,0,1};


int[] positionUp = new int[] {0,2,1};
int[] positionClearUp = new int[] { 2,1,1 };


int positionClear = 0;

do
            {



            ki = Console.ReadKey();
    switch (ki.Key)

    {
        case ConsoleKey.DownArrow:

            position++;
            positionSet = positionDown[(position) % 3];
            positionClear = positionClearDown[positionSet];
  //          Console.WriteLine("позиция вниз" + positionSet);
  //          Console.WriteLine("позиция вниз clear" + positionClear);


            break;

          case ConsoleKey.UpArrow:
              positionSet = positionUp[(position) % 3];
   //         positionClear = positionClearUp[positionSet];
  //          Console.WriteLine("позиция вверх" +position);
   
            break;
  
        default:

            break;

    }           

    Console.SetCursorPosition(0, positionSet);
    Console.WriteLine(">");
    Console.SetCursorPosition(0, positionClear);
//    Console.WriteLine(" ");
    Console.SetCursorPosition(5, positionSet);

                

            } while (ki.Key != ConsoleKey.Enter);



*/





