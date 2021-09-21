using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryManagerData
{
    public static class ItemManager
    {
        // Gets list of all items
        public static List<Item> GetItems()
        {
            MyImageDBContext db = new MyImageDBContext();
            var items = db.Items.ToList();
            return items;
        }

        public static Item GetItemById(int myId)
        {
            MyImageDBContext db = new MyImageDBContext();
            Item item = db.Items.SingleOrDefault(t => t.ItemId == myId);
            return item;
        }


    } // End of class
} // End of namespace
