//Method => return type => float

using System.Reflection;
class Program
{
	static void Main()
	{
		Subscriber subscriber = new();

		//Multicast delegate -> delegate holds reference to more than one handler function
		//We can add more reference to hold by using +=
		MyDelegate del= subscriber.Add;
		del += subscriber.Mul;
		
		float result = del(5,5);
		//We only call the last method(with return type)
		//We can use array and save it using GetInvocationList
		Delegate[] dell = del.GetInvocationList();
		foreach(Delegate dg in dell)
		{
			Console.WriteLine(dg.GetMethodInfo().Name+":"+((MyDelegate)dg).Invoke(5,5));
		}
	}
}
