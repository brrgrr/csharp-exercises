using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MenuItem
    {
        private string Name { get; set; }
        private string Description { get; set; }
        private string Category { get; set; }
        // appetizer, main course, or dessert
        public float Price { get; set; }
        private DateTime Added { get; set; }
        private const int newDuration = 7;

        public bool IsNew
        {
            get { return this.title; }
           set { this.title = value; }
        }

        public MenuItem(string name, string description, string category, float price)
        {
            this.Name = name;
            this.Description = description;
            this.Category = category;
            this.Price = price;
            this.Added = DateTime.Now;
        }
    }
}
