using System;
using WiredBrainCoffee.DataAccess;

namespace WIredBrainCoffiee.ShopinfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee Shop Information Tool...");
            Console.WriteLine("Write 'help' to list all commands or 'quit' to exit");
            var coffeeShopDataProvider = new CoffeeShopDataProvider();

            while (true)
            {
                var line = Console.ReadLine();
                if (string.Equals("quit",line,StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();
                if(string.Equals("help",line,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available Coffee Shop commands:");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> {coffeeShop.Location}");
                    }
                }
            }
        }
    }
}
