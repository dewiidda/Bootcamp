class Program
{
    static void Main()
    {
        /*
        Dictionary: Suppose you’re developing a phone book application. 
        You could use a Dictionary to store contact information, 
        with the person’s name as the key and their phone number as the value.
        */
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        phoneBook.Add("John Doe", "123-456-7890");
        phoneBook.Add("Jane Smith", "098-765-4321");
        Console.WriteLine($"John Doe's Phone: {phoneBook["John Doe"]}");

        /*
        ArrayList: Suppose you’re developing a to-do list application 
        where the user can add tasks of different types (strings, dates, etc.). 
        An ArrayList would be a good choice because it can store any type of object.
        */
        ArrayList toDoList = new ArrayList();
        toDoList.Add("Buy groceries");
        toDoList.Add("Meeting at 10 AM");
        foreach (var task in toDoList)
        {
            Console.WriteLine(task);
        }

        /*
        List: Suppose you’re developing a game and you need to keep track of 
        the scores of each player. 
        A List would be a good choice because it provides fast access to elements 
        based on an index.
        */
        List<int> scores = new List<int> { 10, 20, 30, 40 };
        foreach (var score in scores)
        {
            Console.WriteLine(score);
        }

        /*
        LinkedList: Suppose you’re developing an application where you frequently need 
        to add and remove items from both ends (like a history navigation feature in 
        a web browser). 
        A LinkedList would be a good choice because it provides efficient insertions 
        and deletions at both ends.
        */
        LinkedList<string> history = new LinkedList<string>();
        history.AddLast("Page 1");
        history.AddLast("Page 2");
        Console.WriteLine(history.First.Value); // Outputs: Page 1
        
        /*
        HashSet: Suppose you’re developing an application to analyze text, 
        and you need to keep track of unique words in a large document. 
        A HashSet would be a good choice because it provides fast lookups 
        and automatically removes duplicates.
        */
        HashSet<string> uniqueWords = new HashSet<string> { "apple", "banana", "apple" };
        foreach (var word in uniqueWords)
        {
            Console.WriteLine(word); // Outputs: apple, banana
        }

        /*
        Stack: Suppose you’re developing a calculator application that needs 
        to evaluate an expression using the reverse Polish notation. 
        A Stack would be a good choice because it provides a last-in, 
        first-out data structure.
        */
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        Console.WriteLine(stack.Pop()); // Outputs: 2

        /*
        Queue: Suppose you’re developing a print spooler application 
        where print jobs need to be processed in the order they were received. 
        A Queue would be a good choice because it provides a first-in, first-out 
        data structure.
        */
        Queue<string> printQueue = new Queue<string>();
        printQueue.Enqueue("Document1");
        printQueue.Enqueue("Document2");
        Console.WriteLine(printQueue.Dequeue()); // Outputs: Document1

    }
}