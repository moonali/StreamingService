using StreamingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingService.Repositories
{
    public interface IUser
    {
        int RemainingSongsThisMonth { get; set; }

        void Add(User user);
        bool UserExist(string email);
        IEnumerable<User> GetAllUser();
    }
}
