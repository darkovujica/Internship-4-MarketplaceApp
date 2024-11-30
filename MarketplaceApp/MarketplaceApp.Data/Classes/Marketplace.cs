using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketplaceApp.Data.Seed;

namespace MarketplaceApp.Data.Classes
{
    public static class Marketplace
    {
        public static List<User> Users { get; set; } = Seed.Seed.Users;
        public static List<Item> Items { get; set; } = Seed.Seed.Items;
        public static List<Transactions> Transactions { get; set; } = Seed.Seed.Transactions;
        public static double Earnings { get; set; } = 0;
        public static double TransactionFee { get; set; } = 0.05;
        public static double Refund { get; set; } = 0.8;
    }
}
