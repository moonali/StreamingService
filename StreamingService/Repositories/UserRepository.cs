using StreamingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StreamingService.Repositories
{
    public class UserRepository : IUser
    {
        public int RemainingSongsThisMonth { get;set; }

        public void Add(User user)
        {
            List<User> addUser = new List<User>();
            User user4 = new User()
            {
                FirstName = "willey",
                LastName = "David",
                EmailAddress = "David@David.com",
            };
            addUser.Add(user4);
        }
        public bool UserExist(string email)
        {
            var User = GetAllUser();
            bool CheckIfExist = User.Any(x => x.EmailAddress == email);
            if (CheckIfExist)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<User> GetAllUser()
        {
            return new List<User>()
            {
                new User()
                {
                    FirstName ="johan",
                    LastName ="tom",
                    EmailAddress ="johan@johan.com",
                },
                 new User()
                {
                    FirstName ="banton",
                    LastName ="cook",
                    EmailAddress ="banton@banton.com",
                },
                  new User()
                {
                    FirstName ="roy",
                    LastName ="jason",
                    EmailAddress ="roy@roy.com",
                },
                   new User()
                {
                    FirstName ="virat",
                    LastName ="kohli",
                    EmailAddress ="virat@johan.com",
                },
            }.ToArray();
        }
    }
}
