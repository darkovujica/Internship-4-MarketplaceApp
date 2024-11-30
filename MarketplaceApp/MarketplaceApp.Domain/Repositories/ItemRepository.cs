using MarketplaceApp.Data.Classes;
using MarketplaceApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.Domain.Repositories
{
    public static class ItemRepository
    {
        public static int ItemCount = Marketplace.Items.Count;
        public static void ViewAllSellingItems()
        {
            var allItems = Marketplace.Items;
            foreach (var item in allItems)
            {
                if (item.Status == SaleStatus.ForSale)
                    PrintItem(item);
            }
        }
        public static void PrintItem(Item item)
        {
            Console.WriteLine($"Name: {item.Name} - Price: {item.Price} - Description: {item.Description}");
        }
        public static void PrintItemWithDetails(Item item)
        {
            var forSale = "yes";
            if(item.Status == SaleStatus.Sold) forSale = "no";
            Console.WriteLine($"ID: {item.Id} - Name: {item.Name} - Price: {item.Price} - Description: {item.Description} - For Sale: {forSale}");
        }
        public static Item FindItem(int id)
        {
            foreach (var item in Marketplace.Items)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }
        public static bool ItemExists(int id)
        {
            foreach (var item in Marketplace.Items)
                if (item.Id == id)
                    return true;
            return false;
        }
        public static ItemCategory FindItemCategory(int option)
        {
            switch (option)
            {
                case 1:
                    return ItemCategory.Electronics;
                case 2:
                    return ItemCategory.Clothes;
                case 3:
                    return ItemCategory.Books;
                case 4:
                    return ItemCategory.Jewelry;
                case 5:
                    return ItemCategory.Food;
                default:
                    return ItemCategory.Unknown;
            }
        }
    }
}
