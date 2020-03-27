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
            yield return new CoffeeShop { Location = "Rajkot", BeansInStockInKg = 900 };
            yield return new CoffeeShop { Location = "Ahmedabad", BeansInStockInKg = 90 };
            yield return new CoffeeShop { Location = "Surat", BeansInStockInKg = 300 };
        }
    }
}
