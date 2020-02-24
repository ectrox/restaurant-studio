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
    
    }


