using JwelleryApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwelleryApi.Context
{
    public class ApplicationDbContext:DbContext
    {

        public DbSet<User> Users { get; set; }
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
        {
            
        }


    }
}
