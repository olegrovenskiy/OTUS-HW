using System.ComponentModel.DataAnnotations;


var ssss = new StackItem("gg", null);

Console.WriteLine(ssss.stackitem);

Console.WriteLine(ssss.StackPrevious);

var ssss1 = new StackItem("tt", ssss);

Console.WriteLine(ssss1.stackitem);

Console.WriteLine(ssss1.StackPrevious.stackitem);


/* проверка основной части

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

*/


/* проверка Доп задания 1

var s = new Stack("a", "b", "c");
s.Merge(new Stack("1", "2", "3"));
// в стеке s теперь элементы - "a", "b", "c", "3", "2", "1" <- верхний

Console.WriteLine(s.Top);

*/

// Проверка доп задания 2

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



// необходимый класс
public class Stack

{
    public List<string> stackSave = new List<string>();



    // конструктор с произвольным числом параметров
    public Stack(params string[] a)
    {

        foreach (string s in a)

        {

            stackSave.Add(s);

        }

    }

    // метод добавления в стек

    public void Add(string newelement)

    {
        stackSave.Add(newelement);
    }

    // метод вытаскивания элемента и удаления

    public string Pop()
    {

        string pops;

        if (stackSave.Count == 0)

        {

            throw new NoResultException("Стек пустой");

        }

        else
        {
            pops = stackSave[stackSave.Count - 1];
            stackSave.RemoveAt((stackSave.Count - 1));
            return pops;
        }
    }



    // свойство размер


    public int Size
    {
        get { return stackSave.Count; }
    }



    // свойство верхний элемент

    public string Top
    {
        get
        {

            if (stackSave.Count == 0)
            {
                return "null";
            }

            else
            {
                return stackSave[stackSave.Count - 1];
            }
        }
    }


    // Доп. задание 2

    public static Stack Concat (params Stack[] s)

    {

        var sss = new Stack();

        foreach (Stack s2 in s)
        {

            sss.Merge(s2);

        }

        return sss;


    }


}

// Доп. задание 1
public static class StackExtensions

{

    public static void Merge (this Stack stack1, Stack stack2)
    {

        for (var i = 0; i < stack2.Size; i++)


        stack1.Add(stack2.stackSave[stack2.Size-1-i]);

    }

}



// доп задание 3




public class StackItem
{
    public string stackitem;
    public int pointer = 0;
    public StackItem StackPrevious;


    public StackItem (string k, StackItem item)

    {
    
        stackitem = k;
        Interlocked.Increment (ref pointer);
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
