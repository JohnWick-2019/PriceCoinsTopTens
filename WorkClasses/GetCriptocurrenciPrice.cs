using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceCoinsTopTens.WorkClasses
{
    /// <summary>
    /// The class combines the logic of getting a price and sending a message.
    /// </summary>
    public class GetCriptocurrenciPrice
    {
        public void Show()
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

                foreach (var item in сriptocurrenciPrice)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
