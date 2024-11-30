using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.Data.Classes
{
    public class Seller : User
    {
        public Seller(string name, string email, double earnings, List<Item> allSellerItems) : base(name, email)
        {
            AllSellerItems = allSellerItems;
        }
        public double Earnings { get; set; } = 0;
        public List<Item> AllSellerItems { get; set; }
    }
}
