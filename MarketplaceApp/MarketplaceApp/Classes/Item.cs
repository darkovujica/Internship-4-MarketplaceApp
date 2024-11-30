using MarketplaceApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.Classes
{
    public class Item
    {
        Guid Id;
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        SaleStatus Status { get; set; }
        Seller Seller { get; set; }
        ItemCategory ItemCategory { get; set; }
        double AverageGrade { get; set; }
    }
}
