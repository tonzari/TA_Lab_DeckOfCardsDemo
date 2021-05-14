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

            // get and store response from api
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // convert the raw JSON into a string
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            return JsonConvert.DeserializeObject<CardDeckModel>(JSON);
        }

        public DrawCardsModel DrawCards(string deckId, int cardAmount)
        {
            // make request to api
            string url = @$"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count={cardAmount}";
            HttpWebRequest request = WebRequest.CreateHttp(url);

            // get and store response from api
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // convert the raw JSON into a string
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            return JsonConvert.DeserializeObject<DrawCardsModel>(JSON);
        }
    }
}