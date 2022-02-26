using AngleSharp;
using System.Collections.Generic;

namespace PriceCoinsTopTens.WorkClasses
{
    public class GetListCriptocurrenciName
    {
        private IConfiguration config = Configuration.Default.WithDefaultLoader();
        private static string address = "https://coinmarketcap.com/";

        /// <summary>
        /// The method receives a list of the first ten cryptocurrencies from the site.
        /// </summary>
        /// <returns>List of corrected names of cryptocurrencies.</returns>
        public List<string> GetCriptocurrenciName()
        {
            using (var document = BrowsingContext.New(config).OpenAsync(address))
            {
                var parsedHtml = document.Result;
                var takeCriptoNameList = parsedHtml.GetElementsByClassName("sc-16r8icm-0 sc-1teo54s-1 dNOTPP");

                var criptoNameTopTenList = new List<string>();
                var newNameCriptoWithoutNumber = new List<string>();

                for (int i = 0; i < takeCriptoNameList.Length; i++)
                {
                    if (i >= 9)
                    {
                        criptoNameTopTenList.Add(takeCriptoNameList[i].TextContent.ToString().ToLower());
                    }

                }

                // This loop remove all numbers from cryptocurrencies name.
                for (int i = 0; i < criptoNameTopTenList.Count; i++)
                {
                    int indexOfNumber = 0;

                    var criptoNameWithNumber = criptoNameTopTenList[i];

                    for (int j = 0; j < criptoNameWithNumber.Length; j++)
                    {
                        if (char.IsNumber(criptoNameWithNumber[j]))
                        {
                            indexOfNumber = j;
                            criptoNameWithNumber = criptoNameWithNumber.Remove(indexOfNumber);
                            criptoNameWithNumber = criptoNameWithNumber.Replace(" ", "-");
                            newNameCriptoWithoutNumber.Add(criptoNameWithNumber);
                        }

                    }
                }

                return newNameCriptoWithoutNumber;
            }
        }
    }
}
