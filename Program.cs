using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList fruits = new ArrayList();

        // First to add elements to the ArrayList
        fruits.Add("apple");
        fruits.Add("banana");
        fruits.Add("cherry");
        fruits.Add("date");
        fruits.Add("elderberry");
        //print the total number of elements in the ArrayList using Count property
        Console.WriteLine("Total number of elements in the ArrayList: " + fruits.Count);
        //to display the available task for the user
        Console.WriteLine("\nTasks:");
        Console.WriteLine("1. Insert an item");
        Console.WriteLine("2. Remove an item");
        Console.WriteLine("3. Search for an item");
        Console.Write("Enter your choice (1, 2, or 3): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        //User choice is initiated using switch statement
        switch (choice)
        {
            case 1:
                Console.Write("\nEnter the item to insert: ");
                string itemToInsert = Console.ReadLine();
                Console.Write("Enter the position to insert (0-{0}): ", fruits.Count);
                int positionToInsert = Convert.ToInt32(Console.ReadLine());
                fruits.Insert(positionToInsert, itemToInsert);
                Console.WriteLine("\nItem inserted successfully.");
                break;

            case 2:
                Console.Write("\nEnter the item to remove: ");
                string itemToRemove = Console.ReadLine();
                if (fruits.Contains(itemToRemove))
                {
                    fruits.Remove(itemToRemove);
                    Console.WriteLine("\nItem removed successfully.");
                }
                else
                {
                    Console.WriteLine("\nItem not found in the ArrayList.");
                }
                break;

            case 3:
                Console.Write("\nEnter the item to search: ");
                string itemToSearch = Console.ReadLine();
                bool containsItem = fruits.Contains(itemToSearch);
                if (containsItem)
                {
                    Console.WriteLine("\nItem found in the ArrayList.");
                }
                else
                {
                    Console.WriteLine("\nItem not found in the ArrayList.");
                }
                break;

            default:
                Console.WriteLine("\nInvalid choice. Please enter a valid choice (1, 2, or 3).");
                break;
        }

        Console.WriteLine("\nElements in the ArrayList:");
        //To print the elements in the ArrayList by using Foreach loop
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.ReadLine();
    }
}