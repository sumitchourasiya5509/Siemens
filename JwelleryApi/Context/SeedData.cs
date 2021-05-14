using JwelleryApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwelleryApi.Context
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
           serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Users.Any())
                {
                    return;   // Data was already seeded
                }
                context.Users.AddRange(
                        new User
                        {
                            id = 1,
                            userName = "test1",
                            password = "test",
                            userType = "Regular"
                        },
                         new User
                         {
                             id = 2,
                             userName = "test2",
                             password = "test",
                             userType = "Privileged"
                         }
                    );
                context.SaveChanges();
            }
        }
    }
}
