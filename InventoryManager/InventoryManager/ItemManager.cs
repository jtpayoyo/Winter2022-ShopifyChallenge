using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryManagerData
{
    /// <summary>
    /// Title: InventoryManagerData
    /// Date: Sep 20, 2021
    /// Author: Jeanne Payoyo
    /// Description: Handles data processing for image and item
    /// </summary>
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

        // Updates item data and saves changes
        public static void UpdateItem(int myId, string name, string desc, int qty, decimal fPrice, decimal fDiscount, decimal iPrice, decimal iDiscount, int imageId)
        {
            // Get item from database
            MyImageDBContext db = new MyImageDBContext();
            Item myItem = db.Items.SingleOrDefault(t => t.ItemId == myId);

            // Update fields
            myItem.ItemName = name;
            myItem.ItemDescription = desc;
            myItem.ItemQuantity = qty;
            myItem.FactoryPrice = fPrice;
            myItem.FactoryDiscount = fDiscount;
            myItem.ItemPrice = iPrice;
            myItem.ItemDiscount = iDiscount;
            myItem.ImageId = imageId;

            db.SaveChanges();
        }

    } // End of class
} // End of namespace
