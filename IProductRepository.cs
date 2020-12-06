using Korelskiy.ModelsForGunShop;
using System;
using System.Collections.Generic;
using System.Text;

namespace Korelskiy.GunShopASP.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> Search(string searchTerm);
        IEnumerable<Product> GetAllProducts();
        IEnumerable<CategoriesHeadCount> ProductCoundByCategory(Cat? cat);
        Product GetProduct(int id);

        Product Update(Product updatedProduct);
        Product Add(Product newProduct);
        Product Delete(int id);
    }
}
