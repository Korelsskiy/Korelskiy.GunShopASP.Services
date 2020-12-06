using Korelskiy.ModelsForGunShop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Korelskiy.GunShopASP.Services
{
    public class MokProductRepository : IProductRepository
    {
        private List<Product> _productsList;
        

        public MokProductRepository()
        {
            _productsList = new List<Product>()
            {
                new Product()
                {
                    Id = 0, Title = "Винтовка Мосина", Category = Cat.Винтовки, Country = "СССР", Price = 15_000, Producer = "Сестрорецкий Оружейный Завод", PhotoPath = "mosin.jpg"
                },
                new Product()
                {
                    Id = 1, Title = "Пистолет-пулемет Шпагина", Category = Cat.ПП, Country = "СССР", Price = 35_000, Producer = "Вятско-Полянский машиностроительный завод \"Молот\"", PhotoPath = "ppsh.jpg"
                },
                new Product()
                {
                    Id = 2, Title = "ДП", Category = Cat.Пулеметы, Country = "СССР", Price = 63_000, Producer = "Завод имени Дегятрева", PhotoPath = "dp.jpg"
                },
                new Product()
                {
                    Id = 3, Title = "Mauser 98k", Category = Cat.Винтовки, Country = "Третий Рейх", Price = 40_000, Producer = " Mauser", PhotoPath = "mauser.jpe"
                },
                new Product()
                {
                    Id = 4, Title = "MP-40", Category = Cat.ПП, Country = "Третий Рейх", Price = 97_000, Producer = "ERMA", PhotoPath = "mp_40.jpe"
                },
                new Product()
                {
                    Id = 5, Title = "MG-34", Category = Cat.Пулеметы, Country = "Третий Рейх", Price = 154_000, Producer = "Mauserwerke AG", PhotoPath = "mg_34.jpg"
                },
                new Product()
                {
                    Id = 6, Title = "Springfield М1903", Category = Cat.Винтовки, Country = "США", Price = 60_000, Producer = "Springfield Armory", PhotoPath = "springfield.jpg"
                },
                new Product()
                {
                    Id = 7, Title = "Пистолет-пулемет Томпсона", Category = Cat.ПП, Country = "США", Price = 140_000, Producer = "Auto-Ordnance Companyy", PhotoPath = "thompson.jpg"
                },
                new Product()
                {
                    Id = 8, Title = "Браунинг M1918", Category = Cat.Пулеметы, Country = "США", Price = 123_000, Producer = "Colt’s Manufacturing Company", PhotoPath = "browning.jpg"
                },
                new Product()
                {
                    Id = 9, Title = "Arisaka Type 38", Category = Cat.Винтовки, Country = "Япония", Price = 250_000, Producer = "Нет данных", PhotoPath = "arisaka.jpg"
                }
            };
        }

        public Product Add(Product newProduct)
        {
            newProduct.Id = _productsList.Max(x => x.Id) + 1;
            _productsList.Add(newProduct);

            return newProduct;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productsList;
        }

        public Product GetProduct(int id)
        {
            return _productsList.FirstOrDefault(x => x.Id == id);
        }

        public Product Update(Product updatedProduct)
        {
            Product product = _productsList.FirstOrDefault(x => x.Id == updatedProduct.Id);

            if (product != null)
            {
                product.Title = updatedProduct.Title;
                product.Category = updatedProduct.Category;
                product.Country = updatedProduct.Country;
                product.Price = updatedProduct.Price;
                product.Producer = updatedProduct.Producer;
                product.PhotoPath = updatedProduct.PhotoPath; 
            }

            return product;
        }

        public Product Delete(int id)
        {
            Product productToDelete = _productsList.FirstOrDefault(x => x.Id == id);
            if (productToDelete != null)
            {
                _productsList.Remove(productToDelete);
            }
            
            return productToDelete;
        }

        public IEnumerable<CategoriesHeadCount> ProductCoundByCategory(Cat? category)
        {

            IEnumerable<Product> query = _productsList;

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
                return _productsList;
            }

            return _productsList.Where(x => x.Title.ToLower().Contains(searchTerm));
        }
    }
}
