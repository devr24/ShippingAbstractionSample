namespace Logistics.Shipping.Abstractions.Pudo.Models
{
    public class PudoLocation
    {
        public string Email { get; init; }
        public string BuildingName { get; init; }
        public decimal DistanceInKm { get; init; }
        public string HouseBlockNumber { get; init; }
        public string KioskId { get; init; }
        public double Longitude { get; init; }
        public double Latitude { get; init; }

        /// <summary>
        /// This not SingPost specific and the model will be reviewed
        /// In particular
        /// Storey
        /// TownOrSuburb
        /// PopstationName
        /// Address Fields - can we use ESW tailored naming
        /// </summary>
        public string PopstationName { get; init; }
        public string PostalCode { get; init; }
        public string Storey { get; init; }
        public string StreetName { get; init; }
        public string UnitNumber { get; init; }
        public string SortCode { get; init; }
        public string OutletId { get; init; }
        public string OutletName { get; init; }
        public string OutletType { get; init; }
        public string TownOrSuburb { get; init; }
        public string City { get; init; }
        public string OperatingHours { get; init; }
        public string PhoneNumber { get; init; }
        public bool AvailableDelivery { get; init; }
        public bool AvailableDropoff { get; init; }
        public string LocationDescription { get; init; }
        public string State { get; init; }
        public string Country { get; init; }
        public string Region { get; init; }
        public string Metadata { get; init; }
        public string Account { get; init; }
        public string Dimension { get; init; }
    }
}
