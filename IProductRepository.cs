using GunShopASP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Korelskiy.GunShopASP.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}
