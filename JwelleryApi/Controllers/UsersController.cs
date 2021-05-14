using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JwelleryApi.Models;
using JwelleryApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwelleryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUser _user;
        public UsersController(IUser user)
        {
            _user = user;
        }
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<User> users;
            try
            {
                users = _user.GetUsers();
                if(users.Any())
                {
                    return Ok(users);
                }
                else
                {
                    return NotFound();
                }
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("Login")]
        public IActionResult Login(string userName, string password)
        {
            User user = new User();
            user = _user.Login(userName, password);
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound();
            }
        }
    }
}