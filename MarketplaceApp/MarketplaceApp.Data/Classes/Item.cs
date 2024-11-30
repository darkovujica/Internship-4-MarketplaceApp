using MarketplaceApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.Data.Classes
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public SaleStatus Status { get; set; } = SaleStatus.ForSale;
        public Seller Seller { get; set; }
        public ItemCategory ItemCategory { get; set; } = ItemCategory.Unknown;
        public double AverageGrade { get; set; }
        public Item(string name, string description, double price, Seller seller, int id)
        {
            Name = name;
            Description = description;
            Price = price;
            Seller = seller;
            Id = id;
        }
    }
}
