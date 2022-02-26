using System.Collections.Generic;

namespace PriceCoinsTopTens.WorkClasses
{
    /// <summary>
    /// The class combines the logic of getting a price and sending a message.
    /// </summary>
    public class GetCriptocurrenciPrice
    {
        public List<string> GetPrice()
        {
            var сriptocurrenciName = new List<string>();
            var сriptocurrenciPrice = new List<string>();

            GetListCriptocurrenciName getListCriptocurrenciName = new GetListCriptocurrenciName();
            {
                сriptocurrenciName = getListCriptocurrenciName.GetCriptocurrenciName();

                Parser parser = new Parser();
                {
                    сriptocurrenciPrice = parser.Parse(сriptocurrenciName);
                }

                return сriptocurrenciPrice;
            }

        }
    }
}
