using JsonApiDotNetCore.Models;

namespace Catalog.API.Model
{
    public class CatalogItem : Identifiable<int>
    {

        [Attr]
        public string Name { get; set; }

        [Attr]
        public string Sku { get; set; }

        [Attr]
        public string Description { get; set; }

        [Attr]
        public decimal PricingList { get; set; }

        [Attr]
        public decimal? PricingSale { get; set; }

        public int CatalogTypeId { get; set; }

        public CatalogType CatalogType { get; set; }

    }
}
