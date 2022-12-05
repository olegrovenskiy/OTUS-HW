
bool result = false;

int n;  // размерность таблицы

do
{

    Console.WriteLine("введите размерность таблицы (число от 1 до 6):");

    string? input = Console.ReadLine();

    result = int.TryParse(input, out int number);
    n = number;

    result = (n <= 6) & (n >= 1) & result;

}

while (result == false);



string text; // текст таблицы
bool textCheck = false;
int textLength = 0;
bool checkTextLenhth = false;
bool check = false;

do
{


    Console.WriteLine("введите произвольный текст, не более 28 символов:");

    text = Console.ReadLine();

    textCheck = !string.IsNullOrEmpty(text);

    textLength = text.Length;

    if (textLength <= 28)
    {

        checkTextLenhth = true;

    }

    check = checkTextLenhth & textCheck;
        
}

while (check == false);

Table1 (n, text);

Table2 (n, text);

Table3 (n, text);



// Table 2 method


static void Table2(int n, string text)

{

    int a; //Table length
    int b; //высота таблицы

    int textLength = text.Length;  // for method

    a = 2 + (n - 1) * 2 + textLength; // расчёт размера ширины таблицы
    b = (n - 1) * 2 + 2;

    for (int j = 1; j < b; j++)
    {

        Console.Write("+");
        for (int i = 1; i < a - 1; i++)
        {

            if (j % 2 == 0)
            {
                if ((i % 2) == 0)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            else if (j % 2 == 1)
            {
                if ((i % 2) == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("+");
                }
            }



            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine("+");

    }

  }

// Table 3 method

static void Table3(int n, string text)

{
    Gorisontal(n, text);

    int a; //Table length
    int b; //высота таблицы

    int textLength = text.Length;  // for method

    a = 1 + (n - 1) * 2 + textLength; // расчёт размера ширины таблицы


    int point1 = 1;
    int point2 = a - 1;


    for (int j = 1; j < a; j++)
    {

        Console.Write("+");
        for (int i = 1; i < a; i++)
        {

            if (i == point1)
            {
                Console.Write("+");
                //            point1 = point1 + 1;
            }

            else if (i == point2)
            {
                Console.Write("+");
                //            point2 = point2 - 1;
            }

            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine("+");
        point1 = point1 + 1;
        point2 = point2 - 1;
    }

    Gorisontal(n, text);
}

// method gorisontal line

static void Gorisontal (int n, string text)

{

    int a; //Table length
           //    int b; //высота таблицы

    int textLength = text.Length;  // for method

    a = 2 + (n - 1) * 2 + textLength; // расчёт размера ширины таблицы

    string GorisontalLine = "+";

    for (int i = 1; i < a; i++)

    {

        GorisontalLine = GorisontalLine + "+";

    }

    Console.WriteLine(GorisontalLine);

}

// method Table1 

static void Table1 (int n, string text)

{

    Gorisontal(n, text);

    int a; //Table length
    int b; //высота таблицы
    int textLength = text.Length;

    a = 2 + (n - 1) * 2 + textLength; // расчёт размера ширины таблицы
    b = (n - 1) * 2 + 2;    

    string probel = " ";

    string probel2 = " ";

    for (int i = 1; i < n - 1; i++)

    {

        probel = probel + " ";

    }

    for (int i = 1; i < a-2; i++)

    {
    
        probel2 = probel2 + " ";

    }

    string test1 = "+" + probel + text + probel + "+"; // строка в центре

    string test2 = "+" + probel2 + "+";  // строка +    +

    for (int j = 1; j < b; j++)
    {

        if (j == n)
        {
               Console.WriteLine(test1);
        }
        else
        {

            Console.WriteLine(test2);
        }
    }

    Gorisontal(n, text);
}

