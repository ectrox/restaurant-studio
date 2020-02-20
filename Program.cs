using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }
    }
    class Menu
    {
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated { get; set; }

        void DisplayAll()
        {

        }
        void Add()
        {

        }
    }

    class MenuItem
    {
        public DateTime DateAdded { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ItemTypes Category { get; set; }
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
        void Edit()
        {

        }
        void Remove()
        {

        }
    }

    enum ItemTypes { appetizer, mainCourse, dessert }
}


