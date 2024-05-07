using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
        {
            {"Apple", 1.00m},
            {"Banana", 0.50m},
            {"Orange", 0.75m},
            {"Milk", 2.50m},
            {"Bread", 1.75m},
            {"Eggs", 2.00m},
            {"Chicken", 5.00m},
            {"Rice", 3.00m}
        };

        List<string> shoppingList = new List<string>();

        Console.WriteLine("Welcome to the shopping list database!");

        bool continueShopping = true;
        while (continueShopping)
        {
            Console.WriteLine("Here's our menu:");
            Console.WriteLine("Item\t\tPrice");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Key}\t\t{item.Value:C}");
            }

            Console.Write("\nEnter the name of the item you want to order: ");
            string itemName = Console.ReadLine();

            if (menu.ContainsKey(itemName))
            {
                Console.WriteLine($"You've ordered {itemName} for {menu[itemName]:C}");
                shoppingList.Add(itemName);
            }
            else
            {
                Console.WriteLine("Sorry, that item doesn't exist in our menu.");
            }

            Console.Write("Do you want to add another item? (yes/no): ");
            string choice = Console.ReadLine().ToLower();
            if (choice != "yes")
            {
                continueShopping = false;
            }
        }

        Console.WriteLine("\nYour order:");
        Console.WriteLine("Item\t\tPrice");
        decimal total = 0;
        foreach (var item in shoppingList)
        {
            Console.WriteLine($"{item}\t\t{menu[item]:C}");
            total += menu[item];
        }
        Console.WriteLine($"Total:\t\t{total:C}");
    }
}
