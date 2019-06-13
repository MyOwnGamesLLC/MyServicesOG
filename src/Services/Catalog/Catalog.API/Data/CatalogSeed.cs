using Catalog.API.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogSeed
    {

        public static async Task SeedAsync(CatalogDbContext context)
        {
            if (!context.CatalogTypes.Any())
            {
                context.CatalogTypes.AddRange(GetPreConfiguredCatalogTypes());
                await context.SaveChangesAsync();
            }

            if (!context.CatalogItems.Any())
            {
                context.CatalogItems.AddRange(GetPreConfiguredCatalogItems());
                await context.SaveChangesAsync();
            }
        }


        static IEnumerable<CatalogType> GetPreConfiguredCatalogTypes()
        {
            return new List<CatalogType>()
            {
                new CatalogType()
                {
                    Name = "Type 01",
                    Code = "type_01"
                },
                new CatalogType()
                {
                    Name = "Type 02",
                    Code = "type_02"
                }
            };
        }


        static IEnumerable<CatalogItem> GetPreConfiguredCatalogItems()
        {
            return new List<CatalogItem>()
            {
                new CatalogItem()
                {
                    Name = "Product 01",
                    Sku = "prod908516",
                    Description = "A nice description here 01",
                    PricingList = 199.99m,
                    CatalogTypeId=1,
                },
                new CatalogItem()
                {
                    Name = "Product 02",
                    Sku = "prod164521",
                    Description = "A nice description here 02",
                    PricingList = 399.90m,
                    PricingSale = 349.90m,
                    CatalogTypeId=2,
                },
                new CatalogItem()
                {
                    Name = "Product 03",
                    Sku = "prod345444",
                    Description = "A nice description here 03",
                    PricingList = 24.49m,
                    CatalogTypeId=1,
                }

            };
        }



    }
}