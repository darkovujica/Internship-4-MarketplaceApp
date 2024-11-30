using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.Data.Classes
{
    public abstract class User
    {
        public Guid Id { get;}
        public string Name { get; set; }
        public string Email { get; }
        public User(string name, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
        }
    }
}
