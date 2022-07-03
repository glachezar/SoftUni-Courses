using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "end")
                {
                    break;
                }
                string[] tokens = data.Split().ToArray();

                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQty = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);
                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    ItemQty = itemQty,
                    Item = new Item
                    {
                        ItemName = itemName,
                        ItemPrice = itemPrice
                    }
                };


                boxes.Add(box);
            }

            List<Box> descendingOrders = boxes.OrderByDescending(box => box.PricePerBox).ToList();

            foreach (var order in descendingOrders)
            {
                Console.WriteLine(order.SerialNumber);
                Console.WriteLine($"-- {order.Item.ItemName} - ${order.Item.ItemPrice:f2}: {order.ItemQty}");
                Console.WriteLine($"-- ${order.PricePerBox:f2}");
            }
        }
    }

    class Item
    {
        
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
    }

    class Box
    {
        

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQty { get; set; }

        public decimal PricePerBox
        {
            get
            {
                return this.ItemQty * this.Item.ItemPrice;
            }
        }
    }
}
