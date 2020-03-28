using System;
using System.Collections.Generic;
using System.Text;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { Location = "Rajkot", BeansInStockInKg = 900, PaperCup = 900 };
            yield return new CoffeeShop { Location = "Ahmedabad", BeansInStockInKg = 90, PaperCup = 230 };
            yield return new CoffeeShop { Location = "Baroda", BeansInStockInKg = 300, PaperCup = 340 };
            yield return new CoffeeShop { Location = "Surat", BeansInStockInKg = 300, PaperCup = 340 };
            yield return new CoffeeShop { Location = "Junagadh", BeansInStockInKg = 300, PaperCup = 340 };
            yield return new CoffeeShop { Location = "Surendranagar", BeansInStockInKg = 300, PaperCup = 340 };
        }
    }
}
