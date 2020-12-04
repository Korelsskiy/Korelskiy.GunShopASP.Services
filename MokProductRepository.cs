using GunShopASP.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
                    Id = 0, Title = "Винтовка Мосина", Category = Cat.Rifles, Country = "СССР", Price = 15_000, Producer = "Сестрорецкий Оружейный Завод", PhotoPath = "mosin.jpg"
                },
                new Product()
                {
                    Id = 0, Title = "Пистолет-пулемет Шпагина", Category = Cat.Submachines, Country = "СССР", Price = 35_000, Producer = "Вятско-Полянский машиностроительный завод \"Молот\"", PhotoPath = "ppsh.jpg"
                },
                new Product()
                {
                    Id = 0, Title = "ДП", Category = Cat.Machineguns, Country = "СССР", Price = 63_000, Producer = "Завод имени Дегятрева", PhotoPath = "dp.jpg"
                },
                new Product()
                {
                    Id = 0, Title = "Mauser 98k", Category = Cat.Rifles, Country = "Третий Рейх", Price = 40_000, Producer = " Mauser", PhotoPath = "mauser.jpe"
                },
                new Product()
                {
                    Id = 0, Title = "MP-40", Category = Cat.Submachines, Country = "Третий Рейх", Price = 97_000, Producer = "ERMA", PhotoPath = "mp_40.jpg"
                },
                new Product()
                {
                    Id = 0, Title = "MG-34", Category = Cat.Machineguns, Country = "Третий Рейх", Price = 154_000, Producer = "Mauserwerke AG", PhotoPath = "mg_34.jpe"
                },
                new Product()
                {
                    Id = 0, Title = "Springfield М1903", Category = Cat.Rifles, Country = "США", Price = 60_000, Producer = "Springfield Armory", PhotoPath = "springfeeld.jpg"
                },
                new Product()
                {
                    Id = 0, Title = "Пистолет-пулемет Томпсона", Category = Cat.Submachines, Country = "США", Price = 140_000, Producer = "Auto-Ordnance Companyy", PhotoPath = "thompson.jpg"
                },
                new Product()
                {
                    Id = 0, Title = "Браунинг M1918", Category = Cat.Machineguns, Country = "США", Price = 123_000, Producer = "Colt’s Manufacturing Company", PhotoPath = "browning.jpg"
                },
                new Product()
                {
                    Id = 0, Title = "Arisaka Type 38", Category = Cat.Rifles, Country = "Япония", Price = 250_000, Producer = "Нет данных", PhotoPath = "arisaka.jpg"
                }
            };
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _productsList;
        }
    }
}
