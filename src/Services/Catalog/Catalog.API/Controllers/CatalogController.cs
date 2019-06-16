using Catalog.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly CatalogDbContext _catalogDbContext;

        private readonly IOptionsSnapshot<CatalogSettings> _settings;

        public CatalogController(CatalogDbContext catalogDbContext, IOptionsSnapshot<CatalogSettings> settings)
        {
            _catalogDbContext = catalogDbContext;
            _settings = settings;

            // string url = settings.Value.ExternalCatalogBaseUrl;

            ((DbContext)catalogDbContext).ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        [HttpGet]
        //[Route("[action]")]
        public async Task<IActionResult> CatalogTypes()
        {
            var items = await _catalogDbContext.CatalogTypes.ToListAsync();

            return Ok(items);
        }



    }
}
