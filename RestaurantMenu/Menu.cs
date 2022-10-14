using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        private List<MenuItem> menu = new List<MenuItem>();
        private string lastUpdated = string.Empty;
        public Menu(List<MenuItem> menu)
        {
            this.menu = menu;
            this.lastUpdated = DateTime.Now.ToString();
        }
        public void checkLastDate()
        {
            Console.WriteLine("Last update date: " + this.lastUpdated);
        }
    }
}
