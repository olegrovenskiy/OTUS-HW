
using System;
using System.Collections;
using System.Diagnostics;

 
// 1. Создать коллекции List, ArrayList и LinkedList.

// 2. С помощью цикла for добавить в каждую 1 000 000 элементов (1,2,3,...).

// 3. С помощью Stopwatch.Start() и Stopwatch.Stop() замерить длительность заполнения
// каждой коллекции и вывести значения на экран.


var list = new List<int>();

var timerlist = new Stopwatch();
timerlist.Start();

for (var i = 1; i < 1000001; i++)
{

    list.Add(i);

}

timerlist.Stop();




var arlist = new ArrayList();

var timerarlist = new Stopwatch();
timerarlist.Start();

for (var i = 1; i < 1000001; i++)

{ 
    arlist.Add(i);
}

timerarlist.Stop();


var linklist = new LinkedList<int>();

var timerlinklist = new Stopwatch();
timerlinklist.Start();

for (var i = 1; i < 1000001; i++)

{ 

    linklist.AddLast(i);

}

timerlinklist.Stop();

Console.WriteLine("time for list      " + timerlist.Elapsed);
Console.WriteLine("time for arrlist   " + timerarlist.Elapsed);
Console.WriteLine("time for linklist  " + timerlinklist.Elapsed);


// 4. Найти 496753-ий элемент, замерить длительность этого поиска и вывести на экран.


var timer1 = new Stopwatch();
timer1.Start();
var listelement496753 = list[496753];

timer1.Stop();
Console.WriteLine("time for search element496753 in list          " + timer1.Elapsed);

var timer2 = new Stopwatch();
timer2.Start(); 
var arlistelement496753 = arlist[496753];

timer2.Stop();
Console.WriteLine("time for search element496753 in arrlist       " + timer2.Elapsed);


var timer3 = new Stopwatch();
timer3.Start();
var linkedlistelement496753 = linklist.ElementAt(496753);

timer3.Stop();
Console.WriteLine("time for search element496753 in linklist      " + timer3.Elapsed);

/*
Вывести на экран каждый элемент коллекции, который без остатка делится на 777. 
Вывести длительность этой операции для каждой коллекции.

 */

var timer4 = new Stopwatch();
timer4.Start();

foreach (int element in list)
{

    if (element % 777 == 0)
    {

        Console.WriteLine(element);

    }

}

timer4.Stop();


var timer5 = new Stopwatch();
timer5.Start();

foreach (int element in arlist)
{

    if (element % 777 == 0)
    {

        Console.WriteLine(element);

    }

}
timer5.Stop();

var timer6 = new Stopwatch();
timer6.Start();

foreach (int element in linklist)
{

    if (element % 777 == 0)
    {

        Console.WriteLine(element);

    }

}
timer6.Stop();

Console.WriteLine("time for print 777 devided by zero in list          " + timer4.Elapsed);
Console.WriteLine("time for print 777 devided by zero in Array list    " + timer5.Elapsed);
Console.WriteLine("time for print 777 devided by zero in Linked list   " + timer6.Elapsed);



