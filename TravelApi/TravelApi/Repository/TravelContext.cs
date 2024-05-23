using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Crud;
using TravelApi.Models;

namespace TravelApi.Repository
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options) : base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
