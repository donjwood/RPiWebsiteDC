using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RPiWebsiteDC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RPiWebsiteContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RPiWebsiteContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        FirstName = "Admin",
                        LastName = "User",
                        UserName = "Admin",
                        Password = "Admin"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}