using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Restaurant
    {
        public static void Run()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem("California Sushi Roll", 7.69, "8 pieces", "Main course"));
            menuItems.Add(new MenuItem("Ramen", 14.99, "broth, noodles, pork, tamago, seaweed, fishcake", "Main course"));
            Menu SergiosRiceria = new Menu(menuItems);

            SergiosRiceria.AddItem(new MenuItem("Tofu", 1.00, "js sum tofu", "appetizer"));
            MenuItem onigiri = new MenuItem("Onigiri", 5.99, "A triangular rice ball with red beans inside", "Appetizer");
            SergiosRiceria.AddItem(onigiri);
            SergiosRiceria.AddItem(onigiri);
            SergiosRiceria.PrintMenu();
            SergiosRiceria.PrintItem();

            Console.WriteLine(SergiosRiceria.RemoveItem("Ramen"));
            SergiosRiceria.PrintMenu();
            
        }
    }
}
