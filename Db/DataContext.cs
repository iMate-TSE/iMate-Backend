using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace iMate.API.Db
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //public DbSet<Pizza> Pizzas { get; set; }

    }
}
