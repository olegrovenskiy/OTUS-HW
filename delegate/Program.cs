
using System.Diagnostics;


var timer = new Stopwatch();

int a = 1;

timer.Restart();
for (int i=1; i < 100000000; i++)
{
    a = a * i;
}
timer.Stop();


Console.WriteLine("time for        " + timer.ElapsedTicks);

a = 1;

timer.Restart();
for (int i = 1; i < 100000000; i++)
{
    a = a * i;
}
timer.Stop();


Console.WriteLine("time for       " + timer.ElapsedTicks);

