using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
//Edited from VS Code Web!
{
    public class Menu
    {
        private List<MenuItem> menu = new List<MenuItem>();
        private string lastUpdated = string.Empty;
        
        public Menu(List<MenuItem> menu)
        {
            this.menu = menu;
            lastUpdated = DateTime.Now.ToString();
        }
        public void CheckLastDate()
        {
            Console.WriteLine("Last update date: " + this.lastUpdated);
        }

        public void AddItem(MenuItem item)
        {
            if(!this.menu.Contains(item))
            {
                this.menu.Add(item);
            } else
            {
                Console.WriteLine($"*An item named '{item.DishName}' already exists in the menu!*");
            }
        }
        public string RemoveItem(string itemName)
        {
            MenuItem toBeRemoved = this.menu.Find(item => item.DishName == itemName);
            if(toBeRemoved != null)
            {
                this.menu.Remove(toBeRemoved);
                return "*Removed " + toBeRemoved.DishName + "*";
            } else
            {
                return "*Sorry! That item was not found in the menu!*";
            }
        }

        public bool IsItemNew(MenuItem item)
        {
            return item.IsNew;
        }

        public string CheckLastUpdate()
        {
            return lastUpdated;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Welcome to the restaurant! Here is the Menu\n");
            int iter = 0;
            foreach(MenuItem item in menu)
            {
                Console.WriteLine($"{++iter}) [{item.Category}] {item.DishName}: {item.Description}. ${item.Price}");
            }
            Console.WriteLine();
        }

        public void PrintItem()
        {
            Console.WriteLine("Hi! Please select one of the following menu items to expand information");
            this.PrintDishes();
            Console.WriteLine("Choose: ");
            string input = Console.ReadLine().Trim();
            MenuItem chosen = this.menu.Find(item => item.DishName == input);
            if(chosen != null)
            {
                Console.WriteLine($"Dish Name: {chosen.DishName} \n" +
                    $"Description: {chosen.Description} \n" +
                    $"Price: ${chosen.Price} \n" +
                    $"Category: {chosen.Category} \n" +
                    $"New Item: {(chosen.IsNew ? "Yes" : "No")}");
            } else
            {
                Console.WriteLine("Item not found.");
            }
            Console.WriteLine();
        }
        private void PrintDishes()
        {
            foreach (MenuItem item in menu)
            {
                Console.WriteLine($"[{item.DishName}]");
            }
        }
        public override bool Equals(object obj)
        {
            return obj is Menu menu &&
                   EqualityComparer<List<MenuItem>>.Default.Equals(this.menu, menu.menu) &&
                   lastUpdated == menu.lastUpdated;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(menu, lastUpdated);
        }
    }
}
