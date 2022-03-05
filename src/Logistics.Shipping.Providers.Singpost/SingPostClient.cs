using Logistics.Shipping.Abstractions.Pudo;
using Logistics.Shipping.Abstractions.Pudo.Models;

namespace Logistics.Shipping.Providers.Singpost
{
    public class SingPostClient : IPudoProvider
    {
        public string Name { get; set; }

        public Task<PudoLocation[]> GetLocations(PudoLocationSearch search)
        {
            var locations = new List<PudoLocation>();
            for (int i = 0; i < new Random().Next(0, 50); i++)
            {
                locations.Add(new PudoLocation
                {
                    Account = $"{nameof(SingPostClient)}.account.{i}",
                    City = $"{nameof(SingPostClient)}.city.{i}",
                    Country = $"{nameof(SingPostClient)}.country.{i}",
                    Email = $"{nameof(SingPostClient)}.email.{i}",
                    BuildingName = $"{nameof(SingPostClient)}.buildingName.{i}",
                    KioskId = $"{nameof(SingPostClient)}.kioskId.{i}",
                    HouseBlockNumber = $"{nameof(SingPostClient)}.houseBlockNo.{i}",
                    LocationDescription = $"{nameof(SingPostClient)}.locationDesc.{i}",
                    Metadata = $"{nameof(SingPostClient)}.metadata.{i}",
                    OutletId = $"{nameof(SingPostClient)}.outletId.{i}",
                    OutletName = $"{nameof(SingPostClient)}.outletName.{i}",
                });
            }

            return Task.FromResult(locations.ToArray());
        }
    }
}
