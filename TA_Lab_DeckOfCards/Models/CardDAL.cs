using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace TA_Lab_DeckOfCards.Models
{
    public class CardDAL
    {
        #region GET JSON
        /// <summary>
        /// GET JSON! Let's make a method that returns RAW JSON for each endpoint we want to use.
        /// In our case, we want to get a full deck of cards (that's one endpoint)
        /// and draw X amount of cards from a specific deck (that's another endpoint)
        /// Below this region, we will figure out what to do with this dang raw json! We'll create some objects!
        /// </summary>

        public string GetCardDeckJson()
        {
            // make request to api
            string url =  @$"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            HttpWebRequest request = WebRequest.CreateHttp(url);

            // get and store response from api
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // convert the raw JSON into a string
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            return JSON;
        }
        public string GetCardsJson(string deckId, int cardAmount)
        {
            // make request to api
            string url = @$"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count={cardAmount}";
            HttpWebRequest request = WebRequest.CreateHttp(url);

            // get and store response from api
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // convert the raw JSON into a string
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            return JSON;
        }
        #endregion

        #region CONVERT JSON TO OBJECTS
        /// <summary>
        /// So we have some JSON. But what are we gonna do with that? What we really want our objects... like a Card.. a CardDeck...
        /// We can use a handy JSON Converter to turn our raw json into objects!
        /// You'll want to call these methods somewhere else - like in your Controller for example.
        /// Create in instance of THIS class (the DAL) in your controller. Then you'll be able to call the methods below there.
        /// In this demo, you'll see how these methods were called in the Index action. Why the index? Just for simplicity for demonstration.
        /// </summary>

        public CardDeckModel GetCardDeck()
        {
            string rawJson = GetCardDeckJson();
            CardDeckModel cardDeck = JsonConvert.DeserializeObject<CardDeckModel>(rawJson);
            return cardDeck;
        }

        public DrawCardsModel DrawCards(string deckId, int cardAmount)
        {
            string rawJson = GetCardsJson(deckId, cardAmount);
            DrawCardsModel drawnCards = JsonConvert.DeserializeObject<DrawCardsModel>(rawJson);

            return drawnCards;
        }

        #endregion
    }
}