using JWT_React_API_18.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_React_API_18.Data
{
    public interface IUserRepository
    {
        User Create(User user);
        User GetUserByEmail(string email);
    }
}
