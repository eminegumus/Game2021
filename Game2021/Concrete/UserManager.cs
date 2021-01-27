using System;
using System.Collections.Generic;
using System.Text;
using Game2021.Abstract;
using Game2021.Entities;

namespace Game2021.Concrete
{
    public class UserManager : IBaseService<User>
    {
        private IUserCheckService _userCheckService;

        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public void Save(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                Console.WriteLine(user.FirstName+" User is Added!");
            }
            else
            {
                Console.WriteLine(user.FirstName+" User is not valid");
            }

        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName+" is updated.");
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName+" is deleted.");
        }
    }
}
