using Logistics.Shipping.Abstractions;
using Logistics.Shipping.Abstractions.Pudo;
using Logistics.Shipping.Abstractions.Pudo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Logistics.Shipping.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PudoController : ControllerBase
    {
        private readonly NamedInstanceFactory<IPudoProvider>  pudoProviders;
        private readonly AppSettings settings;

        public PudoController(NamedInstanceFactory<IPudoProvider> pudoProviders, AppSettings settings)
        {
            this.pudoProviders = pudoProviders;
            this.settings = settings;
        }

        // GET: api/<PudoController>
        [HttpGet("{brand}")]
        public async Task<IActionResult> GetLocation([FromRoute]string brand, [FromQuery]Models.PudoLocationSearchDto search)
        {
            // Lookup the config (in reality, this would come from Cosmos - configured as part of Routing solution).
            var routeConfig = settings.Pudo.Where(p => p.Origin == search.Origin && p.Destination == search.Destination && p.Brand == brand).FirstOrDefault();

            // If no routing configured - error!
            if (routeConfig == null) return NotFound("No routing configuration for this pudo search");

            // Lookup the provider implementation.
            var provider = this.pudoProviders[routeConfig.Provider];

            if (provider == null) return NotFound($"No pudo providers match this provider config {routeConfig.Provider}");

            HttpContext.Response.Headers.Add("x-Provider", routeConfig.Provider); // just added the header for additional info

            return Ok(await provider.GetLocations(new PudoLocationSearch()));
        }
    }
}
