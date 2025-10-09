using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals_Lists_InventorySystemv1._0_Nick
{
    internal class Program
    {
        static List<string> inventory = new List<string>();

        static int maxInventory = 4;


        static void Main(string[] args)
        {
            PickUp("health potion");
            Console.ReadKey(); Console.Clear();
            PickUp("health potion");
            Console.ReadKey(); Console.Clear();
            PickUp("apple");
            Console.ReadKey(); Console.Clear();
            PickUp("orange");
            Console.ReadKey(); Console.Clear();
            Use("banana");
            Console.ReadKey(); Console.Clear();
            PickUp("rock");
            Console.ReadKey(); Console.Clear();
            Use("health potion");
            Console.ReadKey(); Console.Clear();
            Use("orange");
            Console.ReadKey(); Console.Clear();
            Drop("apple");
            Console.ReadKey(); Console.Clear();
            ClearInventory();
            Console.ReadKey(); Console.Clear();
            ShowInventory();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);


        }


        static void PickUp(string item)
        {
   
            if (inventory.Count == maxInventory)
            {
                ShowInventory();
                Console.WriteLine($"Trying to add {item}...");
                Console.WriteLine($"Cannot pick up {item}. Inventory full.");
            }
            else
            {
                ShowInventory();
                Console.WriteLine($"Trying to add {item}...");
                inventory.Add(item);
                Console.WriteLine($"Picked up {item}");
            }


        }

        static void Drop(string item)
        {
            ShowInventory();
            Console.WriteLine($"Trying to drop {item}...");

            if (!inventory.Contains(item))
            {
                Console.WriteLine($"You do not have a {item}");
            }
            else
            {
                Console.WriteLine($"dropped the {item}");
                inventory.Remove(item);
            }
        }
        static void Use(string item)
        {

            ShowInventory();
            Console.WriteLine($"Trying to use {item}...");

            if (inventory.Contains(item))
            {
                Console.WriteLine($"used the {item}");
                inventory.Remove(item);
            }
            else
            {
                Console.WriteLine($"You do not have a {item}");
            }
        }
        static void ClearInventory()
        {
            ShowInventory();
            Console.WriteLine("Player died. Inventory lost.");
            inventory.Clear();
        }
        static void ShowInventory()
        {
            Console.WriteLine("Inventory:");
            Console.WriteLine($"{inventory.Count} item(s)");
            
            { for (int i = 0; i < inventory.Count; i++)
                {
                    Console.WriteLine($"- {inventory[i]}");
                }
            }
            Console.WriteLine();
        }
    }
}
        //Use("banana"); // do not have a banana
        //Add("rock"); // should fail to add (not enough space in inventory)
        //Use("health potion");
        //Use("orange");
        //Drop("apple");
        //Clear(); // on player death
