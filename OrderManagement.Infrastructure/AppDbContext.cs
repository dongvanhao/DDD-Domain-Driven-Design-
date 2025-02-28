using Microsoft.EntityFrameworkCore;
using OrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
