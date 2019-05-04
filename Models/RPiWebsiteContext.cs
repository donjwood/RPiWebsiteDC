using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RPiWebsiteDC.Models
{
    public class RPiWebsiteContext : DbContext
    {
        public RPiWebsiteContext (DbContextOptions<RPiWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<RPiWebsiteDC.Models.User> User { get; set; }
    }
}