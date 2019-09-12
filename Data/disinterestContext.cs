using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace disinterest.Models
{
    public class disinterestContext : DbContext
    {
        public disinterestContext (DbContextOptions<disinterestContext> options)
            : base(options)
        {
        }

        public DbSet<disinterest.Models.Product> Product { get; set; }
    }
}
