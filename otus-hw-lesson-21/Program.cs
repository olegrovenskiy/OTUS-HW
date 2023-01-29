
using System.Diagnostics;


var timer = new Stopwatch();

Console.WriteLine("Рекурсия");

int fib = 0;

timer.Restart();
//Console.WriteLine(fibonachi_r(5));
fib = fibonachi_r(5);
timer.Stop();
Console.WriteLine("time for n = 5       " + timer.ElapsedTicks);

timer.Restart();
//Console.WriteLine(fibonachi_r(10));
fib = fibonachi_r(10);
timer.Stop(); 
Console.WriteLine("time for n = 10      " + timer.ElapsedTicks);


timer.Restart();
//Console.WriteLine(fibonachi_r(20));
fib = fibonachi_r(20);
timer.Stop();
Console.WriteLine("time for n = 20      " + timer.ElapsedTicks);



Console.WriteLine("------------------------------------------");
Console.WriteLine("Цикл");


timer.Restart();
//Console.WriteLine(fibonachi_c(5));
fib = fibonachi_c(5);
timer.Stop();
Console.WriteLine("time for n = 5       " + timer.ElapsedTicks);



timer.Restart();
//Console.WriteLine(fibonachi_c(10));
fib = fibonachi_c(10);
timer.Stop();
Console.WriteLine("time for n = 10      " + timer.ElapsedTicks);



timer.Restart();
//Console.WriteLine(fibonachi_c(20));
fib = fibonachi_c(20);
timer.Stop();
Console.WriteLine("time for n = 20      " + timer.ElapsedTicks);


// метод вычисления чисел Фибоначи с пом рекурсии

int fibonachi_r (int number)
    {

    if (number == 2 | number == 3)
    {
        return 1;
    }

    return fibonachi_r(number-2) + fibonachi_r(number-1);
}


// метод вычисления чисел Фибоначи с пом цикла

int fibonachi_c (int number)
{
    int result = 0;
    int pre_prev = 0;
    int prev = 1;

    for (int i = 1; i < number-1; i++)
    {
        result = pre_prev + prev;
        pre_prev = prev;
        prev = result;
    }

    return result;  
    }