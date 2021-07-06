using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    class InventoryManager
    {
        public int CalculatePrice(int weight,int price)
        {
            return weight * price;
        }
        public void DisplayProducts(List<InventoryUtility.Rice> riceList)
        {
            int totalPrice = 0;
            Console.WriteLine("Rice Inventory Prices");
            foreach (var rice in riceList)
            {
                Console.WriteLine($"Name:{rice.name}\nWeight:{rice.weight} kg\nPrice:${rice.price}\n");
                totalPrice += CalculatePrice(rice.weight, rice.price);
            }
            Console.WriteLine($"Total Inventory cost for Rice ${totalPrice}");
        }
        public void DisplayProducts(List<InventoryUtility.Wheat> wheatList)
        {
            int totalPrice = 0;
            Console.WriteLine("Rice Inventory Prices");
            foreach (var wheat in wheatList)
            {
                Console.WriteLine($"Name:{wheat.name}\nWeight:{wheat.weight} kg\nPrice:${wheat.price}\n");
                totalPrice += CalculatePrice(wheat.weight, wheat.price);
            }
            Console.WriteLine($"Total Inventory cost for Wheat ${totalPrice}");
        }
        public void DisplayProducts(List<InventoryUtility.Pulse> pulseList)
        {
            int totalPrice = 0;
            Console.WriteLine("Rice Inventory Prices");
            foreach (var pulse in pulseList)
            {
                Console.WriteLine($"Name:{pulse.name}\nWeight:{pulse.weight} kg\nPrice:${pulse.price}\n");
                totalPrice += CalculatePrice(pulse.weight, pulse.price);
            }
            Console.WriteLine($"Total Inventory cost for Pulse ${totalPrice}");
        }


        public List<InventoryUtility.Rice> AddInventory(List<InventoryUtility.Rice> riceList)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.WriteLine("Enter Name of Rice");
            utility.name = Console.ReadLine();
            Console.WriteLine("Enter Weight of Rice");
            utility.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price of Rice");
            utility.price = Convert.ToInt32(Console.ReadLine());
            riceList.Add(utility);
            Console.WriteLine($"Added {utility.name} of weight {utility.weight} , Price {utility.price} to the Inventory");
            return riceList;
        }
        public List<InventoryUtility.Pulse> AddInventory(List<InventoryUtility.Pulse> pulseList)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();
            Console.WriteLine("Enter Name of Pulse");
            utility.name = Console.ReadLine();
            Console.WriteLine("Enter Weight of Pulse");
            utility.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price of Pulse");
            utility.price = Convert.ToInt32(Console.ReadLine());
            pulseList.Add(utility);
            Console.WriteLine($"Added {utility.name} of weight {utility.weight} , Price {utility.price} to the Inventory");
            return pulseList;
        }
        public List<InventoryUtility.Wheat> AddInventory(List<InventoryUtility.Wheat> wheatList)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();
            Console.WriteLine("Enter Name of Wheat");
            utility.name = Console.ReadLine();
            Console.WriteLine("Enter Weight of Wheat");
            utility.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price of Wheat");
            utility.price = Convert.ToInt32(Console.ReadLine());
            wheatList.Add(utility);
            Console.WriteLine($"Added {utility.name} of weight {utility.weight} , Price {utility.price} to the Inventory");
            return wheatList;
        }
        public List<InventoryUtility.Rice> DeleteInventory(List<InventoryUtility.Rice> riceList)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.WriteLine("Enter Name of the rice you want to Delete:");
            string nameOfRice = Console.ReadLine().ToLower();
            riceList.Remove(riceList.Find(item => item.name.ToLower().Equals(nameOfRice)));
            Console.WriteLine($"Deleted {nameOfRice} From the Inventory");
            return riceList;
        }
        public List<InventoryUtility.Pulse> DeleteInventory(List<InventoryUtility.Pulse> pulseList)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();
            Console.WriteLine("Enter Name of the Pulse you want to Delete:");
            string nameOfPulse = Console.ReadLine().ToLower();
            pulseList.Remove(pulseList.Find(item => item.name.ToLower().Equals(nameOfPulse)));
            Console.WriteLine($"Deleted {nameOfPulse} From the Inventory");
            return pulseList;
        }
        public List<InventoryUtility.Wheat> DeleteInventory(List<InventoryUtility.Wheat> wheatList)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();
            Console.WriteLine("Enter Name of the Wheat you want to Delete:");
            string nameOfWheat = Console.ReadLine().ToLower();
            wheatList.Remove(wheatList.Find(item => item.name.ToLower().Equals(nameOfWheat)));
            Console.WriteLine($"Deleted {nameOfWheat} From the Inventory");
            return wheatList;
        }
        public List<InventoryUtility.Rice> EditInventory(List<InventoryUtility.Rice> riceList)
        {
            List<InventoryUtility.Rice> ricelist = DeleteInventory(riceList);
            return AddInventory(ricelist);
        }
        public List<InventoryUtility.Pulse> EditInventory(List<InventoryUtility.Pulse> pulseList)
        {
            List<InventoryUtility.Pulse> pulselist = DeleteInventory(pulseList);
            return AddInventory(pulselist);
        }
        public List<InventoryUtility.Wheat> EditInventory(List<InventoryUtility.Wheat> wheatList)
        {
            List<InventoryUtility.Wheat> wheatlist = DeleteInventory(wheatList);
            return AddInventory(wheatlist);
        }


    }
}
