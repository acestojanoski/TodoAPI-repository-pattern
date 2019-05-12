using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.Domain.Models;

namespace TodoAPI.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Todo>().ToTable("Todos");
            builder.Entity<Todo>().HasKey(t => t.Id);
            builder.Entity<Todo>().Property(t => t.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Todo>().Property(t => t.Name).IsRequired().HasMaxLength(30);
        }
    }
}
