using Logistics.Shipping.Abstractions.Pudo;
using Logistics.Shipping.Abstractions.Pudo.Models;

namespace Logistics.Shipping.Providers.Asendia
{
    // Example of provider being split up by provder service type. In this case, we've a Pudo service type client.
    public class AsendiaPudoClient : IPudoProvider
    {
        public string Name { get; set; }

        public Task<PudoLocation[]> GetLocations(PudoLocationSearch search)
        {
            var locations = new List<PudoLocation>();
            for (int i = 0; i < new Random().Next(0, 50); i++)
            {
                locations.Add(new PudoLocation
                {
                    Account = $"{nameof(AsendiaPudoClient)}.account.{i}",
                    City = $"{nameof(AsendiaPudoClient)}.city.{i}",
                    Country = $"{nameof(AsendiaPudoClient)}.country.{i}",
                    Email = $"{nameof(AsendiaPudoClient)}.email.{i}",
                    BuildingName = $"{nameof(AsendiaPudoClient)}.buildingName.{i}",
                    KioskId = $"{nameof(AsendiaPudoClient)}.kioskId.{i}",
                    HouseBlockNumber = $"{nameof(AsendiaPudoClient)}.houseBlockNo.{i}",
                    LocationDescription = $"{nameof(AsendiaPudoClient)}.locationDesc.{i}",
                    Metadata = $"{nameof(AsendiaPudoClient)}.metadata.{i}",
                    OutletId = $"{nameof(AsendiaPudoClient)}.outletId.{i}",
                    OutletName = $"{nameof(AsendiaPudoClient)}.outletName.{i}",
                });
            }

            return Task.FromResult(locations.ToArray());
        }
    }
}
