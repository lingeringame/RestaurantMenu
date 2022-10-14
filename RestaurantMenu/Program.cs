using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem("California Sushi Roll", 7.69, "8 pieces", "Main course"));
            menuItems.Add(new MenuItem("Ramen", 14.99, "broth, noodles, pork, tamago, seaweed, fishcake", "Main course"));
            Menu restaurantMenu = new Menu(menuItems);
            restaurantMenu.checkLastDate();
        }
    }
}
