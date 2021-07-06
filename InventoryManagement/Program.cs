using Newtonsoft.Json;
using System;
using System.IO;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Inventory Management Program");
            InventoryManager manager = new InventoryManager();

            string jsonFilepath = @"C:\Users\ahamed\source\repos\InventoryManagement\InventoryManagement\Products.json";

            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(jsonFilepath));

            Console.WriteLine("---------MENU-------");
            Console.WriteLine("1.Display Rice \n2.Display Pulse\n3.Display Wheat\n4.Cancel"); 
            Console.WriteLine("Choose Your Option"); 
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    manager.DisplayProducts(utility.riceList);
                    break;
                case 2:
                    manager.DisplayProducts(utility.pulseList);
                    break;
                case 3:
                    manager.DisplayProducts(utility.wheatList);
                    break;
                case 4:
                    Console.WriteLine("Cancel");
                    break;
            }
        }
    }
}
