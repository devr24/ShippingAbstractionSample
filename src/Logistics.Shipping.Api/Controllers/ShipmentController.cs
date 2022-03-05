using Logistics.Shipping.Abstractions;
using Logistics.Shipping.Abstractions.Shipment.Models;
using Logistics.Shipping.Api.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Logistics.Shipping.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        private readonly NamedInstanceFactory<IShipmentProvider>  shipmentProviders;
        private readonly AppSettings settings;

        public ShipmentController(NamedInstanceFactory<IShipmentProvider> shipmentProviders, AppSettings settings)
        {
            this.shipmentProviders = shipmentProviders;
            this.settings = settings;
        }

        // GET: api/<Shipmentontroller>
        [HttpPost("{brand}")]
        public async Task<IActionResult> AddShipment([FromRoute]string brand, [FromBody]UpsertShipmentDto createShipment)
        {
            // Lookup the config (in reality, this would come from Cosmos - configured as part of Routing solution).
            var routeConfig = settings.Shipment.Where(s => s.Brand == brand).FirstOrDefault();

            // If no routing configured - error!
            if (routeConfig == null) return NotFound("No routing configuration for this shipment type");

            // Lookup the provider implementation.
            var provider = this.GetProvider(routeConfig.Provider);
            if (provider == null) return NotFound($"No shipment providers match this provider config {routeConfig.Provider}");

            return Ok(await provider.AddShipment(new UpsertShipment())); // Obviously there would be a DTO to Entity mapping here.
        }

        [HttpPost("{brand}/{id}/close")]
        public async Task<IActionResult> CloseShipment([FromRoute]string brand, [FromRoute]string id, [FromBody]CloseShipmentDto closeShipment)
        {
            // Lookup the config (in reality, this would come from Cosmos - configured as part of Routing solution).
            var routeConfig = settings.Shipment.Where(s => s.Brand == brand).FirstOrDefault();

            // If no routing configured - error!
            if (routeConfig == null) return NotFound("No routing configuration for this shipment type");

            // Lookup the provider implementation.
            var provider = this.GetProvider(routeConfig.Provider);
            if (provider == null) return NotFound($"No shipment providers match this provider config {routeConfig.Provider}");
            
            await provider.CloseShipment(new CloseShipments());// Obviously there would be a DTO to Entity mapping here.

            return Ok(); 
        }

        [HttpDelete("{brand}/{id}")]
        public async Task<IActionResult> DeleteShipment([FromRoute] string brand, [FromRoute]string id, [FromBody]DeleteShipmentDto deleteShipment)
        {
            // Lookup the config (in reality, this would come from Cosmos - configured as part of Routing solution).
            var routeConfig = settings.Shipment.Where(s => s.Brand == brand).FirstOrDefault();

            // If no routing configured - error!
            if (routeConfig == null) return NotFound("No routing configuration for this shipment type");

            // Lookup the provider implementation.
            var provider = this.GetProvider(routeConfig.Provider);
            if (provider == null) return NotFound($"No shipment providers match this provider config {routeConfig.Provider}");

            await provider.DeleteShipment(new DeleteShipment());// Obviously there would be a DTO to Entity mapping here.

            return Ok(); 
        }

        [HttpPut("{brand}/{id}")]
        public Task<Shipment> UpdateShipment([FromRoute] string brand, [FromRoute] string id, [FromBody] UpsertShipment request)
        {
            // Can't be bothered implementing this example :)
            throw new NotImplementedException();
        }

        private IShipmentProvider GetProvider(string providerName)
        {
            try
            {
                var provider = this.shipmentProviders[providerName];

                HttpContext.Response.Headers.Add("x-Provider", providerName); // just added the header for additional info

                return provider;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
