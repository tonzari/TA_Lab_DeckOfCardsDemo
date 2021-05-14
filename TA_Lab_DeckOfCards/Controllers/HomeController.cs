using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TA_Lab_DeckOfCards.Models;

namespace TA_Lab_DeckOfCards.Controllers
{
    public class HomeController : Controller
    {
        // We need to create an instance of the CardDAL here. Why? Ask thyself... take a guess... :)
        // So we can get access to its available class members!
        // In this case, it's a couple methods we created that make requests to the API,
        // and our DAL will give us back objects we can actually use in our program.
        // In this demo, we aren't creating any new views... let's keep it super simple
        // ... we'll just use the Index action (homepage) See below.

        private readonly CardDAL _cardDal = new CardDAL();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Now let's make use of our CardDAL! We've got a couple useful methods:
            // - One method that gets a full card deck: GetCardDeck()
            // - Another that draws cards: DrawCards(deck to draw from, how many cards)
            // - Notice we decided that the DrawCards method takes two arguments: a deck to draw from, and how many cards

            CardDeckModel cardDeck = _cardDal.GetCardDeck();    
            DrawCardsModel drawCards = _cardDal.DrawCards(cardDeck.deck_id, 5);    

            return View(drawCards);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
