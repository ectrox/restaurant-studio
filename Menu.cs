using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Menu
    {
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated { get; set; }
        public Menu()
        {
            List<MenuItem> items = new List<MenuItem>();
            DateTime lastUpdated = DateTime.Now;
            Items = items;
            LastUpdated = lastUpdated;
        }
        public void PrintAll()
        {
            Console.WriteLine(ToString());
        }
        public void PrintByCategory(ItemTypes category)
        {
            if (category == ItemTypes.appetizer)
            {
                foreach (MenuItem item in Items)
                {
                    if (item.Category == ItemTypes.appetizer)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            if (category == ItemTypes.mainCourse)
            {
                foreach (MenuItem item in Items)
                {
                    if (item.Category == ItemTypes.mainCourse)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            if (category == ItemTypes.dessert)
            {
                foreach (MenuItem item in Items)
                {
                    if (item.Category == ItemTypes.dessert)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
        }
        public void Add(MenuItem toBeAdded)
        {
            Items.Add(toBeAdded);
            LastUpdated = DateTime.Today;
        }
        public void Remove(MenuItem toBeDeleted)
        {
            Items.Remove(toBeDeleted);
        }
        public override string ToString()
        {
            string menuObjString = "";

            foreach (MenuItem item in Items)
            {
                menuObjString += item.ToString();
            }

            menuObjString += "Last Update: " + LastUpdated;

            return menuObjString;
        }
    }

}
