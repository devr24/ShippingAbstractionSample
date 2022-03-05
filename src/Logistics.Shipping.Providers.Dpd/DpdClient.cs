using Logistics.Shipping.Abstractions;
using Logistics.Shipping.Abstractions.Pudo;
using Logistics.Shipping.Abstractions.Pudo.Models;
using Logistics.Shipping.Abstractions.Shipment.Models;

namespace Logistics.Shipping.Providers.Dpd
{
    // Example of one client class with multiple providers interfaces implemented.
    public class DpdClient : IPudoProvider, IShipmentProvider
    {
        private readonly DpdClientConfig config;

        public string Name { get; set; }

        public DpdClient(DpdClientConfig config)
        {
            this.config = config;
        }

        #region Pudo

        public Task<PudoLocation[]> GetLocations(PudoLocationSearch search)
        {
            var locations = new List<PudoLocation>();
            for (int i = 0; i < new Random().Next(0, 50); i++)
            {
                locations.Add(new PudoLocation
                {
                    Account = $"{nameof(DpdClient)}.account.{i}",
                    City = $"{nameof(DpdClient)}.city.{i}",
                    Country = $"{nameof(DpdClient)}.country.{i}",
                    Email = $"{nameof(DpdClient)}.email.{i}",
                    BuildingName = $"{nameof(DpdClient)}.buildingName.{i}",
                    KioskId = $"{nameof(DpdClient)}.kioskId.{i}",
                    HouseBlockNumber = $"{nameof(DpdClient)}.houseBlockNo.{i}",
                    LocationDescription = $"{nameof(DpdClient)}.locationDesc.{i}",
                    Metadata = $"{nameof(DpdClient)}.metadata.{i}",
                    OutletId = $"{nameof(DpdClient)}.outletId.{i}",
                    OutletName = $"{nameof(DpdClient)}.outletName.{i}",
                });
            }

            return Task.FromResult(locations.ToArray());
        }

        #endregion

        #region Shipment 

        public Task<Shipment> AddShipment(UpsertShipment request)
        {
            var randId = new Random().Next(0, 50);
            var shipment = new Shipment
            {
                CarrierCode = $"{nameof(DpdClient)}.carrierCode.{randId}",
                CarrierDescription = $"{nameof(DpdClient)}.carrierDescription.{randId}",
                CarrierServiceDescription = $"{nameof(DpdClient)}.carrierServiceDesc.{randId}",
                Currency = $"{nameof(DpdClient)}.currency.{randId}",
                ExternalShipmentIdentifier = $"{nameof(DpdClient)}.externalShipmentId.{randId}",
                SequenceNumber = $"{nameof(DpdClient)}.sequenceNo.{randId}",
                ServiceCode = $"{nameof(DpdClient)}.serviceCode.{randId}",
                TrackingUrl = $"{nameof(DpdClient)}.trackingUrl.{randId}",
            };

            return Task.FromResult(shipment);
        }

        public Task CloseShipment(CloseShipments request)
        {
            return Task.CompletedTask;
        }

        public Task<bool> DeleteShipment(DeleteShipment request)
        {
            return Task.FromResult(true);
        }

        public Task<Shipment> UpdateShipment(UpsertShipment request)
        {
            var randId = new Random().Next(0, 50);
            var shipment = new Shipment
            {
                CarrierCode = $"{nameof(DpdClient)}.carrierCode.{randId}",
                CarrierDescription = $"{nameof(DpdClient)}.carrierDescription.{randId}",
                CarrierServiceDescription = $"{nameof(DpdClient)}.carrierServiceDesc.{randId}",
                Currency = $"{nameof(DpdClient)}.currency.{randId}",
                ExternalShipmentIdentifier = $"{nameof(DpdClient)}.externalShipmentId.{randId}",
                SequenceNumber = $"{nameof(DpdClient)}.sequenceNo.{randId}",
                ServiceCode = $"{nameof(DpdClient)}.serviceCode.{randId}",
                TrackingUrl = $"{nameof(DpdClient)}.trackingUrl.{randId}",
            };

            return Task.FromResult(shipment);
        }

        #endregion
    }
}
