using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketplaceApp.Data.Classes;
using MarketplaceApp.Data.Enums;

namespace MarketplaceApp.Domain.Repositories
{
    public class BuyerRepository
    {
        public Buyer Buyer { get; set; }
        public BuyerRepository(string email)
        {
            Buyer = (Buyer)UserRepository.FindUser(email);
        }

        public void ViewAllItems()
        {
            foreach (var item in Marketplace.Items)
                if(item.Status == SaleStatus.ForSale)
                    ItemRepository.PrintItemWithDetails(item);
        }
        public string BuyItem(int id)
        {
            var item = ItemRepository.FindItem(id);

            if (item.Status != SaleStatus.ForSale)
                return "Item is not for sale. ";
            else if (item.Price > Buyer.Balance)
                return "Balance is not high enough. ";

            item.Status = SaleStatus.Sold;
            Buyer.Balance -= item.Price;
            Marketplace.Earnings += item.Price * Marketplace.TransactionFee;
            item.Seller.Earnings += item.Price * (1 - Marketplace.TransactionFee);
            return "Item is bought. ";
        }
        public string ReturnItem(int id)
        {
            var item = ItemRepository.FindItem(id);

            if (!Buyer.AllBoughtItems.Contains(item))
                return "This is not your item. ";

            item.Status = SaleStatus.ForSale;
            Buyer.Balance += item.Price * Marketplace.Refund;
            item.Seller.Earnings -= item.Price * (1 - Marketplace.Refund - Marketplace.TransactionFee);
            return "Item refunded. ";
        }
        public string AddTofavorites(int id)
        {
            var item = ItemRepository.FindItem(id);
            if (!Buyer.FavoriteItems.Contains(item))
                return "This item is already in favorites. ";

            Buyer.FavoriteItems.Add(item);
            return "Item added to favorites. ";
        }
        public void ViewAllBoughtItems()
        {
            foreach (var item in Buyer.AllBoughtItems)
                ItemRepository.PrintItem(item);
        }
        public void ViewAllFavoriteItems()
        {
            foreach (var item in Buyer.FavoriteItems)
                ItemRepository.PrintItem(item);
        }
    }
}
