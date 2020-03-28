using System;
using System.Linq;
using WiredBrainCoffee.DataAccess;

namespace WIredBrainCoffiee.ShopinfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee Shop Information Tool...");
            Console.WriteLine("Write 'help' to list all commands or type 'quit' to exit");
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
                    Console.WriteLine("> Available Coffee Shop all commands:");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> {coffeeShop.Location}");
                    }
                }
                else
                {
                    var foundCoffeeShops = coffeeShops.Where(x => x.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase)).ToList();
                    if(foundCoffeeShops.Count == 0)
                    {
                        Console.WriteLine($"> Command '{line}' not found");
                    }
                    else if(foundCoffeeShops.Count == 1)
                    {
                        var coffeeShop = foundCoffeeShops.Single();
                        Console.WriteLine($"Location: {coffeeShop.Location}");
                        Console.WriteLine($"Beans in Stock: {coffeeShop.BeansInStockInKg} kg");
                    }
                    else
                    {
                        Console.WriteLine("Multiple matching coffeeshops found");
                        foreach (var item in foundCoffeeShops)
                        {
                            Console.WriteLine($"> {item.Location}");
                        }
                    }
                }
            }
        }
    }
}
