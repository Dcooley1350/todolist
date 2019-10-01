using System;
using System.Collections.Generic;
using ToDoList.Models;


namespace ToDoList 
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcoe To The List Generator, A/V");
            // if 1 then 
            string answer = Console.ReadLine();
            if(answer == "A")
            {
                Script.AddToList();
            }
            else if(answer == "V")
            {
                Script.ViewAllList();
                Main();
            }
            else
            {
                Console.WriteLine("Error");
                Main();
            }
        }
    }
}