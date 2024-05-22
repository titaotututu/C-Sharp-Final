using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Crud;

namespace TravelApi.Repository
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options) : base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表
        }

        //public DbSet<...> ... { get; set; }
    }
}
