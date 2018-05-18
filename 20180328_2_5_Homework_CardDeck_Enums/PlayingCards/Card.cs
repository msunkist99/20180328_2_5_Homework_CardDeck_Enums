using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180328_2_5_Homework_CardDeck_Enums.PlayingCards
{
    class Card
    {
        public int Suit { get; set; }
        public int Value { get; set; }
        public Suits SuitsEnum { get; set; }
        public CardValues CardValuesEnum { get; set; }

        public String CardName
        {
             get
            {
                return CardValuesEnum + " of " + SuitsEnum;
            }
        }
    }

    public enum Suits
    {
        Clubs = 0,
        Spades,
        Hearts,
        Diamonds,
        OverTheMaxValue
    }

    public enum CardValues
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        OverTheMaxValue
    }
}
