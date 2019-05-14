using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SoloPoker
{
    class Deck
    {

        List<string> deck_suits = new List<string>{"Hearts", "Diamonds", "Spades", "Clubs"};
        public List<int> value_range = Enumerable.Range(1, 13).ToList();

        List<Card> the_deck = new List<Card>();

        public Deck(Boolean joker = false)
        {
            // Create Cards to put into Deck
            foreach (string suit in deck_suits){
                foreach (int card_value in value_range){
                    the_deck.Add(new Card(card_value, suit));
                }
            }

            if (joker)
                the_deck.Add(new Card(0, "Wilds"));
        }

        public override string ToString()
        {
            string Deck_string  = "";
            foreach (Card temp_card in the_deck)
            {
                Deck_string += temp_card.ToString() +"\n";   
            }

            return Deck_string;
        }
    }
}
