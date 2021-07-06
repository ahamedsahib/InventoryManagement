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
            Console.WriteLine("1.Display Inventories \n2.Add Inventories\n3.Edit Inventories\n4.Delete Inventories\n5.Exit\nEnter Your Option");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("1.Display Rice \n2.Display Pulse\n3.Display Wheat\n4.Exit\nEnter Your Option");
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
                            Console.WriteLine("Exited");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("1.Add Rice \n2.Add Pulse\n3.Add Wheat\n4.Exit\nEnter Your Option");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            manager.AddInventory(utility.riceList);
                            File.WriteAllText(jsonFilepath, JsonConvert.SerializeObject(utility));

                            break;
                        case 2:
                            manager.AddInventory(utility.pulseList);
                            File.WriteAllText(jsonFilepath, JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            manager.AddInventory(utility.wheatList);
                            File.WriteAllText(jsonFilepath, JsonConvert.SerializeObject(utility));
                            break;
                        case 4:
                            Console.WriteLine("Exited");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("1.Edit Rice \n2.Edit Pulse\n3.Edit Wheat\n4.Exit\nEnter Your Option");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            manager.EditInventory(utility.riceList);
                            File.WriteAllText(jsonFilepath, JsonConvert.SerializeObject(utility));
                            break;
                        case 2:
                            manager.EditInventory(utility.pulseList);
                            File.WriteAllText(jsonFilepath, JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            manager.EditInventory(utility.wheatList);
                            File.WriteAllText(jsonFilepath, JsonConvert.SerializeObject(utility));
                            break;
                        case 4:
                            Console.WriteLine("Exited");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("1.Delete Rice \n2.Delete Pulse\n3.Delete Wheat\n4.Exit\nEnter Your Option");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            manager.DeleteInventory(utility.riceList);
                            File.WriteAllText(jsonFilepath, JsonConvert.SerializeObject(utility));
                            break;
                        case 2:
                            manager.DeleteInventory(utility.pulseList);
                            File.WriteAllText(jsonFilepath, JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            manager.DeleteInventory(utility.wheatList);
                            File.WriteAllText(jsonFilepath, JsonConvert.SerializeObject(utility));
                            break;
                        case 4:
                            Console.WriteLine("Exited");
                            break;
                    }

                    break;
                case 5:
                    Console.WriteLine("Exited");
                    break;
            }


        }
    }
}