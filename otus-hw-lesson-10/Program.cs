// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("a * x^2 + b * x + c = 0");

IDictionary<string, string> data = new Dictionary<string, string>()
{
    { "a", "0"},
    { "b", "0"},
    { "c", "0"}
};



int a;
int b;
int c;
int i = 5;


while (i == 5)

{


    InputData(data);

    try
    {


        a = int.Parse(data["a"]);
        b = int.Parse(data["b"]);
        c = int.Parse(data["c"]);

    }

    catch (FormatException)
    {
        Severity error1 = Severity.Error;

        FormatData("возникла ошибка ввода", error1, data);

        continue;
    }

    catch (OverflowException)
    {

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("Данные должны быть в диапазоне -2147483647 -- +2147483647");
        Console.ResetColor();
        continue;

    }


    break;

}

// Расчёт значений уравнения


a = int.Parse(data["a"]);
b = int.Parse(data["b"]);
c = int.Parse(data["c"]);




try
{

    result(a, b, c);

}

catch

{

    Severity error1 = Severity.Warning;

    FormatData("Вещественных значений не найдено", error1, data);

}

Console.WriteLine("КОНЕЦ ПРОГРАММЫ");

// функция расчёта корней квадратного уровнения

static void result (int a, int b, int c)

{ 


int Discriminant = b * b - 4 * a * c;

Console.WriteLine("Discriminant = " +Discriminant);

if (Discriminant > 0)

{

    var x1 = (-b + Math.Sqrt(Discriminant)) / (2 * a);

    var x2 = (-b - Math.Sqrt(Discriminant)) / (2 * a);

    Console.WriteLine("x1 =  " + x1);
    Console.WriteLine("x2 =  " + x2);

}

else if (Discriminant == 0)

{

    var x = (-b) / (2 * a);

    Console.WriteLine("x =  " + x);

}

else
{

    throw new NoResultException("Вещественных значений не найдено");

}

}

// Функция Format Data из условия

static void FormatData(string message, Severity severity, IDictionary<string, string> data)

{
    Console.WriteLine(new String('-', 50));

    if (severity == Severity.Error)
    { 

    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Red;
    }

    else

    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Yellow;

    }


    Console.WriteLine("сообщение   " +message);

    Console.ResetColor();

    foreach (string data1 in data.Keys)
    {

        if (int.TryParse(data[data1], out int number) == false)

        {

            Console.WriteLine("Параметр  " + data1 + "   " + data[data1]);
        }

    }

}


// Функция ввода данных

static void InputData(IDictionary<string, string> dataInput)

{


    foreach (string data1 in dataInput.Keys)
    {

        Console.WriteLine("Введите значение  " + data1);
        dataInput[data1] = Console.ReadLine();
 //       Console.WriteLine(dataInput[data1]);

    }

}

// Собственное исключение


class NoResultException : Exception

{

public NoResultException (string message) : base (message)

    {

    }

}

enum Severity
{
    Warning,
    Error
}

