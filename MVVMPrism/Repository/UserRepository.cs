using MVVMPrism.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPrism.Repository
{
    public class UserRepository : IRepositoryModels<User>
    {
        private List<User> userListTemporal = new List<User>()
        {
            new User()
            {
                Email = "a@a.com",
                Password = "arkus@123",
                UserId = 1,
                UserName = "First user"
            },

            new User()
            {
                Email = "b@b.com",
                Password = "arkus@123",
                UserId = 2,
                UserName = "Second user"
            }
        };

        public List<User> GetAllData()
        {
            return userListTemporal;
        }

        public User GetItem(int id)
        {
            return new User()
            {
                UserId = id,
                UserName = "Some user found",
                Email = "aaa@a.com",
                Password = "abc123"
            };
        }

        public bool Insert(User item)
        {
            userListTemporal.Add(item);
            return true;
        }

        public bool Update(User item)
        {
            var itemIndex = userListTemporal.FindIndex((element) => element.UserId == item.UserId);
            var itemFound = itemIndex > 0;
            if (itemFound)
                userListTemporal[itemIndex] = item;
            
            return itemFound;
        }

        public bool Delete(User item)
        {
            var newList = userListTemporal.Where((element) => element != item).ToList();
            userListTemporal = newList;
            return true;
        }

        public void Clear()
        {
            // clear we xd
        }
    }
}
