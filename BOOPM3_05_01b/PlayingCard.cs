using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOPM3_05_01b
{
    class PlayingCard : IPlayingCard
    {
		PlayingCardColor _color;
		public PlayingCardColor Color
		{ 
		  get {return _color; }
		  init { _color = value; } 
		}
		public PlayingCardValue Value { get; init; }

		public string BlackOrRed
		{
			get
			{
				if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
					return "Black";

				return "Red";
			}
		}
		public string StringToPrint => $"{Value} of {Color}, a {BlackOrRed} card";
	}
}
