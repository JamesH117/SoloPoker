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
            return String.Format("{0} of {1}", value, suit);
        }
    }
}
