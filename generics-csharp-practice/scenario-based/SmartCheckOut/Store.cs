
using System.Collections.Generic;

namespace SmartCheckout
{
    internal class Store
    {
        public Dictionary<string, double> PriceMap = new Dictionary<string, double>();
        public Dictionary<string, int> StockMap = new Dictionary<string, int>();

        public Store()
        {
            PriceMap["Milk"] = 50;
            PriceMap["Bread"] = 30;
            PriceMap["Rice"] = 60;
            PriceMap["Sugar"] = 45;

            StockMap["Milk"] = 20;
            StockMap["Bread"] = 15;
            StockMap["Rice"] = 10;
            StockMap["Sugar"] = 12;
        }
    }
}
