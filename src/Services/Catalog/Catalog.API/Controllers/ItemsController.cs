using Catalog.API.Model;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;






namespace Catalog.API.Controllers
{
    public class ItemsController : JsonApiController<CatalogItem>
    {
        public ItemsController(
            IJsonApiContext jsonApiContext,
            IResourceService<CatalogItem> resourceService,
            ILoggerFactory loggerFactory) : base(jsonApiContext, resourceService, loggerFactory)
        {

        }
    }
}
