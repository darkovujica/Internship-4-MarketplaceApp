using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketplaceApp.Data.Classes;
using MarketplaceApp.Data.Enums;

namespace MarketplaceApp.Data.Seed
{
    public static class Seed
    {
        public static readonly List<User> Users = new List<User>()
        {
    new Buyer
    (
        "Ana Petrović",
        "ana.petrovic@gmail.com",
        500.00, // Balance
        new List<Item> // FavoriteItems
        {
            Items[3], // Diamond Necklace
            Items[5]  // Laptop
        },
        new List<Item> // AllBoughtItems
        {
            Items[1], // Winter Jacket
            Items[9]  // Dark Chocolate
        }
    ),
    new Buyer
    (
        "Marko Jovanović",
        "marko.jovanovic@gmail.com",
        1200.50, // Balance
        new List<Item> // FavoriteItems
        {
            Items[0], // Smartphone
            Items[10] // Bluetooth Headphones
        },
        new List<Item> // AllBoughtItems
        {
            Items[4], // Organic Honey
            Items[6]  // Running Shoes
        }
    ),
    new Seller
    (
        "Jelena Nikolić",
        "jelena.nikolic@gmail.com",
        818.99, // Earnings
        new List<Item> // AllSellerItems
        {
            Items[2],  // Cookbook
            Items[4],  // Organic Honey
            Items[9]   // Dark Chocolate
        }
    ),
    new Seller
    (
        "Milan Petrović",
        "milan.petrovic@gmail.com",
        4148.99, // Earnings
        new List<Item> // AllSellerItems
        {
            Items[0],  // Smartphone
            Items[3],  // Diamond Necklace
            Items[5]   // Laptop
        }
    ),
    new Buyer
    (
        "Ivana Kovačević",
        "ivana.kovacevic@gmail.com",
        600.00, // Balance
        new List<Item> // FavoriteItems
        {
            Items[11], // Leather Jacket
            Items[17]  // Mystery Novel
        },
        new List<Item> // AllBoughtItems
        {
            Items[12], // Fantasy Novel
            Items[14]  // Granola Bars
        }
    )
        };
        public static readonly List<Item> Items = new List<Item>()
        {
            new Item
    (
        0,
        "Smartphone",
        "Latest model with 5G connectivity and 128GB storage.",
        799.99,
        SaleStatus.ForSale,
        ItemCategory.Electronics,
        4.5
    ),
    new Item
    (
        1,
        "Winter Jacket",
        "Warm and stylish jacket for cold weather.",
        149.99,
        SaleStatus.Sold,
        ItemCategory.Clothes,
        4.0
    ),
    new Item
    (
        2,
        "Cookbook",
        "A collection of over 200 recipes for quick meals.",
        29.99,
        SaleStatus.Sold,
        ItemCategory.Books,
        4.8
    ),
    new Item
    (
        3,
        "Diamond Necklace",
        "Elegant necklace with a real diamond centerpiece.",
        3999.00,
        SaleStatus.ForSale,
        ItemCategory.Jewelry,
        5.0
    ),
    new Item
    (
        4,
        "Organic Honey",
        "Pure organic honey from local beekeepers.",
        19.99,
        SaleStatus.Sold,
        ItemCategory.Food,
        4.7
    ),
    new Item
    (
        5,
        "Laptop",
        "Lightweight laptop with high performance.",
        1200.00,
        SaleStatus.ForSale,
        ItemCategory.Electronics,
        4.9
    ),
    new Item
    (
        6,
        "Running Shoes",
        "Comfortable shoes for daily jogging.",
        89.99,
        SaleStatus.Sold,
        ItemCategory.Clothes,
        4.3
    ),
    new Item
    (
        7,
        "Sci-Fi Novel",
        "A thrilling space adventure story.",
        14.99,
        SaleStatus.Sold,
        ItemCategory.Books,
        4.6
    ),
    new Item
    (
        8,
        "Gold Bracelet",
        "Simple yet elegant gold bracelet.",
        499.99,
        SaleStatus.ForSale,
        ItemCategory.Jewelry,
        4.9
    ),
    new Item
    (
        9,
        "Dark Chocolate",
        "Rich and smooth 80% dark chocolate.",
        5.99,
        SaleStatus.Sold,
        ItemCategory.Food,
        4.8
    ),
    new Item
    (
        10,
        "Bluetooth Headphones",
        "Noise-canceling wireless headphones.",
        159.99,
        SaleStatus.ForSale,
        ItemCategory.Electronics,
        4.7
    ),
    new Item
    (
        11,
        "Leather Jacket",
        "Classic leather jacket for every occasion.",
        299.99,
        SaleStatus.ForSale,
        ItemCategory.Clothes,
        4.6
    ),
    new Item
    (
        12,
        "Fantasy Novel",
        "Magical adventures in an enchanted world.",
        24.99,
        SaleStatus.Sold,
        ItemCategory.Books,
        4.5
    ),
    new Item
    (
        13,
        "Pearl Earrings",
        "Timeless pearl earrings for any outfit.",
        299.99,
        SaleStatus.ForSale,
        ItemCategory.Jewelry,
        4.7
    ),
    new Item
    (
        14,
        "Granola Bars",
        "Healthy and delicious snack on the go.",
        3.99,
        SaleStatus.Sold,
        ItemCategory.Food,
        4.4
    ),
    new Item
    (
        15,
        "Gaming Console",
        "Next-gen console with incredible graphics.",
        499.99,
        SaleStatus.ForSale,
        ItemCategory.Electronics,
        4.8
    ),
    new Item
    (
        16,
        "Wool Sweater",
        "Soft sweater for cold winter days.",
        79.99,
        SaleStatus.Sold,
        ItemCategory.Clothes,
        4.3
    ),
    new Item
    (
        17,
        "Mystery Novel",
        "A page-turning whodunit story.",
        19.99,
        SaleStatus.ForSale,
        ItemCategory.Books,
        4.2
    ),
    new Item
    (
        18,
        "Silver Ring",
        "Elegant silver ring for all occasions.",
        79.99,
        SaleStatus.ForSale,
        ItemCategory.Jewelry,
        4.6
    ),
    new Item
    (
        19,
        "Organic Coffee",
        "Locally sourced organic coffee beans.",
        12.99,
        SaleStatus.Sold,
        ItemCategory.Food,
        4.7
    )
        };
        public static readonly List<Transactions> Transactions = new List<Transactions>()
        {

        };
    }
}
