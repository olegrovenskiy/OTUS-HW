



Console.WriteLine("Enter numbers. Use 0 for finish.");
Node root = null;

while (true)
{
    var s = Console.ReadLine();
    var d = double.Parse(s);
    if (d == 0)
    {
        break;
    }
    if (root == null)
    {
        root = new Node()
        {
            Value = d
        };
        Console.WriteLine(root.GetHashCode);
    }
    else
    {
        AddNode(root, new Node
        {
            Value = d
        });
    }
}

//Console.WriteLine("ROOT" + root.Left.Value);


Console.WriteLine("Sorted numbers:");
Traverse(root);

Console.WriteLine("What number to find?  Use 0 for finish.");


while (true)
{
    var s = Console.ReadLine();
    var d = double.Parse(s);
    if (d == 0)
    {
        break;
    }
    var node = FindNode(root, d);
    if (node == null)
    {
        Console.WriteLine("Not found.");
    }
    else
    {
        Console.WriteLine($"Find {node.Value}");
    }
}



static Node FindNode(Node root, double number)
{
    if (number < root.Value)
    {
        //ищем в левом поддереве
        if (root.Left != null)
        {
            return FindNode(root.Left, number);
        }
        return (null);
    }
    if (number > root.Value)
    {
        //ищем в правом поддереве
        if (root.Right != null)
        {
            return FindNode(root.Right, number);
        }
        return (null);
    }
    return (root);
}






static void AddNode(Node root, Node toAdd)
{
    if (toAdd.Value < root.Value)
    {
        //Идем в левое поддерево
        if (root.Left != null)
        {
            AddNode(root.Left, toAdd);
        }
        else
        {
            root.Left = toAdd;
            Console.WriteLine(root.Left.GetHashCode);
        }
    }
    else
    {
        //Идем в правое поддерево
        if (root.Right != null)
        {
            AddNode(root.Right, toAdd);
            Console.WriteLine(root.Right.GetHashCode);  
        }
        else
        {
            root.Right = toAdd;
        }
    }
}





static void Traverse(Node originiNode)
{

    if (originiNode.Left != null)
    {
        Traverse(originiNode.Left);
    }

    Console.WriteLine("обход" + originiNode.Value);

    if (originiNode.Right != null)
    {
        Traverse(originiNode.Right);
    }
}


public class Node
{

    public double Value { get; set; }

    public Node Left { get; set; }
    public Node Right { get; set; }
}