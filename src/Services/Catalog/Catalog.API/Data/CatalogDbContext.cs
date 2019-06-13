using Catalog.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.API.Data
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CatalogType>(ConfigureCatalogType);
            builder.Entity<CatalogItem>(ConfigureCatalogItem);
        }

        private void ConfigureCatalogType(EntityTypeBuilder<CatalogType> builder)
        {
            builder.ToTable("CatalogTypes");

            // Properties:

            builder.Property(e => e.Id)
                .ForSqlServerUseSequenceHiLo("catalog_types_hilo")
                .IsRequired(true);
            builder.Property(e => e.Name)
                .IsRequired(true)
                .HasMaxLength(50);
            builder.Property(e => e.Code)
                .IsRequired(true)
                .HasMaxLength(32);

            // Indexes: 

            // Code must be unique
            builder.HasIndex(e => e.Code)
                .IsUnique();
        }

        private void ConfigureCatalogItem(EntityTypeBuilder<CatalogItem> builder)
        {
            builder.ToTable("CatalogItems");

            // Properties:

            builder.Property(e => e.Id)
                .ForSqlServerUseSequenceHiLo("catalog_items_hilo")
                .IsRequired(true);
            builder.Property(e => e.Name)
                .IsRequired(true)
                .HasMaxLength(50);
            builder.Property(e => e.Sku)
                .IsRequired(true)
                .HasMaxLength(50);
            builder.Property(e => e.PricingList)
                .IsRequired(true);
            builder.Property(e => e.PricingSale)
                .IsRequired(false);

            // Indexes: 

            builder.HasOne(e => e.CatalogType)
                .WithMany()
                .HasForeignKey(e => e.CatalogTypeId);
        }

        public DbSet<CatalogType> CatalogTypes { get; set; }
        public DbSet<CatalogItem> CatalogItems { get; set; }

    }
}
