using JWT_React_API_18.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_React_API_18.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public User Create(User user)
        {
            var createdUser = _context.Add(user);
            _context.SaveChanges();
            return createdUser.Entity;
        }
    }
}
