using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
        class MenuItem
        {
            public string Name { get; set; }
            public DateTime DateAdded { get; set; }
            public double Price { get; set; }
            public string Description { get; set; }
            public ItemTypes Category { get; set; }
            public bool IsNew
            {
                get
                {
                    return DateAdded.Date >= DateTime.Now.Date.AddMonths(-3);
                }
            }
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
