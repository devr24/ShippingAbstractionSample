namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    public class CloseShipments
    {
        public IReadOnlyCollection<string> ShipmentIdentifiers { get; set; }
    }
}
