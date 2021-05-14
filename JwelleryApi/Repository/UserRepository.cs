using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JwelleryApi.Context;
using JwelleryApi.Models;

namespace JwelleryApi.Repository
{
    public class UserRepository : IUser
    {
        private ApplicationDbContext _context;
      
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<User> GetUsers()
        {
            return _context.Users;

        }
        
        public User Login(string userName, string password)
        {
            User result = new User();
            result = _context.Users.Where(x => x.userName == userName && x.password == password).FirstOrDefault();
            return result;
        }
    }
}
