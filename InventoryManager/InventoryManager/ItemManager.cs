using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        // Buys/sells items and saves changes
        public static void BuySellItem(int myId, int newQuantity)
        {
            // Get item from database
            MyImageDBContext db = new MyImageDBContext();
            Item myItem = db.Items.SingleOrDefault(t => t.ItemId == myId);
            myItem.ItemQuantity = newQuantity;
            db.SaveChanges();
        }

        /*// Obtains image given item id
        // Obtained from stack overflow
        // https://stackoverflow.com/questions/9576868/how-to-put-image-in-a-picture-box-from-a-byte-in-c-sharp
        public static Bitmap GetImageByItemId(int myId)
        {
            MyImageDBContext db = new MyImageDBContext();
            Item myItem = db.Items.SingleOrDefault(t => t.ItemId == myId);

            MemoryStream mStream = new MemoryStream();
            byte[] pData = myItem.Image.ImageFile;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }*/

        // Obtains image given item id
        // Obtained from stack overflow
        // https://stackoverflow.com/questions/9576868/how-to-put-image-in-a-picture-box-from-a-byte-in-c-sharp
        public static Bitmap GetImageByItem(Item myItem)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = myItem.Image.ImageFile;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }


    } // End of class
} // End of namespace
