using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NewPDV.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPDV.Infrastructure.Mappings
{
    public class Mapper
    {
        public class ProductMap : IEntityTypeConfiguration<Product>
        {
            public void Configure(EntityTypeBuilder<Product> builder)
            {

                builder.ToTable("Products");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Name).IsRequired();
                builder.Property(x => x.Price).IsRequired();
                builder.Property(x => x.Image).HasColumnType("varbinary(MAX)").HasConversion<byte[]>();

            }
        }
        public class ItemMap : IEntityTypeConfiguration<Item>
        {
            public void Configure(EntityTypeBuilder<Item> builder)
            {

                builder.ToTable("Items");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Name).IsRequired();
                builder.Property(x => x.Price).IsRequired();

            }
        }
        public class SaleMap : IEntityTypeConfiguration<Sale>
        {
            public void Configure(EntityTypeBuilder<Sale> builder)
            {

                builder.ToTable("Sales");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.PaymentMethod);
                builder.HasMany(x => x.Items);
            }
        }
        public class EventMap : IEntityTypeConfiguration<Event>
        {
            public void Configure(EntityTypeBuilder<Event> builder)
            {

                builder.ToTable("Events");
                builder.HasKey(x => x.Id);
                builder.HasMany(x => x.Sales);

            }
        }
    }
}
