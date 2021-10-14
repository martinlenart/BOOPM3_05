﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		PlayingCardColor Color { get; init; }
		/// <summary>
		/// The value Two - Ace of the card
		/// </summary>
		PlayingCardValue Value { get; init; }

		/// <summary>
		/// Returns a string containing "Red" for Hearts and Diamonds, otherwise "Black"
		/// </summary>
		string BlackOrRed { get; }
		public string StringToPrint { get; }
	}
}
