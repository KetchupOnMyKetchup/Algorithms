using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Basics_Part1
{
    class _03ZeldaIntroToCollections
    {
        //static void Main()
        //{ 
        
        //}
        

        public class User
        {
            public void GetUserInventory()
            {

            }
        }

        public class Shop
        {
            public void ShopPrompt()
            {
                Console.WriteLine("BUY SOMETHIN' WILL YA!");

                var inventory = GetShopInventory();

                foreach (var item in inventory)
                {
                    Console.WriteLine($"I have a {item.Name} at the price of {item.Price}.");
                }

                Console.WriteLine("Which item name would you like to buy?");

                // do math with user gold
                // add item to user inventory
            }

            public List<Item> GetShopInventory()
            {
                List<Item> shopItems = new List<Item>();
                shopItems.Add(new Item("Shield", 160));
                shopItems.Add(new Item("Key", 100));
                shopItems.Add(new Item("Candle", 60));

                return shopItems;
            }
        }

        public class Item
        {
            public Item(string name, int price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; set; }
            public int Price { get; set; }
        }
    }
}
