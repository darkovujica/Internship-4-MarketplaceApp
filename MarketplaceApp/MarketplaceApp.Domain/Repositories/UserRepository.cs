using MarketplaceApp.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.Domain.Repositories
{
    public static class UserRepository
    {
        public static void AddNewBuyer(string name, string email, double balance)
        {
            var buyer = new Buyer(name, email, balance, new List<Item>(), new List<Item>());
            Marketplace.Users.Add(buyer);
            
        }
        public static void AddNewSeller(string name, string email)
        {
            Marketplace.Users.Add(new Seller(name, email, 0.0, new List<Item>()));
        }
        public static bool EmailExists(string email)
        {
            foreach (var user in Marketplace.Users)
            {
                if (user.Email == email)
                    return true;
            }
            return false;
        }
        public static bool IsBuyer(string email)
        {
            foreach (var user in Marketplace.Users)
                if (user.Email == email && (Buyer)user != null)
                    return true;
            return false;
        }
        public static bool IsBuyer2(User user)
        {
            if ((Buyer)user != null)
                return true;
            return false;
        }
        public static User FindUser(string email)
        {
            foreach (var user in Marketplace.Users)
            {
                if (user.Email == email)
                    return user;
            }
            return null;
        }
    }
}
