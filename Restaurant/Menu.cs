using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; }
        private DateTime LastUpdated { get; set; }

        public Menu()
        {
            this.MenuItems = new List<MenuItem>();
            this.LastUpdated = DateTime.Now;
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            this.MenuItems.Add(menuItem);
            this.LastUpdated = DateTime.Now;
        }

        public void RemoveMenuItem(MenuItem menuItem)
        {
            this.MenuItems.Remove(menuItem);
            this.LastUpdated = DateTime.Now;
        }
    }
}
