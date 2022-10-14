using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public string DishName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }
        public MenuItem(string dishName, double price, string description, string category)
        {
            DishName = dishName;
            Price = price;
            Description = description;
            Category = category;
            IsNew = true;
        }

    }
}
