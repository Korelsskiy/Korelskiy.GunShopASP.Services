using Korelskiy.ModelsForGunShop;
using System;
using System.Collections.Generic;
using System.Text;

namespace Korelskiy.GunShopASP.Services
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public SqlUserRepository(AppDbContext context)
        {
            _context = context;
        }
        public User Add(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public IEnumerable<User> GetAllUserss()
        {
            return _context.Users;
        }
    }
}
