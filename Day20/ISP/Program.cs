﻿//Liskov Subtitution Principle
class Bird
{
	//properties or method bird
	
}

interface IFlyable
{
	void Fly();
}

class Ostrich : Bird
{
	//public override void Fly()
	//{
	//	throw new NotImplementedException("Ostrich can't fly");
	//}
}

class Eagle : Bird, IFlyable
{
	public void Fly()
	{
		
	}
}

