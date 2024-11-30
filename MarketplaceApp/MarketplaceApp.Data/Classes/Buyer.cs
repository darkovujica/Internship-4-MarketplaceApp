using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.Data.Classes
{
    public class Buyer : User
    {
        public Buyer(string name, string email, double balance, List<Item> favoriteItems, List<Item> allBoughtItems) : base(name, email)
        {
            Balance = balance;
            FavoriteItems = favoriteItems;
            AllBoughtItems = allBoughtItems;
        }
        public double Balance { get; set; }
        public List<Item> FavoriteItems { get; set; }
        public List<Item> AllBoughtItems { get; set; }
    }
}
