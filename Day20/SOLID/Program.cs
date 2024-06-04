class GameController
{
	private Dictionary<IPlayer, List<ICard>> players = new();
	private List<ICard> cards = new();
	
	public bool SetDataPlayer(IPlayer player, List<ICard> cards)
	{
		if(players != null)
		{
			players.Add(player, cards);
			return true;
		}
		return false;
	}
	public List<ICard> GetPossibleCard(IPlayer player)
	{
		return players[player];
	}
	
	public bool SetCards(ICard card)
	{
		cards.Add(card);
		return true;
	}
	
	public List<ICard> GetAllCards()
	{
		return cards;
	}
}

class Program
{
	static void Main()
	{
		GameController gameController = new();
		Player playerA = new();
		Player playerB = new();
		Card card1 = new("Monster",445);
		Card card2 = new("Trap",245);
	
		List<ICard> cards = new() {card1, card2};
		Card card3 = new("Spell",545);
		Card card4 = new("Demit",845);
		List<ICard> cards2 = new() {card3, card4};

		//gameController.players = new Dictionary<IPlayer, List<ICard>>()
		//{
		//	{playerA, cards},
		//	{playerB, cards2}
		//};
		
		gameController.SetDataPlayer(playerA,cards);	
		gameController.SetDataPlayer(playerB,cards2);
		
		var possibleCard = gameController.GetPossibleCard(playerA);
		
		//foreach(var card in possibleCard)
		//{
		//	card.Name.Dump();
		//}
		
		gameController.SetCards(card1);
		gameController.SetCards(card2);
		gameController.SetCards(card3);
		gameController.SetCards(card4);
		
		var cardss = gameController.GetAllCards();

		foreach (ICard card in cardss)
		{
			var name = card.Name;
			var gold = ((Card)card).Price;
			Console.WriteLine($"Name: { name} and gold {gold}");
		}
	}
}

class Player : IPlayer { }
class Card : ICard
{
	public string Name { get; private set; }
	public int Price {get;private set;}
	public Card(string name, int price)
	{
		Name = name;
		Price = price;
	}
	
	public bool SetPrice(int price)
	{
		Price = price;
		return true;
	}
}
interface IPlayer { }
interface ICard
{
	public string Name {get;}
}