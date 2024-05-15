﻿internal class Program
{
   static void Main()
    {
	//anonymous method
	Func<int, int, int> addFunc2 = delegate (int x, int y) { return x + y; };
	Action<int, int> addAction2 = delegate (int x, int y) { Console.WriteLine((x + y)); };

	//lambda expression
	Func<int, int, int> addFunc = (x, y) => x + y;
	Action<int, int> addAction = (x,y) => Console.WriteLine(x+y);
	
	//non-delegate
	var add = (int x, int y) => x + y;
	Console.WriteLine(add(2,6));
	}
}