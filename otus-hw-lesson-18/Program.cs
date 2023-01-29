using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;


// Programm 1

/*


var venera = new {Name = "Venera", Number = 2, Equator_km = 38000, Previous = "null"};

var earth = new { Name = "Earth",  Number = 3, Equator_km = 40000, Previous = venera };

var mars = new { Name = "Mars", Number = 4, Equator_km = 21300, Previous = earth };

var venera1 = new { Name = "Venera", Number = 2, Equator_km = 38000, Previous = "null" };


// Вывести в консоль информацию обо всех созданных "планетах". 

Console.WriteLine(venera);
Console.WriteLine(earth);
Console.WriteLine(mars);
Console.WriteLine(venera1);

// вывести эквивалентна ли она Венере

Console.WriteLine("Earth Equals to Venera= " + earth.Equals(venera));
Console.WriteLine("Mars Equals to Venera = " + mars.Equals(venera));
Console.WriteLine("Venera1 Equals to Venera = " + venera1.Equals(venera));

*/


// Programm 2

/*


var venera = new planeta ("Venera", 2, 38000, null );
var earth = new planeta ("Earth", 3, 40000, venera);
var mars = new planeta ("Mars", 4, 21300, earth );

var catalog = new PlanetCatalog(venera, earth, mars);

catalog.GetPlanet("Earth");
catalog.GetPlanet("Limonia");
catalog.GetPlanet("Mars");


// Написать обычный класс "Планета" со свойствами "Название", "Порядковый номер от Солнца", "Длина экватора",
// "Предыдущая планета" (ссылка на предыдущую Планету).
public class planeta

{
    public planeta (string _name, int _number, int _equator, planeta _previous)
    {
    
        Name = _name;
        Number = _number;
        Equator_km= _equator;
        Previous = _previous;

            }

    public string Name { get; set; }
    public int Number { get; set; }
    public int Equator_km { get; set; }
    public planeta Previous { get; set; }

}

// Написать класс "Каталог планет". В нем должен быть список планет - при создании экземпляра класса сразу заполнять его тремя планетами: Венера, Земля, Марс.
public class PlanetCatalog 

{
    public List<planeta> planets = new List<planeta>();

    private int counter = 0; // счётчик для подсчёта кол-ва вызовов метода

    // конструктор с произвольным числом параметров
    public PlanetCatalog(params planeta[] a)
    {

        foreach (planeta s in a)

        {
            planets.Add(s);
        }

    }

    // метод "получить планету", который на вход принимает название планеты, а на выходе дает порядковый номер планеты от Солнца и длину ее экватора

    // на выходе из метода должны быть три поля: первые два заполнены осмысленными значениями, когда планета найдена, а последнее поле - для ошибки.

    public (int? num, int? equ, string mes) GetPlanet (string _name)
    {


        counter++;

        // проверка частоты запросов, на каждый третий вызов метод "получить планету" должен возвращать строку "Вы спрашиваете слишком часто" 

        if (counter % 3 == 0)

        {
            Console.WriteLine("Вы спрашиваете слишком часто");
            return (null, null, "Вы спрашиваете слишком часто");
        }

        else
        {

// проверка что такая планета существует в списке

            if (planets.Exists(x => x.Name == _name))
            {

                // Для найденных планет в консоль выводить их название, порядковый номер и длину экватора
                Console.WriteLine("Найдена планета PlanetName - {0}, PlanetNumber - {1}, PlanetEquator - {2}",
                    planets.Find(x => x.Name == _name).Name, 
                    planets.Find(x => x.Name == _name).Number,
                    planets.Find(x => x.Name == _name).Equator_km);



                return (
                    planets.Find(x => x.Name == _name).Number,
                    planets.Find(x => x.Name == _name).Equator_km, null);

            }
            else
            {
                Console.WriteLine("Не удалось найти планету");
                return (null, null, "Не удалось найти планету");
            }

        }
    }

}

*/




// Programm 3 

