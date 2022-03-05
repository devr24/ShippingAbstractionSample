namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    public class DeleteShipment
	{
		public string ExternalShipmentIdentifier { get; set; }
		public ShipmentType ShipmentType { get; set; }
	}
}
