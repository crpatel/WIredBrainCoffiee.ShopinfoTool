using System;
using WiredBrainCoffee.DataAccess;

namespace WIredBrainCoffiee.ShopinfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee Shop Information Tool...");
            Console.WriteLine("Write 'help' to list all commands");
            var coffeeShopDataProvider = new CoffeeShopDataProvider();

            while (true)
            {
                var line = Console.ReadLine();
                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();
                if(string.Equals("help",line,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available Coffee Shop all commands:");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> {coffeeShop.Location}");
                    }
                }
            }
        }
    }
}
