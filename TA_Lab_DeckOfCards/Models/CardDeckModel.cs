using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TA_Lab_DeckOfCards.Models
{
    // This class - where did it come from? Who created it? Why?? 
    // Remember, first, we look at our API of choice and ask ourselves: what do we want from this API?
    // In this demo, we know that we want a DECK OF CARDS from the API. 
    // So we look at the API docs to see if it will give us a deck of cards. The answer is yes! There is a URL that will supply that. (this can be reffered to as an "endpoint".)
    // Which URL will give us a DECK OF CARDS?
    // Did you go look? Go! Please! https://deckofcardsapi.com/
    // Mmmk, so hopefully you found the URL we need. Enter that URL in postman or the mozilla web browser - whatever tool you know will give you the response you want: raw JSON!
    // Copy that JSON.
    // Now in Visual studio, make a new class.
    // Use the fancy pantsy Visual studio feature, "Paste Special"
    // ... found here: Edit/Paste Special/Paste JSON as Classes (as you see by the name, it will automatically convert JSON objects into C# classes)
    // and BAM. You get what you see below, more or less. 
    // You can change the class name ALL YOU WANT! BUT....
    // DO NOT change the property names. It will confuse the JSON converter.
    public class CardDeckModel
    {
        public bool success { get; set; }
        public string deck_id { get; set; }
        public int remaining { get; set; }
        public bool shuffled { get; set; }
    }
}
