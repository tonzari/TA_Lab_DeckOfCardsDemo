using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TA_Lab_DeckOfCards.Models
{

        // Curious where these models came from?? See the other class "CardDeckModel.cs"
        // There are some comments there that describe how these classes were created
        public class DrawCardsModel
        {
            public bool success { get; set; }
            public string deck_id { get; set; }
            public Card[] cards { get; set; }
            public int remaining { get; set; }
        }

        public class Card
        {
            public string code { get; set; }
            public string image { get; set; }
            public Images images { get; set; }
            public string value { get; set; }
            public string suit { get; set; }
        }

        public class Images
        {
            public string svg { get; set; }
            public string png { get; set; }
        }
}
