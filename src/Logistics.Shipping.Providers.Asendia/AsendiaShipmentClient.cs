using Logistics.Shipping.Abstractions;
using Logistics.Shipping.Abstractions.Shipment.Models;

namespace Logistics.Shipping.Providers.Asendia
{
    // Example of provider being split up by provder service type. In this case, we've a Shipment service type client.
    public class AsendiaShipmentClient : IShipmentProvider
    {
        public string Name { get; set; }

        public Task<Shipment> AddShipment(UpsertShipment request)
        {
            var randId = new Random().Next(0, 50);
            var shipment = new Shipment
            {
                CarrierCode = $"{nameof(AsendiaShipmentClient)}.carrierCode.{randId}",
                CarrierDescription = $"{nameof(AsendiaShipmentClient)}.carrierDescription.{randId}",
                CarrierServiceDescription = $"{nameof(AsendiaShipmentClient)}.carrierServiceDesc.{randId}",
                Currency = $"{nameof(AsendiaShipmentClient)}.currency.{randId}",
                ExternalShipmentIdentifier = $"{nameof(AsendiaShipmentClient)}.externalShipmentId.{randId}",
                SequenceNumber = $"{nameof(AsendiaShipmentClient)}.sequenceNo.{randId}",
                ServiceCode = $"{nameof(AsendiaShipmentClient)}.serviceCode.{randId}",
                TrackingUrl = $"{nameof(AsendiaShipmentClient)}.trackingUrl.{randId}",
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
                CarrierCode = $"{nameof(AsendiaShipmentClient)}.carrierCode.{randId}",
                CarrierDescription = $"{nameof(AsendiaShipmentClient)}.carrierDescription.{randId}",
                CarrierServiceDescription = $"{nameof(AsendiaShipmentClient)}.carrierServiceDesc.{randId}",
                Currency = $"{nameof(AsendiaShipmentClient)}.currency.{randId}",
                ExternalShipmentIdentifier = $"{nameof(AsendiaShipmentClient)}.externalShipmentId.{randId}",
                SequenceNumber = $"{nameof(AsendiaShipmentClient)}.sequenceNo.{randId}",
                ServiceCode = $"{nameof(AsendiaShipmentClient)}.serviceCode.{randId}",
                TrackingUrl = $"{nameof(AsendiaShipmentClient)}.trackingUrl.{randId}",
            };

            return Task.FromResult(shipment);
        }
    }
}
