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
        public CardDeckModel GetCardDeck()
        {
            // make request to api
            string url = @$"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            HttpWebRequest request = WebRequest.CreateHttp(url);

            // store response from api
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // convert the http response into a string of raw json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            // convert the raw json string into an object (CardDeckModel) and return it
            CardDeckModel cardDeck = JsonConvert.DeserializeObject<CardDeckModel>(JSON);
            
            return cardDeck;
        }

        public DrawCardsModel DrawCards(string deckId, int cardAmount)
        {
            // make request to api
            string url = @$"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count={cardAmount}";
            HttpWebRequest request = WebRequest.CreateHttp(url);

            // store response from api
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // convert the http response into a string of raw json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            // convert the raw json string into an object (DrawCardsModel) and return it
            DrawCardsModel drawnCards =  JsonConvert.DeserializeObject<DrawCardsModel>(JSON);

            return drawnCards; // is it confusing to call this "drawnCards"? I like the past-tense... I'm thinking "cards that were drawn"
        }
    }
}