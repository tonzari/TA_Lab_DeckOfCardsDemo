#pragma checksum "D:\GrandCircus\TA\MyLabSolutions\TA_Lab_DeckOfCards\TA_Lab_DeckOfCards\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88dfc1203b28212c2cabd6e15dfdcc46f21d8413"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\GrandCircus\TA\MyLabSolutions\TA_Lab_DeckOfCards\TA_Lab_DeckOfCards\Views\_ViewImports.cshtml"
using TA_Lab_DeckOfCards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GrandCircus\TA\MyLabSolutions\TA_Lab_DeckOfCards\TA_Lab_DeckOfCards\Views\_ViewImports.cshtml"
using TA_Lab_DeckOfCards.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88dfc1203b28212c2cabd6e15dfdcc46f21d8413", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"549fa47eabf1a8cef1a0041606822981d842e00e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DrawCardsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>You\'ve pulled ");
#nullable restore
#line 3 "D:\GrandCircus\TA\MyLabSolutions\TA_Lab_DeckOfCards\TA_Lab_DeckOfCards\Views\Home\Index.cshtml"
             Write(Model.cards.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cards!</h1>\r\n\r\n");
#nullable restore
#line 5 "D:\GrandCircus\TA\MyLabSolutions\TA_Lab_DeckOfCards\TA_Lab_DeckOfCards\Views\Home\Index.cshtml"
 for (int i = 0; i < Model.cards.Length; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 7 "D:\GrandCircus\TA\MyLabSolutions\TA_Lab_DeckOfCards\TA_Lab_DeckOfCards\Views\Home\Index.cshtml"
  Write(Model.cards[i].value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 7 "D:\GrandCircus\TA\MyLabSolutions\TA_Lab_DeckOfCards\TA_Lab_DeckOfCards\Views\Home\Index.cshtml"
                           Write(Model.cards[i].suit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 8 "D:\GrandCircus\TA\MyLabSolutions\TA_Lab_DeckOfCards\TA_Lab_DeckOfCards\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Try refreshing the page! You\'ll see each time you make a request to the deckofcards API, 5 new cards are drawn.</p>\r\n<p>You have ");
#nullable restore
#line 11 "D:\GrandCircus\TA\MyLabSolutions\TA_Lab_DeckOfCards\TA_Lab_DeckOfCards\Views\Home\Index.cshtml"
       Write(Model.remaining);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cards left in the deck! Want to see the JSON of this card deck? Here\'s the ID: ");
#nullable restore
#line 11 "D:\GrandCircus\TA\MyLabSolutions\TA_Lab_DeckOfCards\TA_Lab_DeckOfCards\Views\Home\Index.cshtml"
                                                                                                       Write(Model.deck_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DrawCardsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
