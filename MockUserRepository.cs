using Korelskiy.ModelsForGunShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Korelskiy.GunShopASP.Services
{
    public class MockUserRepository : IUserRepository
    {
        private List<User> _usersList;

        public MockUserRepository()
        {
            _usersList = new List<User>()
            {
                new User()
                {
                    Id = 1, Name = "Кирилл Владимирович", Email = "kirill@mail.ru", Password = "1507"
                },

                new User()
                {
                    Id = 2, Name = "Иван Иванович", Email = "ivan@mail.ru", Password = "1234"
                },

            };
        }

        public IEnumerable<User> GetAllUserss()
        {
            return _usersList;
        }

        public User Add(User newUser)
        {
            newUser.Id = _usersList.Max(x => x.Id) + 1;
            _usersList.Add(newUser);

            return newUser;
        }
    }
}
