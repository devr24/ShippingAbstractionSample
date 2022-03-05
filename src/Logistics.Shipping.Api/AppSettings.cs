namespace Logistics.Shipping.Api
{
    public class AppSettings
    {
        public List<PudoSettings> Pudo { get; set; }
        public List<PudoSettings> Shipment { get; set; }
        public List<PudoSettings> Collections { get; set; }
    }

    public class PudoSettings
    {
        public string Provider { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Brand { get; set; }
    }

    public class ShipmentSettings
    {
        public string Brand { get; set; }
    }

    public class CollectionsSettings { }
}
