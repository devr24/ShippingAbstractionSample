namespace Logistics.Shipping.Abstractions.Shipment.Models
{
    /// <summary>
    /// Facade.EShopWorld.Models.v1.SaveShipment
    /// </summary>
    public class Shipment
	{
		public string CarrierCode { get; set; }
		public string ServiceCode { get; set; }
		public string CarrierDescription { get; set; }
		public string CarrierServiceDescription { get; set; }
		public string SequenceNumber { get; set; }
		public string ExternalShipmentIdentifier { get; set; }
		public DateTime EtaDate { get; set; }
		public ShipmentType ShipmentType { get; set; }
		public string TrackingUrl { get; set; }
		public double Cost { get; set; }
		public double Price { get; set; }
		public string Currency { get; set; }
		public string LabelBase64 { get; set; }
		public IReadOnlyList<Attribute> Attributes { get; set; }
		public IReadOnlyList<Parcel> Parcels { get; set; }
	}
}
