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
        public void checkLastDate()
        {
            Console.WriteLine("Last update date: " + this.lastUpdated);
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
