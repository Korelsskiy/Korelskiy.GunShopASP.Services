using Korelskiy.ModelsForGunShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Korelskiy.GunShopASP.Services
{
    public class SqlProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public SqlProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public Product Add(Product newProduct)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return newProduct;
        }

        public Product Delete(int id)
        {
            var productToDelete = _context.Products.Find(id);

            if (productToDelete != null)
            {
                _context.Products.Remove(productToDelete);
                _context.SaveChanges();
            }

            return productToDelete;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }

        public Product GetProduct(int id)
        {
            return _context.Products.Find(id);
        }

        public IEnumerable<CategoriesHeadCount> ProductCoundByCategory(Cat? category)
        {
            IEnumerable<Product> query = _context.Products;

            if (category.HasValue)
            {
                query = query.Where(x => x.Category == category.Value);
            }

            return query.GroupBy(x => x.Category)
                .Select(x => new CategoriesHeadCount()
                {
                    Categories = x.Key.Value,
                    Count = x.Count()
                }).ToList(); // обязательно надо задать действие - в лист
        }

        public IEnumerable<Product> Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return _context.Products;
            }

            return _context.Products.Where(x => x.Title.ToLower().Contains(searchTerm));
        }

        public Product Update(Product updatedProduct)
        {
            var product = _context.Products.Attach(updatedProduct); // находит продукт и изменяет его
            product.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updatedProduct;
        }
    }
}
