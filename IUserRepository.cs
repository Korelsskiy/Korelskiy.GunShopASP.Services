using Korelskiy.ModelsForGunShop;
using System;
using System.Collections.Generic;
using System.Text;

namespace Korelskiy.GunShopASP.Services
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUserss();
        User Add(User newUser);
    }
}
