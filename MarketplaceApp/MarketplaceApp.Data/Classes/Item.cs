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
        public SaleStatus Status { get; set; }
        public ItemCategory ItemCategory { get; set; }
        public double AverageGrade { get; set; }
        public Item(int id, string name, string description, double price, SaleStatus status = SaleStatus.ForSale, ItemCategory itemCategory = ItemCategory.Unknown, double grade = 0)
        {
            Name = name;
            Description = description;
            Price = price;
            Id = id;
            Status = status;
            ItemCategory = itemCategory;
            AverageGrade = grade;
        }
    }
}
