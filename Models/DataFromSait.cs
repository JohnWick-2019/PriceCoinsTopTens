using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceCoinsTopTens.Models
{
    public class DataFromSait
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string CoinName { get; set; }
        public string CoinPrice { get; set; }
    }
}
