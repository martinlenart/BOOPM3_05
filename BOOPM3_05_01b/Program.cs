using System;

namespace BOOPM3_05_01b
{
	public enum PlayingCardColor
	{
		Clubs = 0, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace                // Poker Value order
	}
	interface IPlayingCard
	{
		public PlayingCardColor Color { get; init; }
		public PlayingCardValue Value { get; init; }

		string BlackOrRed { get; }
		public string StringToPrint { get; }
	}


	class Program
	{
		static void Main(string[] args)
		{
			// Now I have an implementation and can make an instance
			IPlayingCard card1 = new PlayingCard { Color = PlayingCardColor.Diamonds, Value = PlayingCardValue.Three }; 
			IPlayingCard card2 = new PlayingCard { Color = PlayingCardColor.Spades, Value = PlayingCardValue.Five };

			// no change in code here, but now I can test run
			CompareTwoCards(card1, card2);		
		}

		// no change in code here
		static void CompareTwoCards(IPlayingCard card1, IPlayingCard card2)
		{
			if (card1.Value > card2.Value)
				Console.WriteLine($"{card1.Value} beats {card2.Value}");
			else if (card1.Value < card2.Value)
				Console.WriteLine($"{card2.Value} beats {card1.Value}");

			else
			{
				//Same Value
				if (card1.Color > card2.Color)
					Console.WriteLine($"Both cards same value {card1.Value} but {card1.Color} beats {card2.Color}");
				else
					Console.WriteLine($"Both cards same value {card1.Value} but {card2.Color} beats {card1.Color}");
			}
		}
	}
}
