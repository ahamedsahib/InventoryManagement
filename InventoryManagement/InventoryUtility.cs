using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace InventoryManagement
{
    class InventoryUtility
    {
        public List<Rice> riceList { get; set; }
        public List<Pulse> pulseList { get; set; }
        public List<Wheat> wheatList { get; set; }


        public class Rice
        {
            public string name { get; set; }
            public int weight { get; set; }
            public int price { get; set; }
        }
        public class Wheat
        {
            public string name { get; set; }
            public int weight { get; set; }
            public int price { get; set; }
        }
        public class Pulse
        {
            public string name { get; set; }
            public int weight { get; set; }
            public int price { get; set; }
        }

    }

}
