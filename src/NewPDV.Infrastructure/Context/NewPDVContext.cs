using Microsoft.EntityFrameworkCore;
using NewPDV.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NewPDV.Infrastructure.Mappings.Mapper;

namespace NewPDV.Infrastructure.Context
{
    public class NewPDVContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Event> Events { get; set; }
        public NewPDVContext(
            DbContextOptions options
            ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new ItemMap());
            builder.ApplyConfiguration(new SaleMap());
            builder.ApplyConfiguration(new EventMap());
        }
    }
}