/*

var venera = new planeta("Venera", 2, 38000, null);
var earth = new planeta("Earth", 3, 40000, venera);
var mars = new planeta("Mars", 4, 21300, earth);

var catalog = new PlanetCatalog(venera, earth, mars);

catalog.GetPlanet("Earth", x => x % 3 == 0); // x => x % 3 == 0 - лямбда проверки на третий вызов
catalog.GetPlanet("Limonia", x => x % 3 == 0);
catalog.GetPlanet("Mars", x => x % 3 == 0);



// делегат PlanetValidator
public delegate bool PlanetValidator(int x); 


// Написать обычный класс "Планета" со свойствами "Название", "Порядковый номер от Солнца", "Длина экватора",
// "Предыдущая планета" (ссылка на предыдущую Планету).
public class planeta

{
    public planeta(string _name, int _number, int _equator, planeta _previous)
    {

        Name = _name;
        Number = _number;
        Equator_km = _equator;
        Previous = _previous;

    }

    public string Name { get; set; }
    public int Number { get; set; }
    public int Equator_km { get; set; }
    public planeta Previous { get; set; }

}

// Написать класс "Каталог планет". В нем должен быть список планет - при создании экземпляра класса сразу заполнять его тремя планетами: Венера, Земля, Марс.
public class PlanetCatalog

{
    public List<planeta> planets = new List<planeta>();

    private int counter = 0; // счётчик для подсчёта кол-ва вызовов метода

    // конструктор с произвольным числом параметров
    public PlanetCatalog(params planeta[] a)
    {

        foreach (planeta s in a)

        {
            planets.Add(s);
        }

    }

    // метод "получить планету", который на вход принимает название планеты, а на выходе дает порядковый номер планеты от Солнца и длину ее экватора

    // на выходе из метода должны быть три поля: первые два заполнены осмысленными значениями, когда планета найдена, а последнее поле - для ошибки.

    // добавлен аргумент описывающий способ защиты от слишком частых вызовов - делегат PlanetValidator

    public (int? num, int? equ, string mes) GetPlanet(string _name, PlanetValidator validator)
    {




        // проверка частоты запросов, на каждый третий вызов метод "получить планету" должен возвращать строку "Вы спрашиваете слишком часто" 

        counter++;

        if (validator(counter)) // с помощью делегата

        {
            Console.WriteLine("Вы спрашиваете слишком часто");
            return (null, null, "Вы спрашиваете слишком часто");
        }

        else
        {

            // проверка что такая планета существует в списке

            if (planets.Exists(x => x.Name == _name))
            {

                // Для найденных планет в консоль выводить их название, порядковый номер и длину экватора
                Console.WriteLine("Найдена планета PlanetName - {0}, PlanetNumber - {1}, PlanetEquator - {2}",
                    planets.Find(x => x.Name == _name).Name,
                    planets.Find(x => x.Name == _name).Number,
                    planets.Find(x => x.Name == _name).Equator_km);



                return (
                    planets.Find(x => x.Name == _name).Number,
                    planets.Find(x => x.Name == _name).Equator_km, null);

            }
            else
            {
                Console.WriteLine("Не удалось найти планету");
                return (null, null, "Не удалось найти планету");
            }

        }
    }

}

*/


// Programm 3 c добавлением *, другая лямбда

/*


// Дописать main-метод так, чтобы еще раз проверять планеты "Земля", "Лимония" и "Марс",
// но передавать другую лямбду так, чтобы она для названия "Лимония" возвращала ошибку "Это запретная планета", а для остальных названий - null

var venera = new planeta("Venera", 2, 38000, null);
var earth = new planeta("Earth", 3, 40000, venera);
var mars = new planeta("Mars", 4, 21300, earth);


var catalog = new PlanetCatalog(venera, earth, mars);

PlanetValidator method = name =>
{

    if (name == "Limonia")
    {
        return "Запретная планета";
    }
    return null;
};

catalog.GetPlanet("Earth", method);


catalog.GetPlanet("Limonia", method);


catalog.GetPlanet("Mars", method); 


// делегат PlanetValidator
public delegate string PlanetValidator(string _name); 


// Написать обычный класс "Планета" со свойствами "Название", "Порядковый номер от Солнца", "Длина экватора",
// "Предыдущая планета" (ссылка на предыдущую Планету).
public class planeta

{
    public planeta(string _name, int _number, int _equator, planeta _previous)
    {

        Name = _name;
        Number = _number;
        Equator_km = _equator;
        Previous = _previous;

    }

    public string Name { get; set; }
    public int Number { get; set; }
    public int Equator_km { get; set; }
    public planeta Previous { get; set; }

}

// Написать класс "Каталог планет". В нем должен быть список планет - при создании экземпляра класса сразу заполнять его тремя планетами: Венера, Земля, Марс.
public class PlanetCatalog

{
    public List<planeta> planets = new List<planeta>();

    private int counter = 0; // счётчик для подсчёта кол-ва вызовов метода

    // конструктор с произвольным числом параметров
    public PlanetCatalog(params planeta[] a)
    {

        foreach (planeta s in a)

        {
            planets.Add(s);
        }

    }

    // метод "получить планету", который на вход принимает название планеты, а на выходе дает порядковый номер планеты от Солнца и длину ее экватора

    // на выходе из метода должны быть три поля: первые два заполнены осмысленными значениями, когда планета найдена, а последнее поле - для ошибки.

    // добавлен аргумент описывающий способ защиты от слишком частых вызовов - делегат PlanetValidator

    public (int? num, int? equ, string mes) GetPlanet(string _name, PlanetValidator validator)
    {

        counter++;

        string MessageValidator = validator(_name);

        if (MessageValidator != null)

        {
            Console.WriteLine("Запретная планета");
            return (null, null, MessageValidator);
        }


        // проверка частоты запросов, на каждый третий вызов метод "получить планету" должен возвращать строку "Вы спрашиваете слишком часто" 



        if (counter % 3 == 0) // с помощью делегата

        {
            Console.WriteLine("Вы спрашиваете слишком часто");
            return (null, null, "Вы спрашиваете слишком часто");
        }

        else
        {


            // проверка что такая планета существует в списке

            if (planets.Exists(x => x.Name == _name))
            {

                // Для найденных планет в консоль выводить их название, порядковый номер и длину экватора
                Console.WriteLine("Найдена планета PlanetName - {0}, PlanetNumber - {1}, PlanetEquator - {2}",
                    planets.Find(x => x.Name == _name).Name,
                    planets.Find(x => x.Name == _name).Number,
                    planets.Find(x => x.Name == _name).Equator_km);



                return (
                    planets.Find(x => x.Name == _name).Number,
                    planets.Find(x => x.Name == _name).Equator_km, null);

            }
            else
            {
                Console.WriteLine("Не удалось найти планету");
                return (null, null, "Не удалось найти планету");
            }

        }
    }

}

*/