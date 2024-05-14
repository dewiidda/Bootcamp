class Collection
{
    Dictionary<string, int> ages = new Dictionary<string, int>();
    ages.Add("John", 30);
    ages.Add("Jane", 25);
    Console.WriteLine($"John's age: {ages["John"]}");

    //ArrayList
    ArrayList arrayList = new ArrayList();
    arrayList.Add(1);
    arrayList.Add("Two");
    foreach (var item in arrayList)
    {
        Console.WriteLine(item);
    }

    //List
    List<string> bp = new List<string> { "Aisya","Rina","Mili" };
    foreach (var member in bp)
    {
        Console.WriteLine(member);
    }

    //LinkedList
    LinkedList<int> linkedList = new LinkedList<int>();
    linkedList.AddLast(1);
    linkedList.AddLast(2);
    foreach (var item in linkedList)
    {
        Console.WriteLine(item);
    }

    //HashSet, unique
    HashSet<int> set = new HashSet<int> { 1, 2, 2, 3 };
    foreach (var number in set)
    {
        Console.WriteLine(number); // Outputs: 1, 2, 3
    }

    //Stack LIFO
    Stack<int> stack = new Stack<int>();
    stack.Push(1);
    stack.Push(2);
    Console.WriteLine(stack.Pop()); // Outputs: 2

    //Queue FIFO
    Queue<int> queue = new Queue<int>();
    queue.Enqueue(1);
    queue.Enqueue(2);
    Console.WriteLine(queue.Dequeue()); // Outputs: 1

}