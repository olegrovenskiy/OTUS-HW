// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.Write("Введите свое имя: ");
//string? name = Console.ReadLine();       // вводим имя
//Console.WriteLine($"Привет {name}");    // выводим имя на консоль
//Console.ReadKey();

int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };

int rows = numbers.GetUpperBound(0) + 1;    // количество строк
int columns = numbers.Length / rows;        // количество столбцов
                                            // или так
                                            // int columns = numbers.GetUpperBound(1) + 1;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{numbers[i, j]} \t");
    }
//    Console.WriteLine();
}