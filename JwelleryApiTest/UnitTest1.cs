using JwelleryApi.Controllers;
using JwelleryApi.Models;
using JwelleryApi.Repository;
using System;
using System.Collections.Generic;
using Xunit;

namespace JwelleryApiTest
{
    public class UnitTest1
    {
        UsersController _controller;
        IUser _service;
         public UnitTest1()
        {
            _service = new UserRepository();
            _controller = new UsersController(_service);
        }


        [Fact]
        public IEnumerable<User> GetUsers()
        {
            retrun _controller.
        }
    }
}
