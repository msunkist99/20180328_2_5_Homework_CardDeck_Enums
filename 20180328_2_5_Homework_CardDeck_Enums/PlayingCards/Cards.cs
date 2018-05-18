using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180328_2_5_Homework_CardDeck_Enums.PlayingCards
{
    class Cards
    {
        public List<Card> DeckOfCards { get; }

        // constructor 1 - this code is excuted when a CardDeck object is created from this class
        public Cards()
        {
            DeckOfCards = new List<Card>();
            for (Suits suitsEnum = 0; suitsEnum < Suits.OverTheMaxValue; suitsEnum++)
            {
                for (CardValues cardValuesEnum = CardValues.Ace; cardValuesEnum < CardValues.OverTheMaxValue; cardValuesEnum++)
                {
                    Card card = new Card() { SuitsEnum = suitsEnum, CardValuesEnum = cardValuesEnum };
                    this.DeckOfCards.Add(card);
                }
            }
        }

        public string DrawRandomCard()
        {
            Random random = new Random();
            int randomCardIndex = random.Next(0, this.DeckOfCards.Count + 1);

            return this.DeckOfCards[randomCardIndex].CardName;
        }

        //  This is a STATIC method within the CardDeck class
        //  Because it is STATIC you do not have to create an istance of the CardDeck class to call this method.
        public static void WriteALineToTheConsole()
        {
            Console.WriteLine("\r\nThis line is written from a STATIC method - your randomly drawn card -  ");
        }
    }
}
