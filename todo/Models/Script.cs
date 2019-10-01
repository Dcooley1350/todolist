using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Models
{
    class Script
    {
        public static void AddToList()
        {
            Console.WriteLine("Add something to list");
            string answer =  Console.ReadLine();
            Item item = new Item(answer);
            Console.WriteLine(answer + "has been added to your list, would you like to add another item");
            string answer1 = Console.ReadLine();
            if(answer1 == "y")
            {
                AddToList();
            }
            else
            {
                Program.Main();
            }
        }
        public static void ViewAllList()
        {
            List<Item> itemResult = Item.GetAll();
            foreach(Item whatever in itemResult)
            {
                Console.WriteLine(whatever.Description);
            }

        }
        
    }
}