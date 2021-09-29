﻿using System;

namespace BOOPM3_05_01a
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
		string FaceOrValue { get; }
		public string StringToPrint { get; }
	}


	class Program
	{
        static void Main(string[] args)
        {
			// As I only have an interface I cannot create an instance, I use null instead
			IPlayingCard card1 = null;			
			IPlayingCard card2 = null;

			// But I can write my code and compile
			CompareTwoCards(card1, card2);		
		}

		// My parameters are of type IPlayingCard
		static void CompareTwoCards (IPlayingCard card1, IPlayingCard card2)
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
