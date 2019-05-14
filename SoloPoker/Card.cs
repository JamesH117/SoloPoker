using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloPoker
{
    class Card : Node
    {
        private int value;
        private string suit;

        IDictionary<int, string> face_dict = new Dictionary<int, string>(){
                                                {0, "Joker"},
                                                {1,"Ace"},
                                                {11,"Jack"},
                                                {12, "Queen"},
                                                {13,"King"}
                                            };

        public Card(int value, string suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public Tuple<int, string> GetCard()
        {
            return Tuple.Create(this.value, this.suit);
        }

        public int GetValue()
        {
            return this.value;
        }

        public string GetSuit()
        {
            return this.suit;
        }

        public override string ToString()
        {  
            if (value >= 11 || value <= 1)
                return String.Format("{0} of {1}", face_dict[value], suit);

            return String.Format("{0} of {1}", value, suit);

        }
    }
}
