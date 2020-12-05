using Korelskiy.ModelsForGunShop;
using System;
using System.Collections.Generic;
using System.Text;

namespace Korelskiy.GunShopASP.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);

        Product Update(Product updatedProduct);
        Product Add(Product newProduct);
    }
}
