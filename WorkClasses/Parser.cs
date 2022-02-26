using AngleSharp;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceCoinsTopTens.WorkClasses
{
    /// <summary>
    /// This class contains all the logic for getting price data from the site.
    /// </summary>
    public class Parser
    {
        private IConfiguration config = Configuration.Default.WithDefaultLoader();
        private static string firstPartOfAddres = "https://";
        private static string innerPart = "";
        private static string secondPartOfAddres = "";
        private static string address = "";

        /// <summary>
        /// Saves cryptocurrency price data from the site.
        /// </summary>
        /// <param name="listCriptoName">Accepts a list of cryptocurrency names.</param>
        /// <returns>Top ten cryptocurrency price list.</returns>
        public List<string> Parse(List<string> listCriptoName)
        {
            var listPrice = new List<string>();

            foreach (var criptoName in listCriptoName)
            {
                innerPart = criptoName;
                secondPartOfAddres = $"coinmarketcap.com/currencies/{innerPart}/";
                address = firstPartOfAddres + secondPartOfAddres;

                using (var document = BrowsingContext.New(config).OpenAsync(address))
                {
                    var parsedHtml = document.Result;
                    var priceEth = parsedHtml.All.Where(m => m.ClassList.Contains("priceValue"));

                    foreach (var item in priceEth)
                    {
                        listPrice.Add(item.TextContent);
                    }

                }
            }

            return listPrice;


        }
    }
}
