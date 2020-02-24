using System;
using System.Collections.Generic;

namespace Restaurant
{
    public enum ItemTypes { appetizer, mainCourse, dessert }
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            MenuItem item1 = new MenuItem("Mac & Cheese", "Enjoy spiral noodles with melted cheese and butter", 9.49, ItemTypes.mainCourse);
            MenuItem item2 = new MenuItem("Chocolate Cake", "Pound cake meets fudgy chocolate in this delicious dessert", 4.99, ItemTypes.dessert);
            menu.Add(item1);
            menu.Add(item2);
            menu.PrintAll();
            Console.WriteLine("");
            menu.PrintByCategory(ItemTypes.dessert);
            Console.ReadLine();
        }
    }
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
            if (category == ItemTypes.appetizer) {
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

    class MenuItem
    {
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ItemTypes Category { get; set; }
        public MenuItem(string itemName, string description, double price, ItemTypes category)
        {
            Name = itemName;
            Description = description;
            Price = price;
            Category = category;
            DateAdded = DateTime.Now;
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
        public bool IsNew()
        {
            if (DateAdded <= DateTime.Now.AddMonths(-3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            string itemObjString = Name + " (" + Description + ", Added on: " + DateAdded + ", Price: " + Price + ")\n";
            return itemObjString;
        }
        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != GetType())
            {
                return false;
            }

            MenuItem menuItemObj = obj as MenuItem;
            return Name == menuItemObj.Name && Price == menuItemObj.Price;
        }
    }
}


