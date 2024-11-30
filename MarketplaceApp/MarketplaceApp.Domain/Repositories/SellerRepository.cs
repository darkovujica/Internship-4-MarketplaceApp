using MarketplaceApp.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketplaceApp.Domain.Repositories;
using System.Runtime.CompilerServices;
using MarketplaceApp.Data.Enums;

namespace MarketplaceApp.Domain.Repositories
{
    public class SellerRepository
    {
        public Seller Seller { get; set; }
        public SellerRepository(string email)
        {
            Seller = (Seller)UserRepository.FindUser(email);
        }

        public string AddItem(string name, string desctription, double price)
        {
            var id = ItemRepository.ItemCount++;
            var item = new Item(id, name, desctription, price);
            Seller.AllSellerItems.Add(item);
            return "Item is added. ";
        }
        public void ViewAllItems()
        {
            foreach (var item in Seller.AllSellerItems)
                ItemRepository.PrintItemWithDetails(item);
        }
        public double SeeEarnings()
        {
            return Seller.Earnings;
        }
        public void ViewItemsByCategory(int option)
        {
            var itemCategory = ItemRepository.FindItemCategory(option);

            foreach (var item in Seller.AllSellerItems)
                if (item.Status == SaleStatus.Sold && item.ItemCategory == itemCategory)
                    ItemRepository.PrintItem(item);
        }
    }
}
