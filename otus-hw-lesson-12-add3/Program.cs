using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

/*
var ssss = new StackItem("gg", null);

Console.WriteLine(ssss.stackitem);

Console.WriteLine(ssss.StackPrevious);

var ssss1 = new StackItem("tt", ssss);

Console.WriteLine(ssss1.stackitem);

Console.WriteLine(ssss1.StackPrevious.stackitem);
*/

//проверка основной части

var s = new Stack("a", "b", "c");


// size = 3, Top = 'c'
Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
var deleted = s.Pop();
// Извлек верхний элемент 'c' Size = 2
Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
s.Add("d");
// size = 3, Top = 'd'
Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
s.Pop();
s.Pop();
s.Pop();
// size = 0, Top = null
Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
s.Pop();




/* проверка Доп задания 1

var s = new Stack("a", "b", "c");
s.Merge(new Stack("1", "2", "3"));
// в стеке s теперь элементы - "a", "b", "c", "3", "2", "1" <- верхний

Console.WriteLine(s.Top);

*/

// Проверка доп задания 2

/*

var s = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
// в стеке s теперь элементы - "c", "b", "a" "3", "2", "1", "В", "Б", "А" <- верхний




Console.WriteLine(s.stackSave[0]);
Console.WriteLine(s.stackSave[1]);
Console.WriteLine(s.stackSave[2]);
Console.WriteLine(s.stackSave[3]);
Console.WriteLine(s.stackSave[4]);
Console.WriteLine(s.stackSave[5]);
Console.WriteLine(s.stackSave[6]);
Console.WriteLine(s.stackSave[7]);
Console.WriteLine(s.stackSave[8]);

*/

// необходимый класс
public class Stack

{
    private int maxSize = 10;  // максимальное количество элементов в стеке, задано 10

    public List<string> stackSave = new List<string>();

    public ArrayList stackList = new ArrayList();



    // конструктор с произвольным числом параметров

    public int i = 0;

    public Stack(params string[] a)
    {

        foreach (string s in a)

        {
            if (i == 0)
            {
                stackList.Add(new StackItem(s, null));
            }
            else
            {
                stackList.Add(new StackItem(s, (StackItem)stackList[i - 1]));
            }
            i++;

        }

    }

    // метод добавления в стек

    public void Add(string newelement)

    {
        if (maxSize == stackList.Count)
            throw new NoResultException("Стек заполнен");

        stackList.Add(new StackItem(newelement, (StackItem)stackList[stackList.Count - 1]));
    }

    // метод вытаскивания элемента и удаления

    public string Pop()
    {

        StackItem pops;

        if (stackList.Count == 0)

        {

            throw new NoResultException("Стек пустой");

        }

        else
        {
            //            pops = stackSave[stackSave.Count - 1];
            //            stackSave.RemoveAt((stackSave.Count - 1));

            pops = (StackItem)stackList[stackList.Count - 1];
            stackList.RemoveAt(stackList.Count - 1);


            return pops.stackitem;
        }
    }



    // свойство размер


    public int Size
    {
        get { return stackList.Count; }
    }



    // свойство верхний элемент

    public string Top
    {
        get
        {

            if (stackList.Count == 0)
            {
                return "null";
            }

            else
            {
                return ((StackItem)stackList[stackList.Count - 1]).stackitem;
            }
        }
    }





    // доп задание 3




    public class StackItem
    {
        public string stackitem;
        public int pointer = 0;
        public StackItem StackPrevious;


        public StackItem(string k, StackItem item)

        {

            stackitem = k;
            Interlocked.Increment(ref pointer);
            //       pointer++;  
            StackPrevious = item;

        }


    }



    // **********************************










    class NoResultException : Exception

    {

        public NoResultException(string message) : base(message)

        {

        }

    }

}


