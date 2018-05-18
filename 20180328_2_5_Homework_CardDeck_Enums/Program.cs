using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20180328_2_5_Homework_CardDeck_Enums.PlayingCards;

namespace _20180328_2_5_Homework_CardDeck_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "_20180328_2_5_Homework_CardDeck_Enums";

            Cards cardDeck = new Cards();

            foreach (Card card in cardDeck.DeckOfCards)
            {
                Console.WriteLine(card.CardName);
            }

            Console.ReadLine();

            // I am going to use a STATIC method within the Cards class - without creating an instance of the CardDeck class
            Cards.WriteALineToTheConsole();

            Console.WriteLine(cardDeck.DrawRandomCard());

            Console.ReadLine();
        }
    }
}
