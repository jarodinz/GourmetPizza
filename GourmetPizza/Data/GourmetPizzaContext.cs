using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GourmetPizza.Models
{
    public class GourmetPizzaContext : DbContext
    {
        public GourmetPizzaContext (DbContextOptions<GourmetPizzaContext> options)
            : base(options)
        {
        }

        public DbSet<GourmetPizza.Models.Pizza> Pizza { get; set; }
    }
}
