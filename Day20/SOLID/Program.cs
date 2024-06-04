class GameController
{
	internal Dictionary<IPlayer, List<ICard>> players;
	
	public List<ICard> GetPossibleCard(IPlayer p)
	{
		return players[p];
	}
}

class Program
{
	static void Main()
	{
		GameController gameController = new();
		Player playerA = new();
		Player playerB = new();
		Card card1 = new("Monster");
		Card card2 = new("Trap");
		List<ICard> cards = new() {card1, card2};
		Card card3 = new("Spell");
		Card card4 = new("Demit");
		List<ICard> cards2 = new() {card3, card4};

		gameController.players = new Dictionary<IPlayer, List<ICard>>()
		{
			{playerA, cards},
			{playerB, cards2}
		};
		
		var possibleCard = gameController.GetPossibleCard(playerA);
		
		foreach(var card in possibleCard)
		{
			Console.WriteLine(card.Name);
		}
	}
}

class Player : IPlayer { }
class Card : ICard
{
	public string Name {get;private set;}
	public Card(string name)
	{
		Name = name;
	}
}
interface IPlayer { }
interface ICard
{
	public string Name {get;}
}