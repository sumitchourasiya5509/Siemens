using JwelleryApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwelleryApi.Repository
{
    public interface IUser
    {
        IEnumerable<User> GetUsers();
        User Login(string userName, string password);
    }
}
