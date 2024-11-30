using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.Data.Classes
{
    public class Transactions
    {
        public Guid TransactionsId { get; set; }
        public Seller Seller { get; set; }
        public Buyer Buyer { get; set; }
        public Item Item { get; set; }
        
        public Transactions(Seller seller, Buyer buyer, Item item)
        {
            TransactionsId = Guid.NewGuid();
            Seller = seller;
            Buyer = buyer;
            Item = item;
        }
    }
}
