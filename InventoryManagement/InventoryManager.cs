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

    }
}
