﻿//Method => return type => float

using System.Reflection;

public delegate float MyDelegate(int a, int b);

class Program
{
	static void Main()
	{
		Subscriber subscriber = new();
		
		MyDelegate del= subscriber.Add;
		del += subscriber.Mul;
		
		float result = del(5,5);
		
		Delegate[] dell = del.GetInvocationList();
		foreach(Delegate dg in dell)
		{
			Console.WriteLine(dg.GetMethodInfo().Name+":"+((MyDelegate)dg).Invoke(5,5));
		}
	}
}

class Subscriber
{
	public float Add(int a, int b)
	{
		return (a+b);
	}

	public float Mul(int a, int b)
	{
		return (a*b);
	}
}